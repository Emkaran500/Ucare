namespace UcareApp.Infrastructure.Place.Handlers;

using UcareApp.Core.Place.Base;
using MediatR;
using System.Threading.Tasks;
using System.Threading;
using UcareApp.Core.Place.Queries;
using UcareApp.Core.Place.Models;

public class GetAllPlacesHandler : IRequestHandler<GetAllPlacesQuery, IEnumerable<Place>>
{
    private readonly IPlaceService placeService;

    public GetAllPlacesHandler(IPlaceService placeService)
    {
        this.placeService = placeService;
    }

    public async Task<IEnumerable<Place>> Handle(GetAllPlacesQuery request, CancellationToken cancellationToken)
    {
        return await this.placeService.GetAllPlacesAsync();
    }
}