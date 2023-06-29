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
    /// Логика взаимодействия для PassportPage.xaml
    /// </summary>
    public partial class PassportPage : Page
    {
        int id;
        public PassportPage(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (Classes.CheckFields.CheckPassport(tbSeria.Text, tbNumber.Text, (DateTime)tbDateI.SelectedDate, tbCode.Text, tbI.Text, tbReg.Text))
            {

                try
                {
                    PassportTable passport = new PassportTable()
                    {
                        IDEmployee=id,
                        Series= tbSeria.Text,
                        Number= tbNumber.Text,
                        DateIssue= (DateTime)tbDateI.SelectedDate,
                        DivisionCode= tbCode.Text,
                        Issued= tbI.Text,
                        PlaceRegistration= tbReg.Text
                    };
                    DataBaseClass.connect.PassportTable.Add(passport);
                    DataBaseClass.connect.SaveChanges();
                    Classes.FrameClass.frmMain.Navigate(new DiplomaPage(passport.IDEmployee));
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
