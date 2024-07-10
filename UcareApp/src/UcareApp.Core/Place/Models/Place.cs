namespace UcareApp.Core.Place.Models;

using UcareApp.Core.Place.Base;
using UcareApp.Core.Place.Enums;
using UcareApp.Core.Maintenance.Models;
public class Place : IPlace {
    
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Adress { get; set; }
    public double Longitude { get; set; }
    public double Latitude { get; set; }
    public IEnumerable<WeekDayEnum> WorkingDays { get; set; }
    public IEnumerable<Maintenance> Maintenances { get; set; }
}