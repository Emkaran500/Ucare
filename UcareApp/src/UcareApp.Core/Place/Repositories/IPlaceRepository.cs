namespace UcareApp.Core.Place.Repositories;

using UcareApp.Core.Place.Models;
public interface IPlaceRepository
{
    Task<IEnumerable<Place>> GetAllAsync();
    Task<Place> GetByIdAsync(Guid? id);
    Task CreateAsync(Place? newPlace);
    Task DeleteAsync(Guid? id);
    Task<long> UpdateAsync(Place? place);


}