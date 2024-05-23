using FinalProject.MVVM.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace FinalProject.MVVM.Views;


public partial class EditProfileView : UserControl
{
    public EditProfileView()
    {
        InitializeComponent();
        DataContext = new EditProfileViewModel();
    }

    private void btnSave_Click(object sender, RoutedEventArgs e)
    {

    }
}
