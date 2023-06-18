using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace YourNamespace
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Password;

            // Проверка адреса почты и пароля на соответствие требованиям
            if (IsValidEmail(email) && IsValidPassword(password))
            {
                // Выполнение входа в систему
                // В данном примере просто выводим сообщение об успешном входе
                txtStatus.Text = "Login successful!";
                txtStatus.Visibility = Visibility.Visible;
            }
            else
            {
                // В случае неверных данных выводим сообщение об ошибке
                txtStatus.Text = "Invalid email or password!";
                txtStatus.Visibility = Visibility.Visible;
            }
        }

        private bool IsValidEmail(string email)
        {
            // Реализуйте свою логику проверки адреса почты
            // Ниже приведен простой пример проверки на наличие символа @
            return email.Contains("@");
        }

        private bool IsValidPassword(string password)
        {
            // Реализуйте свою логику проверки пароля
            // Ниже приведен простой пример проверки на наличие минимальной длины пароля
            return password.Length >= 6;
        }
    }
}


eeeeeeee