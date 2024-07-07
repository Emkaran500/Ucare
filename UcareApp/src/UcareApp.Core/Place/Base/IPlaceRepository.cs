namespace UcareApp.Core.Place.Base;

public interface IPlaceRepository
{
    Task<IEnumerable<IPlace>> GetAllAsync();
}