using System.Windows.Controls;

namespace FinalProject.MVVM.Views;

public partial class AdminWindowView : Page
{
    public AdminWindowView()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        NavigationService.GoBack();
    }
}
