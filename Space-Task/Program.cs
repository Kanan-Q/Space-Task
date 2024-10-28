using System;
namespace Space_Task;
using Core.Helper;
using static System.Console;

internal class Program
{
    static void Main(string[] args)
    {
        AppDbContext db = new AppDbContext();
        string input=" ";
        bool info = false;
        bool result = false;
        bool all = false;
        bool continent = false;
        bool n = false;
        bool names = false;
        do
        {
            WriteLine("1.sisteme giris\n0.sistemnen cixis");
            string number = ReadLine();
            switch (number)
            {
                case "0":
                    WriteLine("Sistemnen cixdiz");
                    break;
                case "1":
                    WriteLine("Sisteme daxil olduz");
                    do
                    {
                        WriteLine("1.Planet yarat(Name ve Area sahesi daxil et)\n2.butun planetleri gor\n3.Planet sec");
                        string planetNum = ReadLine();

                        switch (planetNum)
                        {
                            case "1":

                                do
                                {
                                    WriteLine("Planet name daxil et");
                                    string planetName = ReadLine();
                                    WriteLine($"{planetName}:Adli planet yaradildi");
                                    input=planetName;
                                    int num;
                                    WriteLine("Planet area daxil et");
                                    string planetArea = ReadLine();
                                    if (int.TryParse(planetArea, out num))
                                    {
                                        n = true;
                                        WriteLine($"{planetName}:Adli planet area yaradildi");
                                        Planet planet = new Planet(planetName, num);
                                        db.CreatePlanet(planet);
                                        break;
                                    }
                                    else
                                    {
                                        WriteLine("String yox eded daxil et");
                                        n = false;
                                    }
                                } while (!n);
                                break;
                            case "2":
                                WriteLine("Butun planetler");
                                foreach (var item in db.GetAllPlanets())
                                {
                                    WriteLine(item.ToString());
                                }
                                break;

                            case "3":
                                WriteLine("Planet sec(adini daxil et)");
                                string SelectPlanet = ReadLine();


                                WriteLine($"{SelectPlanet}:Adli planet area yaradildi");
                                do
                                {
                                    WriteLine("1.Olke yarat(ad,himn,sahe)\n2.butun olkeleri gor\n3.Geri qayit\n0.Exit");
                                    string nameCountry = ReadLine();
                                    switch (nameCountry)
                                    {
                                        case "1":
                                            WriteLine("Olke adi daxil et");
                                            string countyName = ReadLine();
                                            WriteLine("Olke Sahesi(EDED) daxil et");
                                            int countyArea = int.Parse(ReadLine());
                                            WriteLine("Olke himni daxil et");
                                            string countyAnthem = ReadLine();
                                            Country country = new Country(countyName, countyArea, countyAnthem);
                                            db.CreateCountry(country);
                                            WriteLine("Olke yardildi");


                                            WriteLine("Qite sec");
                                            do
                                            {
                                                WriteLine("1.Asia\n2.Avropa\n3.Amerika\n4.Antraktida");

                                                string area = ReadLine();
                                                switch (area)
                                                {
                                                    case "1":
                                                        country.region = Region.Amerika;
                                                        continent = true;
                                                        break;
                                                    case "2":
                                                        country.region = Region.Avropa;
                                                        continent = true;
                                                        break;
                                                    case "3":
                                                        country.region = Region.Amerika;
                                                        continent = true;
                                                        break;
                                                    case "4":
                                                        country.region = Region.Antraktida;
                                                        continent = true;

                                                        break;
                                                    case "5":
                                                        country.region = Region.Afrika;
                                                        continent = true;
                                                        break;
                                                    default:
                                                        break;
                                                }
                                            } while (!continent);
                                            break;
                                        case "2":
                                            WriteLine("Butun olkeler");
                                            foreach (var item in db.GetAllCountries())
                                            {
                                                WriteLine(item.ToString());
                                            }
                                            break;
                                        case "3":
                                            WriteLine("Evvelki menuya qayit.");
                                            break;
                                        default:
                                            break;
                                    }
                                } while (!info);
                                break;
                            default:
                                break;
                        }
                    } while (!result);
                    break;
                default: break;
            }

        } while (!all);
    }
}
