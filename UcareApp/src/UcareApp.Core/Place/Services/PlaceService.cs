namespace UcareApp.Core.Place.Services;

using UcareApp.Core.Place.Repositories;
using UcareApp.Core.Place.Base;
using System.Threading.Tasks;
using System.Collections.Generic;


public class PlaceService :  IPlaceService
{
    private readonly IPlaceRepository placeRepository; 
    public PlaceService(IPlaceRepository placeRepository)
    {
        this.placeRepository = placeRepository;
    }    
    public async Task<IEnumerable<IPlace>> GetAllPlacesAsync(){
        return await this.placeRepository.GetAllAsync();
    }

    public async Task<IEnumerable<IPlace>> GetPlacesByIdAsync(int? id){
        ArgumentNullException.ThrowIfNull(id);
        
        return await this.placeRepository.GetByIdAsync(id.Value);
    }
}