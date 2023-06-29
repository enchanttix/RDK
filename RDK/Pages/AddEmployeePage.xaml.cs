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
            if (Classes.CheckFields.CheckEmployee(tbSurname.Text, tbName.Text, tbPname.Text, (DateTime)tbDateB.SelectedDate, tbSnils.Text, tbInn.Text, (DateTime)tbDate.SelectedDate, tb.Text))
            {

                try
                {
                    EmployeeTable employee = new EmployeeTable()
                    {
                        Surname = tbSurname.Text,
                        Name = tbName.Text,
                        Patronymic = tbPname.Text,
                        DateBirth = (DateTime)tbDateB.SelectedDate,
                        Snils = tbSnils.Text,
                        Inn = tbInn.Text,
                        DateEmployment = (DateTime)tbDate.SelectedDate,
                        Number = tb.Text
                        
                    };                   
                    DataBaseClass.connect.EmployeeTable.Add(employee);
                    DataBaseClass.connect.SaveChanges();
                    Classes.DebugClass.diagWrite("Переход на страницу для ввода паспортных данных");
                    Classes.FrameClass.frmMain.Navigate(new PassportPage(employee.IDEmployee));
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
