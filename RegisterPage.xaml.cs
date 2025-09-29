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
        IDatabase _database = new Users();
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void regButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(_database.AddRecord(usernameTextBox.Text, passwordTextBox.Password, mailTextBox.Text, fullnameTextBox.Text).ToString());
        }
    }
}
