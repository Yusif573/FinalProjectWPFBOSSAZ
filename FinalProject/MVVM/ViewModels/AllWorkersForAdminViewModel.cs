using FinalProject.Commands;
using FinalProject.DataBase;
using FinalProject.Models;
using FinalProject.MVVM.Models;
using FinalProject.Service;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace FinalProject.MVVM.ViewModels;

public class AllWorkersForAdminViewModel : ObservableObject
{
    public ObservableCollection<Employer> employers { get; set; }
    private Employer _selectedEmployer;

    public Employer SelectedEmployer
    {
        get { return _selectedEmployer; }
        set { _selectedEmployer = value; OnPropertyChanged(); }
    }

    public ICommand DeleteEmployerCommand { get; }

    public AllWorkersForAdminViewModel()
    {
        employers = new ObservableCollection<Employer>(DataBaseClass.employers);
        DeleteEmployerCommand = new RelayCommand(DeleteVacancy, CanDeleteVacancy);
    }

    private bool CanDeleteVacancy(object parameter)
    {
        if (SelectedEmployer is not null)
            return true;
        return false;
    }

    private void DeleteVacancy(object parameter)
    {
        employers.Remove(SelectedEmployer);
    }
}
