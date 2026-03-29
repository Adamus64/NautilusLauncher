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
            // Natvrdo zadané údaje pro testování
            string spravneJmeno = "admin";
            string spravneHeslo = "heslo123";

            if (txtUsername.Text == spravneJmeno && txtPassword.Password == spravneHeslo)
            {
                // Údaje jsou správné -> Otevřeme MainWindow
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();

                // Zavřeme přihlašovací okno
                this.Close();
            }
            else
            {
                // Špatné údaje -> Zobrazíme chybu
                txtError.Text = "Špatné jméno nebo heslo!";
                txtError.Visibility = Visibility.Visible;
            }
        }
    }
}