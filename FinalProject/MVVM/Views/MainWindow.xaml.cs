using FinalProject.DataBase;
using FinalProject.Models;
using FinalProject.MVVM.ViewModels;
using FinalProject.MVVM.Views;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace FinalProject.MVVM.Views;


public partial class MainWindow : Page
{
    EditProfileView editProfileView = null;
    public MainWindow()
    {
        InitializeComponent();
        
    }


    private void btnClose_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        NavigationService.GoBack();
    }
    public void disableradioButton()
    {
        createVacancy.IsEnabled = false;
        myVacancies.IsEnabled = false;
        createCV.IsEnabled = false;
        editProfile.IsEnabled = false;
    }
    public void enableRadioButton()
    {
        createVacancy.IsEnabled = true;
        myVacancies.IsEnabled = true;
        createCV.IsEnabled = true;
        editProfile.IsEnabled = true;
    }


    private void editProfile_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        string findEmployer = this.labelAccountName.Content.ToString();
        Employer employer = DataBaseClass.employers.FirstOrDefault(e => e.Email.ToLower() == findEmployer.ToLower());

        editProfileView ??= new EditProfileView();
        editProfileView.name.Content = employer.Name;
        editProfileView.birthday.Content = employer.BirthDate.ToString();
        editProfileView.surname.Content = employer.Surname;
        editProfileView.email.Content = employer.Email;
        editProfileView.password.Content = employer.Password;
        editProfileView.phonenummber.Content = employer.PhoneNumber;
        editProfileView.city.Content = employer.City;
        MessageBox.Show(employer.Name);
    }
}
