namespace UcareApp.Core.Place.Base;

public interface IPlaceService
{
    Task<IEnumerable<IPlace>> GetAllPlacesAsync();
    Task<IEnumerable<IPlace>> GetPlacesByIdAsync(int? id);
}