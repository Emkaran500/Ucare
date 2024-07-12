namespace UcareApp.Core.Place.Services;

using UcareApp.Core.Place.Models;

public interface IPlaceService
{
    Task<IEnumerable<Place>> GetAllPlacesAsync();
    Task<Place> GetPlaceByIdAsync(Guid? id);
    Task CreateNewPlaceAsync(Place? newPlace);
    Task DeletePlaceAsync(Guid id);
    Task UpdatePlaceAsync(Place? place);

}