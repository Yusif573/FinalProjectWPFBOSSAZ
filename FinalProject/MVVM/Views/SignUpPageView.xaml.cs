using FinalProject.DataBase;
using FinalProject.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace FinalProject.Views;


public partial class SignUpPageView : Page
{
    public SignUpPageView()
    {
        InitializeComponent();
        DataContext = new SignUpPageViewModel();
    }

    private void btnClose_Click(object sender, RoutedEventArgs e)
    {
        NavigationService.GoBack();
    }


    private void btnRegister_Click(object sender, RoutedEventArgs e)
    {
        NavigationService.GoBack();
    }
}
