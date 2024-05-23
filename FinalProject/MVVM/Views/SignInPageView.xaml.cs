using FinalProject.DataBase;
using FinalProject.Views;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;

namespace FinalProject.MVVM.Views;

public partial class SignInPageView : NavigationWindow
{
    MainWindow mainWindow = null;
    AdminWindowView adminWindow = null;
    SignUpPageView signUpPageView = null;
    public SignInPageView()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, RoutedEventArgs e)
    {
        foreach (var user in DataBaseClass.employers)
        {
            if (user.Email == txtUser.Text && user.Password == txtPass.Password)
            {
                mainWindow ??= new MainWindow();
                mainWindow.enableRadioButton();
                mainWindow.labelAccountName.Content = this.txtUser.Text;
                this.Navigate(mainWindow);
                return;
            }

        }
        foreach (var user in DataBaseClass.admins)
        {
            if (user.Email == txtUser.Text && user.Password == txtPass.Password)
            {
                adminWindow ??= new AdminWindowView();
                this.Navigate(adminWindow);
                return;
            }
        }

        infoTxtLbl.Content = "Incorrect Information!";

    }



    private void Button_Click(object sender, RoutedEventArgs e)
    {
        mainWindow ??= new MainWindow();
        mainWindow.disableradioButton();
        this.Navigate(mainWindow);
    }

    private void btnRegister_Click(object sender, RoutedEventArgs e)
    {
        signUpPageView ??= new SignUpPageView();
        this.Navigate(signUpPageView);
    }
}
