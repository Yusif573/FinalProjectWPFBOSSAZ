
using FinalProject.MVVM.Models;
using System.Runtime.InteropServices;

namespace FinalProject.Models;

public class Employer : User
{
    List<Vacancy> _vacancies;

    public string city;
    public string City { get => city; set { city = value;OnPropertyChanged(); } }
    public string phoneNumber;
    public string PhoneNumber { get => phoneNumber; set {  phoneNumber = value;OnPropertyChanged(); } }
    public Employer() { }
    public Employer(string name, string surname, DateTime birthDate, string email, string password,string _city,string _phoneNumber) : base(name, surname, birthDate, email, password)
        
    {
        City = _city;
        PhoneNumber = _phoneNumber;
    }
}
