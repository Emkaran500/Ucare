namespace UcareApp.Core.Place.Repositories;

using UcareApp.Core.Place.Base;
using UcareApp.Core.Place.Models;

public class PlaceRepository : IPlaceRepository
{
    public async Task<IEnumerable<IPlace>> GetAllAsync(){
        var places = new List<IPlace>();
        return places;
    }
}