using FinalProject.Models;
using FinalProject.MVVM.Models;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;

namespace FinalProject.DataBase;

public class DataBaseClass
{
    public static ObservableCollection<Admin> admins { get; set; }
    public static ObservableCollection<Vacancy> vacancies { get; set; }
    public static ObservableCollection<Employer> employers { get; set; }

    public static void CreateVacancyJson()
    {
        JsonSerializerOptions op3 = new JsonSerializerOptions();
        op3.WriteIndented = true;
        var jsonVacations = JsonSerializer.Serialize<ObservableCollection<Vacancy>>(vacancies, op3);
        File.WriteAllText("Vacations.json", jsonVacations);
    }

    public static void CreateEmployerJson()
    {
        JsonSerializerOptions op2 = new JsonSerializerOptions();
        op2.WriteIndented = true;
        var jsonEmployers = JsonSerializer.Serialize<ObservableCollection<Employer>>(employers, op2);
        File.WriteAllText("Employers.json", jsonEmployers);

    }

    static DataBaseClass()
    { 
        admins = new ObservableCollection<Admin>()
        {
            new Admin("Yusif", "Veliyev",DateTime.Now, "a", "a", 2500),
            new Admin("John", "Donen", DateTime.Now, "john.doe@example.com", "password123", 3000),
            new Admin("Alice", "Smith", DateTime.Now, "alice.smith@example.com", "qwerty456", 2800)
        };
        JsonSerializerOptions op = new JsonSerializerOptions();
        op.WriteIndented = true;
        var jsonAdmins = JsonSerializer.Serialize<ObservableCollection<Admin>>(admins, op);
        File.WriteAllText("Admins.json", jsonAdmins);

        employers = new ObservableCollection<Employer>()
        {
            new Employer("Ismayil","Seyidmammadli",DateTime.Now,"isi@gmail.com","123321","Baku", "508959446"),
            new Employer("Michael", "Brown", DateTime.Now, "yusufov573@gmail.com", "password456", "Baku", "508950046"),
            new Employer("Emily", "Johnson", DateTime.Now, "emily.johnson@example.com", "abc123", "Baku", "558069446")
        };
        CreateEmployerJson();

        vacancies = new ObservableCollection<Vacancy>()
        {
            new Vacancy("Ismayil","Software developer",4000,"5 days in a week and 8 hours of work","C# knowledge, WPF, SQL, HTML"),
            new Vacancy("Michael", "Data Analyst",2500, "4 days in a week and 7 hours of work", "Data analysis, SQL, Python, Excel"),
            new Vacancy("Emily", "Web Designer",2000, "6 days in a week and flexible hours", "HTML, CSS, JavaScript, Adobe Photoshop")
        };
        CreateVacancyJson();



    }

    public void AddVacancy(Vacancy vacancy)
    {
        vacancies.Add(vacancy);
        File.Delete("Vacations.json");
        CreateVacancyJson();
    }
    public void AddEmployer(Employer employer)
    {
        employers.Add(employer);
        File.Delete("Employers.json");
        CreateEmployerJson();
    }


    public  void DeleteVacancy(Vacancy vacation)           
    {
        vacancies.Remove(vacation);
        File.Delete("Vacations.json");
        CreateVacancyJson();
    }
    public void DeleteVacancy(string id)
    {
        int Id = int.Parse(id);
        var vacancy = vacancies[Id];
        if (vacancy is not null) { vacancies.Remove(vacancy); CreateVacancyJson(); }
    }





}
