using FinalProject.Commands;
using FinalProject.DataBase;
using FinalProject.MVVM.Models;
using FinalProject.Service;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace FinalProject.MVVM.ViewModels;

public class AllVacanciesForAdminViewModel : ObservableObject
{
    public ObservableCollection<Vacancy> Vacancies { get; set; }
    private Vacancy _selectedVacancy;

    public Vacancy SelectedVacancy
    {
        get { return _selectedVacancy; }
        set { _selectedVacancy = value; OnPropertyChanged(); }
    }

    public ICommand DeleteVacancyCommand { get; }

    public AllVacanciesForAdminViewModel()
    {
        Vacancies = new ObservableCollection<Vacancy>(DataBaseClass.vacancies);
        DeleteVacancyCommand = new RelayCommand(DeleteVacancy, CanDeleteVacancy);
    }

    private bool CanDeleteVacancy(object parameter)
    {
        return SelectedVacancy != null;
    }

    private void DeleteVacancy(object parameter)
    {
        Vacancies.Remove(SelectedVacancy);
    }
}
