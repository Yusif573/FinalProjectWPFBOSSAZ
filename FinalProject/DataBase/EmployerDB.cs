using FinalProject.Models;
using FinalProject.MVVM.Models;
using System.Collections.ObjectModel;
using System.Text.Json;

namespace FinalProject.DataBase;

public class EmployerDB
{

    public static ObservableCollection<Vacancy> vacations { get; set; }
    public static ObservableCollection<Employer> employers { get; set; }



    public void AddVacancy(Vacancy vacancy)
    {
        vacations.Add(vacancy);

    }

    public void DeleteVacancy(Vacancy vacation)
    {
        vacations.Remove(vacation);

    }
    public void DeleteVacancy(string id)
    {
        int Id = int.Parse(id);
        var vacancy = vacations[Id];
        if (vacancy is not null) { vacations.Remove(vacancy); }
    }


}
