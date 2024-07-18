namespace UcareApp.Infrastructure.Place.Handlers;

using UcareApp.Core.Place.Base;
using MediatR;
using System.Threading.Tasks;
using System.Threading;
using UcareApp.Core.Place.Queries;

public class GetAllPlacesHandler : IRequestHandler<GetAllPlacesQuery, bool>
{
    private readonly IPlaceService placeService;

    public GetAllPlacesHandler(IPlaceService placeService)
    {
        this.placeService = placeService;
    }

    public Task<bool> Handle(GetAllPlacesQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}