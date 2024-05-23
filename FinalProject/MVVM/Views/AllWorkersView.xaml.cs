using FinalProject.MVVM.ViewModels;
using System.Windows.Controls;

namespace FinalProject.MVVM.Views;

public partial class AllWorkersView : UserControl
{
    public AllWorkersView()
    {
        InitializeComponent();
        DataContext = new AllWorkersViewModel();
    }
}
