// Adam Fiala | IV.C | Programování a vývoj aplikací | Nautilus Launcher |

using System.Windows;

namespace NautilusLauncher
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string spravneJmeno = "admin";
            string spravneHeslo = "heslo123";

            if (txtUsername.Text == spravneJmeno && txtPassword.Password == spravneHeslo)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                
                txtError.Text = "Špatné jméno nebo heslo!";
                txtError.Visibility = Visibility.Visible;
            }
        }
    }
}