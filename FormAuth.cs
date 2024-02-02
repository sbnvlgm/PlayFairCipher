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
    public partial class FormAuth : Form
    {
        public string LastAuthUser = "";
        DB db1 = new DB("Data Source=dataBase.DB; Version=3;");
        //ссылка на будущую БД
        public FormAuth()
        {
            InitializeComponent();
        }
        private void log_in_Click(object sender, EventArgs e)
        {
            DB db1 = new DB("Data Source=dataBase.db; Version = 3;");
            if (userAuthSucceess() == true)
            {

                LastAuthUser = login_auth.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }

        private bool userAuthSucceess() //проверка успешности авторизации
        {
            if (incorrectFiledsOnForm())
            {
                MessageBox.Show("Некорректные (пустые?) поля на форме");
                return false;
            }
            if (hasUser(login_auth.Text, pass_auth.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Вход невозможен. Неверный логин или пароль");
                return false;
            }
        }
        private bool hasUser(string login, string password) //проверка существования пользователя
        {
            return db1.CheckUser(login, password, false);
        }
        private bool incorrectFiledsOnForm()
        {
            if (isUnCorrectField(login_auth.Text) || isUnCorrectField(pass_auth.Text))
                return true;
            return false;
        }

        private bool isUnCorrectField(string field)
        {
            if (String.IsNullOrWhiteSpace(field)) //проверка на пустую строку (или только пробелы)
                return true;
            return false;
        }
        private void sign_in_Click(object sender, EventArgs e)//кнопка "Регистрации"
        {
            var FrmReg = new FormReg();
            DB db1 = new DB("Data Source=dataBase.db; Version = 3;"); //передали в форму регистрации ссылку на открытую ДБ
            var regDialogResult = FrmReg.ShowDialog();
            if (regDialogResult == DialogResult.OK)
            {
                LastAuthUser = FrmReg.LastRegUser;
                this.DialogResult = DialogResult.OK;
                this.Close(); //закрытие формы авторизации после успешной регистрации
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
