namespace UcareApp.Core.Place.Base;

public interface IPlaceRepository
{
    Task<IEnumerable<IPlace>> GetAllAsync();
    Task<IEnumerable<IPlace>> GetByIdAsync(int id);
}