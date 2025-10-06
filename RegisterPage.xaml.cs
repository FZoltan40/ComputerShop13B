using ComputerShop13B.Services;
using System.Windows;
using System.Windows.Controls;

namespace ComputerShop13B
{
    /// <summary>
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        MainWindow _mainWindow;
        IDatabase _database = new Users();
        public RegisterPage(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void regButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(_database.AddRecord(usernameTextBox.Text, passwordTextBox.Password, mailTextBox.Text, fullnameTextBox.Text).ToString());
            _mainWindow.MainFrame.Navigate(new LoginPage(_mainWindow));
        }
    }
}
