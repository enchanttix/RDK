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

namespace RDK.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            Classes.DebugClass.diagWrite("Переход на страницу регистрации");
            Classes.FrameClass.frmMain.Navigate(new RegistrationPage());
        }

        private void btnAuto_Click(object sender, RoutedEventArgs e)
        {
            if (Classes.CheckFields.CheckAuthorization(tbLogin.Text, pswPassword.Password))
            {
                try
                {
                    int password = pswPassword.Password.GetHashCode();//шифруем строку с паролем из поля для ввода
                    LoginedTable logined = Classes.DataBaseClass.connect.LoginedTable.FirstOrDefault(x => x.Login == tbLogin.Text && x.Password == password);//строка для поиска объекта в базе данных по логину и паролю
                    if (logined != null)//если объект не нулевой то авторизация успешна
                    {
                        Classes.DebugClass.diagWrite("Переход на главную страницу");
                        Classes.FrameClass.frmMain.Navigate(new MainPage());//переход к странице меню
                    }
                    else
                    {
                        Classes.DebugClass.diagWrite("Ошибка входа");
                        MessageBox.Show("Такого пользователя не существует!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                catch (Exception ex)
                {
                    Classes.DebugClass.diagWrite(ex.Message);
                    MessageBox.Show("Ошибка!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
        }
    }
}
