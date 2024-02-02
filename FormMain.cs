using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ToolTip;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Coursework_iss
{
    public partial class FormMain : Form
    {

        DB db1 = new DB("Data Source=dataBase.DB; Version=3;");

        public string RegUser;
        public string EncTimeStamp;
        public FormMain()
        {
            InitializeComponent();
            this.inputKey.TextChanged += new EventHandler(onInputKeyChange);

        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            string currentDirectoryPath = Path.GetDirectoryName(Application.ExecutablePath);
            if (!File.Exists($"{currentDirectoryPath}\\dataBase.db"))
            {

                db1.InitializeDatabase();
            }
            else
            {
                db1 = new DB("Data Source=dataBase.db; Version = 3;");
            }
            var FrmAuth = new FormAuth(); //создаём новый экземпляр формы авторизации
            db1 = new DB("Data Source=dataBase.db; Version = 3;");
            DialogResult authDialogResult = FrmAuth.ShowDialog();
            if (authDialogResult != DialogResult.OK)
            {
                db1.CloseDB();
                MessageBox.Show("Вы не авторизовались!");
                this.Close();
            }
            RegUser = FrmAuth.LastAuthUser;
            this.Text = "Шифрование (" + RegUser + ")";


        }
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //при закрытие основного окна, закрывается база данных
            db1.CloseDB();
        }
        public void WriteFile() //не вызываем
        { //Запись результата шифрования в файл принудительно
            string s = EncLabel.Text;
            string FName = RegUser + "_"; //FName - имя файла, формируется автоматически
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] >= '0') && (s[i] <= '9'))
                {
                    FName += s[i];
                }
            }
            StreamWriter fi = new StreamWriter(FName + ".txt", false);
            fi.WriteLine("{Encoded}");
            fi.WriteLine(inputMessage.Text);
            fi.WriteLine(" ");
            fi.WriteLine("{Decoded}");
            fi.WriteLine(outputMessage.Text);
            fi.WriteLine("{Key}");
            fi.WriteLine(inputKey.Text);
            fi.WriteLine("{Check}");
            fi.WriteLine(checkMessage.Text);
            fi.Close();
        }

        public void WriteFile(string FName)
        { //Запись результата шифрования в файл
            StreamWriter fi = new StreamWriter(FName, false);
            EncrFBox.Text = FName;
            fi.WriteLine(EncLabel.Text);
            fi.WriteLine(outputMessage.Text);
            fi.WriteLine(inputKey.Text);
            fi.WriteLine(checkMessage.Text);
            fi.Close();
        }

        private void SaveEncrBut_Click(object sender, EventArgs e)
        {
            if (outputMessage.Text.Length > 0)
            {  //сохранение шифрованного текста
                if (EncrSaveDi.ShowDialog() == DialogResult.OK)
                {
                    WriteFile(EncrSaveDi.FileName); //вызов функции сохр. файла 
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Текст для сохранения отсутствует");
                return;
            }
        }

        private void EncrOpenBut_Click(object sender, EventArgs e)
        {
            //обработка события при нажатии на кнопку открыть файл (файл раньше был сохранён)
            if (EncrOpenDi.ShowDialog() == DialogResult.OK)
            {
                StreamReader fi = new StreamReader(EncrOpenDi.FileName);
                EncLabel.Text = fi.ReadLine();
                EncrFBox.Text = EncrOpenDi.FileName;
                outputMessage.Text = fi.ReadLine();
                inputKey.Text = fi.ReadLine();
                checkMessage.Text = fi.ReadLine();
                fi.Close();
            }
        }
        private void encrypt_buttom_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(inputKey.Text))
            {
                MessageBox.Show("Ключ еще не заполнен");
                return;
            }
            if (String.IsNullOrWhiteSpace(inputMessage.Text))
            {
                MessageBox.Show("Поле ввода текста для шифрования еще не заполнено");
                return;
            }
            string di = inputKey.ToString();

            Playfair pl = new Playfair(di);
            outputMessage.Text = pl.Encode(inputMessage.Text); // вызов функции шифрования
            checkMessage.Text = pl.Decode(outputMessage.Text); // вызов функции дешифрования для контроля
            //Данные входящие в подсказку: 
            EncTimeStamp = DateTime.Now.ToString();
            EncLabel.Text = RegUser + ", " + EncTimeStamp + ", Ключ= " + inputKey;
            EncrFBox.Text = "(Ещё не сохранён)";
        }


        private void onInputKeyChange(object sender, EventArgs e)
        {

            String key = this.inputKey.Text;
            this.inputKey.Text = key;
            Playfair pl = new Playfair(key);
            this.inputKey.SelectionStart = this.inputKey.Text.Length == 0 ? 0 : this.inputKey.Text.Length;
            this.inputKey.SelectionLength = 0;

            var keyShow = pl.GenerateAlphabet(key);
            this.textBoxKey.Text = keyShow;
        }
        private void MainCancel_Click(object sender, EventArgs e)
        {
            // обработка события нажатия кнопки закрыть окно
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                
                this.Close(); //закрытие приложения 
                var FrmAuth = new FormAuth();
                var AuthDialogResult = FrmAuth.ShowDialog();
                
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void EncrOpenBut_MouseMove(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(EncrOpenBut, "Открыть файл");
        }

        private void SaveEncrBut_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(EncrOpenBut, "Сохранить шифр");
        }

        private void encrypt_buttom_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(EncrOpenBut, "Зашифровать текст");
        }
    }
}
