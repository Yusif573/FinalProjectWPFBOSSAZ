using FinalProject.Commands;
using FinalProject.DataBase;
using FinalProject.Models;
using FinalProject.MVVM.Views;
using FinalProject.Service;
using System.Windows.Input;

namespace FinalProject.MVVM.ViewModels;

public class EditProfileViewModel : ObservableObject
{
    public Employer newEmployer;
    public Employer NewEmployer { get => newEmployer; set { newEmployer = value; OnPropertyChanged(); } }
    public ICommand EditProfileCommand { get; set; }

    public EditProfileViewModel()
    {
        NewEmployer = new Employer();
        EditProfileCommand = new RelayCommand(EditProfileCommandExecute, CanEditCommandExecute);
    }

    public bool CanEditCommandExecute(object? obj)
    {
        if (!string.IsNullOrEmpty(NewEmployer.Name) && !string.IsNullOrEmpty(NewEmployer.Surname) && !string.IsNullOrEmpty(NewEmployer.Email) && !string.IsNullOrEmpty(NewEmployer.Password) && NewEmployer.BirthDate.ToString() is not null && !string.IsNullOrEmpty(NewEmployer.City) && !string.IsNullOrEmpty(NewEmployer.PhoneNumber))
            return true;
        return false;
    }
    public void EditProfileCommandExecute(object? obj)
    {
        Employer employer = DataBaseClass.employers.FirstOrDefault(e => e.Email.ToLower() == NewEmployer.Email.ToLower());
        if (employer == null) return;
        DataBaseClass.employers.Remove(employer);
        DataBaseClass.employers.Add(NewEmployer);
        NewEmployer = new Employer();
    }
}
