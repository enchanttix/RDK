using RDK.Classes;
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
    /// Логика взаимодействия для AddEmployeePage.xaml
    /// </summary>
    public partial class AddEmployeePage : Page
    {
        public AddEmployeePage()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (Classes.CheckFields.CheckEmployee(tbSurname.Text, tbName.Text, tbPname.Text, tbDateB.SelectedDate, tbSnils.Text, tbInn.Text, tbDate.SelectedDate, tb.Text))
            {
                if (Classes.CheckFields.CheckLogin(tbLogin.Text, null))
                {
                    try
                    {
                        LoginedTable logined = new LoginedTable()
                        {
                            Login = tbLogin.Text,
                            Password = pswPassword.Password.GetHashCode()
                        };
                        UserTable user = new UserTable()
                        {
                            ID = logined.ID,
                            Surname = tbSurname.Text,
                            Name = tbName.Text
                        };
                        DataBaseClass.connect.LoginedTable.Add(logined);
                        DataBaseClass.connect.UserTable.Add(user);
                        DataBaseClass.connect.SaveChanges();
                        Classes.FrameClass.frmMain.Navigate(new PassportPage());
                    }
                    catch (Exception ex)
                    {
                        //Classes.DebugClass.diagWrite(ex.Message);
                        MessageBox.Show("Ошибка!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }

                }

            }
        }
    }
}
