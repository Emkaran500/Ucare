namespace UcareApp.Core.Place.Base;

public interface IPlaceService
{
    Task<IEnumerable<IPlace>> GetAllAsync();
}