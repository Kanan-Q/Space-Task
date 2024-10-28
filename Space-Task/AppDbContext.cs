using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Helper;
namespace Space_Task;

internal class AppDbContext
{
    public static List<Country> Countries = new List<Country>();
    public static List<Planet> Planets = new List<Planet>();
    Region region;

    public void CreatePlanet(Planet planet)
    {
        Planets.Add(planet);
        Console.WriteLine("Elave olundu");
    }
    public void DeletePlanet(Planet planet)
    {
        Planet p = Planets.Find(x => x.Name == planet.Name);
        Planets.Remove(p);
        Console.WriteLine("Planet partdadi!");
    }
    public void CreateCountry(Country country)
    {
        Countries.Add(country);
        Console.WriteLine("Elave olundu");
    }
    public void DeleteCountry(Country country)
    {
        Country p = Countries.Find(x => x.Name == country.Name);
        Countries.Remove(country);
        Console.WriteLine("Planet partdadi!");
    }
    public List<Country> GetAllCountries()
    {
        return Countries;
    }
    public List<Planet> GetAllPlanets()
    {
        return Planets;
    }
    public void UpdateCountry(string countryName, Country updatedCountry)
    {
        var country = Countries.SingleOrDefault(x => x.Name == countryName);
        if (country != null)
        {
            country.Name = updatedCountry.Name;
            country.Area = updatedCountry.Area;
            country.Anthem = updatedCountry.Anthem;
        }
    }
    public void UpdatePlanet(string planetName, Planet updatedPlanet)
    {
        var planet = Planets.SingleOrDefault(x => x.Name == planetName);
        if (planet != null)
        {
            planet.Name = updatedPlanet.Name;
            planet.Area = updatedPlanet.Area;
        }
    }

    //public List<Country> GetCountryByRegion(Country country)
    //{
    //    return Countries.Where(c => c.Countries == country).ToList();
    //}

}

