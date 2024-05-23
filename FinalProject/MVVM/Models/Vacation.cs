using FinalProject.Service;
using System.Security.Cryptography;

namespace FinalProject.MVVM.Models;

public class Vacancy : ObservableObject
{


    public int _id { get; set; }
    public static int _staticId { get; set; }

    private string ?_nameOfEmployer;
    private string? _name;
    private uint? _salary;
    private string? _content;
    private string? _reuirements;
    private DateTime? _dateTime;


    public string? NameOfEmployer { get => _nameOfEmployer; set { _nameOfEmployer=value ; OnPropertyChanged(); } }
    public string? Name { get => _name; set { _name = value; OnPropertyChanged(); } }
    public uint? Salary { get => _salary; set { _salary = value; OnPropertyChanged(); } }
    public string? Content { get => _content; set { _content = value; OnPropertyChanged(); } }
    public string? Requirements { get => _reuirements; set { _reuirements = value; OnPropertyChanged(); } }
    public DateTime? dateTime { get => _dateTime; set { _dateTime = value;OnPropertyChanged(); } }
    public Vacancy()
    {
        _id = _staticId++;
        dateTime = DateTime.Now;
    }
    public Vacancy(string usernameOfEmployer, string name, uint salary, string content, string requirements)
        : this()
    {
        NameOfEmployer = usernameOfEmployer;
        Name = name;
        Salary = salary;
        Content = content;
        Requirements = requirements;
    }
}
