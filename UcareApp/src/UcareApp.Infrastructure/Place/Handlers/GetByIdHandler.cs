namespace UcareApp.Infrastructure.Place.Handlers;

using UcareApp.Core.Place.Base;
using MediatR;
using System.Threading.Tasks;
using System.Threading;
using UcareApp.Core.Place.Queries;
using UcareApp.Core.Place.Models;

public class GetPlaceByIdHandler : IRequestHandler<GetPlaceByIdQuery, Place>
{
    private readonly IPlaceService placeService;

    public GetPlaceByIdHandler(IPlaceService placeService)
    {
        this.placeService = placeService;
    }

    public async Task<Place> Handle(GetPlaceByIdQuery request, CancellationToken cancellationToken)
    {
        if (request.Id == Guid.Empty)
        {
            throw new ArgumentNullException("Id is empty!");
        }

        return await placeService.GetPlaceByIdAsync(request.Id);
    }
}