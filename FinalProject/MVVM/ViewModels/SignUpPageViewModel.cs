using FinalProject.Commands;
using FinalProject.DataBase;
using FinalProject.Models;
using FinalProject.Service;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;

namespace FinalProject.ViewModels;

public class SignUpPageViewModel : ObservableObject
{
    public Employer newEmployer;
    public Employer NewEmployer { get => newEmployer; set { newEmployer = value; OnPropertyChanged(); } }
    public ICommand SignUpCommand { get; set; }

    public SignUpPageViewModel()
    {
        NewEmployer = new Employer();
        SignUpCommand = new RelayCommand(SignUpCommandExecute, CanSignUpCommandExecute);
    }

    public bool CanSignUpCommandExecute(object? obj)
    {
        if (!string.IsNullOrEmpty(NewEmployer.Name) && !string.IsNullOrEmpty(NewEmployer.Surname) && !string.IsNullOrEmpty(NewEmployer.Email) && !string.IsNullOrEmpty(NewEmployer.Password) && NewEmployer.BirthDate.ToString() is not null && !string.IsNullOrEmpty(NewEmployer.City) && !string.IsNullOrEmpty(NewEmployer.PhoneNumber))
            return true;
        return false;
    }
    public void SignUpCommandExecute(object? obj)
    {
        DataBaseClass.employers.Add(NewEmployer);
        NewEmployer = new Employer();
    }

}
