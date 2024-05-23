using FinalProject.Commands;
using FinalProject.MVVM.ViewModels;
using FinalProject.Service;

namespace FinalProject.MVVM.ViewModels;

class MainViewModel : ObservableObject
{


    public RelayCommand HomeViewCommand { get; set; }
    public RelayCommand AllWorkersViewCommand { get; set; }
    public RelayCommand CreateVacancyViewCommand { get; set; }
    public RelayCommand AllVacanciesViewCommand { get; set; }
    public RelayCommand MyVacanciesViewCommand { get; set; }
    public RelayCommand CreateCVViewCommand { get; set; }
    public RelayCommand editProfileCommand { get; set; }

    public HomeViewModel HomeVm { get; set; }
    public AllWorkersViewModel AllWorkersVM { get; set; }
    public CreateVacancyViewModel CreateVacancyVM { get; set; }
    public AllVacanciesViewModel AllVacanciesVM { get; set; }
    public MyVacanciesViewModel MyVacanciesVM { get; set; }
    public CreateCVViewModel CreateCVVM { get; set; }
    public EditProfileViewModel EditProfileVM { get; set; }


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

    public MainViewModel()
    {
        HomeVm = new HomeViewModel();
        AllWorkersVM = new AllWorkersViewModel();
        CreateVacancyVM = new CreateVacancyViewModel();
        AllVacanciesVM = new AllVacanciesViewModel();
        MyVacanciesVM = new MyVacanciesViewModel();
        CreateCVVM = new CreateCVViewModel();
        EditProfileVM = new EditProfileViewModel();

        CurrentView = HomeVm;

        HomeViewCommand = new RelayCommand(x =>
        {
            CurrentView = HomeVm;
        });

        AllWorkersViewCommand = new RelayCommand(x =>
        {
            CurrentView = AllWorkersVM;
        });

        CreateVacancyViewCommand = new RelayCommand(x =>
        {
            CurrentView = CreateVacancyVM;
        });

        AllVacanciesViewCommand = new RelayCommand(x =>
        {
            CurrentView = AllVacanciesVM;
        });
        MyVacanciesViewCommand = new RelayCommand(x =>
        {
            CurrentView = MyVacanciesVM;
        });
        CreateCVViewCommand = new RelayCommand(x =>
        {
            CurrentView = CreateCVVM;
        });
        editProfileCommand = new RelayCommand(x =>
        {
            CurrentView = EditProfileVM;
        });
        }
}
