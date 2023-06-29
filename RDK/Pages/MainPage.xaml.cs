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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            //Employee.Items.Add("Все");
            //List<EmployeeTable> list = Classes.DataBaseClass.connect.EmployeeTable.ToList();
            //foreach (EmployeeTable l in list)
            //{
            //    Employee.Items.Add(l.Fio);
            //}

            EmployeeTable employee = new EmployeeTable()
            {
                IDEmployee = 0,
                Surname = "Все"
            };
            List<EmployeeTable> list = Classes.DataBaseClass.connect.EmployeeTable.ToList();
            list.Add(employee);
            Employee.ItemsSource = list.OrderBy(x=> x.IDEmployee).ToList();
            Employee.SelectedValuePath = "IDEmployee";
            Employee.DisplayMemberPath = "Fio";
            Employee.SelectedIndex = 0;
            Parametr.SelectedIndex = 0;
        }
        private void btnEnd_Click(object sender, RoutedEventArgs e)
        {
            Classes.FrameClass.frmMain.Navigate(new AuthorizationPage());
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Classes.FrameClass.frmMain.Navigate(new AddEmployeePage());
        }

        private void btnAddList_Click(object sender, RoutedEventArgs e)
        {
            Classes.FrameClass.frmMain.Navigate(new SickLeavePage());
        }


        private void Employee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<EmployeeTable> employees = Classes.DataBaseClass.connect.EmployeeTable.ToList();
            if(Employee.SelectedIndex!=-1 && Employee.SelectedIndex != 0)
            {
                employees = employees.Where(x => x.IDEmployee == (int)Employee.SelectedValue).ToList();
            }
            if(Parametr.SelectedIndex != -1)
            {
                switch(Parametr.SelectedIndex)
                {
                    case 0:
                        listEmployeesAll.Visibility = Visibility.Visible;
                        listEmployeesAll.ItemsSource = employees;
                        listEmployeesSnils.Visibility = Visibility.Collapsed;
                        listEmployeesInn.Visibility = Visibility.Collapsed;
                        listEmployeesRegistration.Visibility = Visibility.Collapsed;
                        listEmployeesSeries.Visibility = Visibility.Collapsed;
                        listEmployeesNumber.Visibility = Visibility.Collapsed;
                        listEmployeesNumberPassport.Visibility = Visibility.Collapsed;
                        listEmployeesSick.Visibility = Visibility.Collapsed;
                        break;
                    case 1:
                        listEmployeesAll.Visibility = Visibility.Collapsed;
                        listEmployeesSnils.ItemsSource = employees;
                        listEmployeesSnils.Visibility = Visibility.Visible;
                        listEmployeesInn.Visibility = Visibility.Collapsed;
                        listEmployeesRegistration.Visibility = Visibility.Collapsed;
                        listEmployeesSeries.Visibility = Visibility.Collapsed;
                        listEmployeesNumber.Visibility = Visibility.Collapsed;
                        listEmployeesNumberPassport.Visibility = Visibility.Collapsed;
                        listEmployeesSick.Visibility = Visibility.Collapsed;
                        break;
                    case 2:
                        listEmployeesAll.Visibility = Visibility.Collapsed;
                        listEmployeesInn.ItemsSource = employees;
                        listEmployeesSnils.Visibility = Visibility.Collapsed;
                        listEmployeesInn.Visibility = Visibility.Visible;
                        listEmployeesRegistration.Visibility = Visibility.Collapsed;
                        listEmployeesSeries.Visibility = Visibility.Collapsed;
                        listEmployeesNumber.Visibility = Visibility.Collapsed;
                        listEmployeesNumberPassport.Visibility = Visibility.Collapsed;
                        listEmployeesSick.Visibility = Visibility.Collapsed;
                        break;
                    case 3:
                        listEmployeesAll.Visibility = Visibility.Collapsed;
                        listEmployeesNumber.ItemsSource = employees;
                        listEmployeesSnils.Visibility = Visibility.Collapsed;
                        listEmployeesInn.Visibility = Visibility.Collapsed;
                        listEmployeesRegistration.Visibility = Visibility.Collapsed;
                        listEmployeesSeries.Visibility = Visibility.Collapsed;
                        listEmployeesNumber.Visibility = Visibility.Visible;
                        listEmployeesNumberPassport.Visibility = Visibility.Collapsed;
                        listEmployeesSick.Visibility = Visibility.Collapsed;
                        break;
                    case 4:
                        listEmployeesAll.Visibility = Visibility.Collapsed;
                        listEmployeesRegistration.ItemsSource = employees;
                        listEmployeesSnils.Visibility = Visibility.Collapsed;
                        listEmployeesInn.Visibility = Visibility.Collapsed;
                        listEmployeesRegistration.Visibility = Visibility.Visible;
                        listEmployeesSeries.Visibility = Visibility.Collapsed;
                        listEmployeesNumber.Visibility = Visibility.Collapsed;
                        listEmployeesNumberPassport.Visibility = Visibility.Collapsed;
                        listEmployeesSick.Visibility = Visibility.Collapsed;
                        break;
                    case 5:
                        listEmployeesAll.Visibility = Visibility.Collapsed;
                        listEmployeesSeries.ItemsSource = employees;
                        listEmployeesSnils.Visibility = Visibility.Collapsed;
                        listEmployeesInn.Visibility = Visibility.Collapsed;
                        listEmployeesRegistration.Visibility = Visibility.Collapsed;
                        listEmployeesSeries.Visibility = Visibility.Visible;
                        listEmployeesNumber.Visibility = Visibility.Collapsed;
                        listEmployeesNumberPassport.Visibility = Visibility.Collapsed;
                        listEmployeesSick.Visibility = Visibility.Collapsed;
                        break;
                    case 6:
                        listEmployeesAll.Visibility = Visibility.Collapsed;
                        listEmployeesNumberPassport.ItemsSource = employees;
                        listEmployeesSnils.Visibility = Visibility.Collapsed;
                        listEmployeesInn.Visibility = Visibility.Collapsed;
                        listEmployeesRegistration.Visibility = Visibility.Collapsed;
                        listEmployeesSeries.Visibility = Visibility.Collapsed;
                        listEmployeesNumber.Visibility = Visibility.Collapsed;
                        listEmployeesNumberPassport.Visibility = Visibility.Visible;
                        listEmployeesSick.Visibility = Visibility.Collapsed;
                        break;
                    case 7:
                        listEmployeesAll.Visibility = Visibility.Collapsed;
                        listEmployeesSick.ItemsSource = employees;
                        listEmployeesSnils.Visibility = Visibility.Collapsed;
                        listEmployeesInn.Visibility = Visibility.Collapsed;
                        listEmployeesRegistration.Visibility = Visibility.Collapsed;
                        listEmployeesSeries.Visibility = Visibility.Collapsed;
                        listEmployeesNumber.Visibility = Visibility.Collapsed;
                        listEmployeesNumberPassport.Visibility = Visibility.Collapsed;
                        listEmployeesSick.Visibility = Visibility.Visible;
                        break;
                }
            }
        }
    }
}
