using FinalProject.Service;

namespace FinalProject.MVVM.Models;

public class CV : ObservableObject
{
    public string? ixtisas;
    public string? oxuduguMekteb;
    public int uniyeQebulBali;
    public string? bacariqlar;
    public string? ishlediyiYerler;
    public int tecrube;
    public string? bildiyiDillerVeseviyyeleri;
    public bool ferlenmeDiplomu;

    public string? Ixtisas { get => ixtisas; set { ixtisas = value; OnPropertyChanged(); } }
    public string? OxuduguMekteb { get => oxuduguMekteb; set { oxuduguMekteb = value;OnPropertyChanged(); } }
    public int UniyeQebulBali { get => uniyeQebulBali; set { uniyeQebulBali = value;OnPropertyChanged(); } }
    public string? Bacariqlar { get => bacariqlar; set { bacariqlar = value; OnPropertyChanged(); } }
    public string? IshlediyiYerler { get => ishlediyiYerler; set { ishlediyiYerler = value;OnPropertyChanged(); } }
    public int Staj { get => tecrube; set { tecrube = value;OnPropertyChanged(); } }
    public string? BildiyiDillerVeLevelleri { get => bildiyiDillerVeseviyyeleri; set { bildiyiDillerVeseviyyeleri = value; OnPropertyChanged(); } }
    public bool FerqlenmeDiplomu { get => ferlenmeDiplomu; set { ferlenmeDiplomu = value;OnPropertyChanged(); } }
    public CV(string ixtisas, string oxuduguMekteb, int uniyeQebulBali, string bacariqlar, string ishlediyiYerler, int staj, string bildiyiDillerVeLevelleri, bool ferqlenmeDiplomu)
    {
        Ixtisas = ixtisas;
        OxuduguMekteb = oxuduguMekteb;
        UniyeQebulBali = uniyeQebulBali;
        Bacariqlar = bacariqlar;
        IshlediyiYerler = ishlediyiYerler;
        Staj = staj;
        BildiyiDillerVeLevelleri = bildiyiDillerVeLevelleri;
        FerqlenmeDiplomu = ferqlenmeDiplomu;
    }
}
