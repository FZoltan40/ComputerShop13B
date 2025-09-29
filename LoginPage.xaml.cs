using ComputerShop13B.Services;
using System.Windows;
using System.Windows.Controls;

namespace ComputerShop13B
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        IDatabase _database = new Users();
        public LoginPage()
        {
            InitializeComponent();

        }

        private void loginButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MessageBox.Show(_database.GetData(usernameTextBox.Text, passwordTextBox.Password).ToString());

        }
    }
}
