using FinalProject.Models;
using FinalProject.MVVM.Models;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;

namespace FinalProject.DataBase;

public class AdminDataBase
{
    public ObservableCollection<Admin> admins { get; set; }

    public ObservableCollection<Vacancy> vacations { get; set; }


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
