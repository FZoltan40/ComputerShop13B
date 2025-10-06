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
        MainWindow _mainWindow;
        IDatabase _database = new Users();
        public LoginPage(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void loginButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (_database.GetData(usernameTextBox.Text, passwordTextBox.Password))
                _mainWindow.MainFrame.Navigate(new UsersDataGrid(_mainWindow));
            else
                MessageBox.Show("Még nem regisztrált tag.");

        }

        private void regLink_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.MainFrame.Navigate(new RegisterPage(_mainWindow));
        }
    }
}
