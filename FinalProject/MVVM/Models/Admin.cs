
namespace FinalProject.Models;

public class Admin : User
{
    public int Salary {  get; set; }
    public Admin(string name, string surname, DateTime birthDate, string email, string password, int salary) : base(name, surname, birthDate, email, password)
    {
        Salary = salary;
    }
}
