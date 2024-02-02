using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_iss
{
    public partial class FormReg : Form
    {
        public string LastRegUser = "";
        DB db1 = new DB("Data Source=dataBase.db; Version = 3;");
        public FormReg()
        {
            InitializeComponent();
        }

        private void button_reg_Click(object sender, EventArgs e)
        {
            bool hasCif = false; //есть ли цифры
            bool hasAlp = false; //есть ли латинские буквы
            for (int i = 0; i < pass_reg.Text.Length; i++)
            {
                hasCif = hasCif || ((pass_reg.Text[i] >= '0') && (pass_reg.Text[i] <= '9'));
                hasAlp = hasAlp || ((pass_reg.Text[i] >= 'a') && (pass_reg.Text[i] <= 'z')) ||
                    ((pass_reg.Text[i] >= 'A') && (pass_reg.Text[i] <= 'Z'));
            }
            //Получили: есть или нет цифры, есть или нет латинские буквы (отдельными 2-мя переменными)


            if (String.IsNullOrWhiteSpace(login_reg.Text) ||
                String.IsNullOrWhiteSpace(pass_reg.Text) ||
                String.IsNullOrWhiteSpace(pass_again_reg.Text))
            {
                MessageBox.Show("Есть неверные (пустые?) поля");
                return;
            }
            else if (pass_reg.Text.Length < 8)
            {
                MessageBox.Show("Пароль менее 8 символов");
                return;
            }
            else if (!(hasCif & hasAlp))
            {
                MessageBox.Show("В пароле требуются лат.буквы и цифры");
                return;
            }
            else if (pass_reg.Text != pass_again_reg.Text)
            {
                MessageBox.Show("Два пароля не совпадают");
                return;
            }
            else
            {
                DB db1 = new DB("Data Source=dataBase.db; Version = 3;");
                if (db1.CheckUser(login_reg.Text, "---", true))
                {
                    MessageBox.Show("Такой пользователь уже зарегистрирован - выберите другой логин");
                    return;
                }
                LastRegUser = login_reg.Text;
                db1.CreateUser(login_reg.Text, pass_reg.Text);
                this.DialogResult = DialogResult.OK;
                this.Close(); //закрываем форму регистрации
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
