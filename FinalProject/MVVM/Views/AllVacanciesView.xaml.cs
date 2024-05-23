using FinalProject.MVVM.ViewModels;
using System.Windows.Controls;

namespace FinalProject.MVVM.Views
{
    /// <summary>
    /// Interaction logic for AllVacanciesView.xaml
    /// </summary>
    public partial class AllVacanciesView : UserControl
    {
        public AllVacanciesView()
        {
            InitializeComponent();
            DataContext = new AllVacanciesViewModel();
        }
    }
}
