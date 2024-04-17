// AuthPage.xaml.cs
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Authorization
{
    public partial class AuthPage : Page
    {
        private int attempts = 0;

        public AuthPage()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            attempts++;
            if (attempts >= 3)
            {
                ShowCaptcha();
            }
            else
            {
                Auth(usernameTextBox.Text, passwordBox.Password);
            }
        }

        private void ShowCaptcha()
        {
            // Здесь вы можете показать капчу пользователю
            MessageBox.Show("Введите символы с картинки (капчу)!");
        }

        private bool ValidateCaptcha(string captchaInput)
        {
            // Здесь должна быть логика проверки капчи
            return captchaInput == "капча_здесь";
        }

        public bool Auth(string login, string password)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль!");
                return false;
            }

            using (var db = new LoginsEntities())
            {
                var user = db.User
                    .AsNoTracking()
                    .FirstOrDefault(u => u.Login == login && u.Password == password);
                if (user == null)
                {
                    MessageBox.Show("Пользователь с такими данными не найден!");
                    return false;
                }
                MessageBox.Show("Пользователь успешно найден!");
                usernameTextBox.Clear();
                passwordBox.Clear();
                return true;
            }
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            RegPage regPage = new RegPage();
            NavigationService.Navigate(regPage);
        }
    }
}
