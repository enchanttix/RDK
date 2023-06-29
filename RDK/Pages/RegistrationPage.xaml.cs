using RDK.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }
        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            if (Classes.CheckFields.CheckUser(tbSurname.Text, tbName.Text, tbLogin.Text, pswPassword.Password))
            {
                if (Classes.CheckFields.CheckLogin(tbLogin.Text, null))
                {
                    try //обработка исключения
                    {
                        LoginedTable logined = new LoginedTable()//создаем новый объект класса для входа
                        {
                            Login = tbLogin.Text,
                            Password = pswPassword.Password.GetHashCode()//пароль берется из поля для ввода, а метод шифрует его
                        };
                        UserTable user = new UserTable()//создаем новый объект класса пользователя
                        {
                            ID = logined.ID,
                            Surname = tbSurname.Text,
                            Name = tbName.Text
                        };
                        DataBaseClass.connect.LoginedTable.Add(logined);//добавляем новый объект в базу данных
                        DataBaseClass.connect.UserTable.Add(user);//добавляем новый объект в базу данных
                        DataBaseClass.connect.SaveChanges();//сохраняем изменения в базе данных
                        MessageBox.Show("Пользователь успешно зарегистрирован!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                        Classes.DebugClass.diagWrite("Успешная регистрация. Переход на страницу авторизации");
                        FrameClass.frmMain.Navigate(new AuthorizationPage());//переходим на страницу авторизации
                    }
                    catch (Exception ex)
                    {
                        Classes.DebugClass.diagWrite(ex.Message);
                        MessageBox.Show("Ошибка!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }

                }
            }

        }

        private void btnAuto_Click(object sender, RoutedEventArgs e)
        {
            Classes.FrameClass.frmMain.Navigate(new AuthorizationPage());
        }
    }
}
