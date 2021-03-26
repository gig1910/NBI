using System;
using System.Windows.Forms;

namespace NBI
{
    public partial class FAuth : Form
    {
        public FAuth()
        {
            InitializeComponent();
        }
        //===Константы и переменные формы
        public const int Max_Number_Attempt = 5;        //максимальное число попыток входа в систему
        public static int Number_Attempt;               //число неправильных попыток входа в систему
        public static int User_Rights;                  //права пользователя: 1 - администратор, 2 - обычный пользователь

        //===Обработка события загрузки формы
        private void Form_Auth_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nbiDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.nbiDataSet.Users);
            Number_Attempt = 0;                //сброс количества попыток входа в систему
        }
        //===Обработка нажатия кнопки "Отмена"
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        //===Обработка нажатия кнопки "Войти" (попытка авторизации в системе)
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var Login_Index = cbLogin.SelectedIndex; //Выбранный логин
            string Password_Text = Users_DataGridView.Rows[Login_Index].Cells[1].Value.ToString(); //Пароль из БД
            string Login_Text = Users_DataGridView.Rows[Login_Index].Cells[1].Value.ToString(); //Логин из БД
            Password_Text = Password_Text.Trim(); //удаление лишних пробелов слева и справа
            Login_Text = Login_Text.Trim();//удаление лишних пробелов слева и справа
            if (tbPassword.Text != Password_Text)  //пароль введен неверно
            {
                Number_Attempt++;  //увеличиваем кол-во неудачных попыток
                if (Number_Attempt == Max_Number_Attempt) //число попыток входа достигло максимума
                {
                    MessageBox.Show("Превышено кол-во попыток входа в систему. Выход из приложения!", "Сообщение об ошибке", MessageBoxButtons.OK);
                    Close(); //Выход из приложения
                }
                else
                {
                    MessageBox.Show("Неверный пароль. Осталось попыток: " + Convert.ToString(Max_Number_Attempt - Number_Attempt), "Сообщение об ошибке", MessageBoxButtons.OK);
                    tbPassword.Text = ""; //Очистка поля ввода пароля
                }
            }
            else   //пароль введен правильно
            {
                if (Login_Text == "admin") //Пользователь с правами администратора
                {
                    User_Rights = 1;
                }
                else //обычный пользователь
                {
                    User_Rights = 2;
                }
                FMain Form_Main = new FMain();
                Form_Main.Show();
                this.Hide(); //скрываем форму входа в приложение
            }
        }
    }
}
