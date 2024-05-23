using FinalProject.Commands;
using FinalProject.DataBase;
using FinalProject.Models;
using FinalProject.MVVM.Models;
using FinalProject.Service;
using System.Windows.Input;

namespace FinalProject.MVVM.ViewModels;

public class CreateVacancyViewModel : ObservableObject
{
    public Vacancy newVacancy;
    public Vacancy NewVacancy { get => newVacancy; set { newVacancy = value; OnPropertyChanged(); } }
    public ICommand CreateVacancyCommand { get; set; }

    public CreateVacancyViewModel()
    {
        NewVacancy = new Vacancy();
        CreateVacancyCommand = new RelayCommand(CreateVacancyCommandExecute, CanCreateVacancyCommandExecute);
    }

    public bool CanCreateVacancyCommandExecute(object? obj)
    {
        if (!string.IsNullOrEmpty(NewVacancy.Name) && !string.IsNullOrEmpty(NewVacancy.NameOfEmployer) && !string.IsNullOrEmpty(NewVacancy.Content) && !string.IsNullOrEmpty(NewVacancy.Requirements) && NewVacancy.dateTime.ToString() is not null && NewVacancy.Salary!=0)
            return true;
        return false;
    }
    public void CreateVacancyCommandExecute(object? obj)
    {
        DataBaseClass.vacancies.Add(NewVacancy);

        NewVacancy = new Vacancy();
    }
}
