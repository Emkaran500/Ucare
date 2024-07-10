namespace UcareApp.Core.Maintenance.Models;

using  UcareApp.Core.Maintenance.Base;

public class Maintenance : IMaintenance
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}