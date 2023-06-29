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
    /// Логика взаимодействия для SickLeavePage.xaml
    /// </summary>
    public partial class SickLeavePage : Page
    {
        public SickLeavePage()
        {
            InitializeComponent();
            tbEmployee.ItemsSource = Classes.DataBaseClass.connect.EmployeeTable.ToList();
            tbEmployee.SelectedValuePath = "IDEmployee";
            tbEmployee.DisplayMemberPath = "Fio";
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (Classes.CheckFields.CheckSickLeave(tbEmployee.SelectedIndex, (DateTime)tbSart.SelectedDate, (DateTime)tbEnd.SelectedDate))
            {

                try
                {
                    SickLeaveTable list = new SickLeaveTable()
                    {
                        IDEmployee = (int)tbEmployee.SelectedValue,
                        Start= (DateTime)tbSart.SelectedDate,
                        End= (DateTime)tbEnd.SelectedDate
                    };
                    DataBaseClass.connect.SickLeaveTable.Add(list);
                    DataBaseClass.connect.SaveChanges();
                    Classes.DebugClass.diagWrite("Переход на главную страницу");
                    Classes.FrameClass.frmMain.Navigate(new MainPage());
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
