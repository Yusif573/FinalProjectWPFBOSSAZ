using FinalProject.Service;
using System.Xml;

namespace FinalProject.Models;

public class User : ObservableObject
{
    public User() { }
    public User(string name, string surname, DateTime birthDate, string email, string password)
        : this()
    {
        Name = name;
        Surname = surname;
        BirthDate = birthDate;
        Email = email;
        Password = password;
    }

    public string name;
    public string surname;
    public DateTime birthDate;
    public string email;
    public string password;

    public string Name { get => name; set { name = value; OnPropertyChanged(); } }
    public string Surname { get => surname; set { surname = value; OnPropertyChanged(); } }
    public DateTime BirthDate { get => birthDate; set { birthDate = value;OnPropertyChanged(); } }
    public string Email { get => email; set { email = value;OnPropertyChanged(); } }
    public string Password { get => password; set { password = value;OnPropertyChanged(); } }



}
