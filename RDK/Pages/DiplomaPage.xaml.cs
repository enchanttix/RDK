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
using System.Xml.Linq;

namespace RDK.Pages
{
    /// <summary>
    /// Логика взаимодействия для DiplomaPage.xaml
    /// </summary>
    public partial class DiplomaPage : Page
    {
        int id;
        public DiplomaPage(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (Classes.CheckFields.CheckDiploma(tbSeria.Text, tbNumber.Text, tbSpeciality.Text, (DateTime)tbDate.SelectedDate, tbInstitution.Text, tbProfile.Text, tbEducation.Text))
            {

                try
                {
                    DiplomaTable diploma = new DiplomaTable()
                    {
                        IDEmployee=id,
                        Series= tbSeria.Text,
                        Number= tbNumber.Text,
                        Speciality= tbSpeciality.Text,
                        DateIssue= (DateTime)tbDate.SelectedDate,
                        Institution= tbInstitution.Text,
                        Profile=tbProfile.Text,
                        Education= tbEducation.Text
                    };
                    DataBaseClass.connect.DiplomaTable.Add(diploma);
                    DataBaseClass.connect.SaveChanges();
                    Classes.DebugClass.diagWrite("Полное добавление пользователя, переход на главную страницу");
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
