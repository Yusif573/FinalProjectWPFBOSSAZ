using FinalProject.Commands;
using FinalProject.Service;
using System.Windows.Input;

namespace FinalProject.MVVM.ViewModels;

class AdminWindowViewModel : ObservableObject
{

    public RelayCommand DeleteWorkerCommand { get; set; } 
    public RelayCommand DeleteVacancyAdminCommand { get; set; }

    public AllVacanciesForAdminViewModel AllVacanciesForAdminVM { get; set; }
    public AllWorkersForAdminViewModel AllWorkersForAdminVM { get; set; }


    private object _currentView;

    public object CurrentView
    {
        get { return _currentView; }
        set
        {
            _currentView = value;
            OnPropertyChanged();
        }
    }
    public AdminWindowViewModel()
    {
        AllWorkersForAdminVM = new AllWorkersForAdminViewModel();
        AllVacanciesForAdminVM = new AllVacanciesForAdminViewModel();

        CurrentView = AllVacanciesForAdminVM;

        DeleteVacancyAdminCommand = new RelayCommand(x =>
        {
            CurrentView = AllVacanciesForAdminVM;
        });
        DeleteWorkerCommand = new RelayCommand(x =>
        {
            CurrentView = AllWorkersForAdminVM;
        });
    }


}
