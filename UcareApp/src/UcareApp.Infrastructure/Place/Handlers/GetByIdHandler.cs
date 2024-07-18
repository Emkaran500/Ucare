namespace UcareApp.Infrastructure.Place.Handlers;

using UcareApp.Core.Place.Base;
using MediatR;
using System.Threading.Tasks;
using System.Threading;
using UcareApp.Core.Place.Queries;

public class GetPlaceByIdHandler : IRequestHandler<GetPlaceByIdQuery, bool>
{
    private readonly IPlaceService placeService;

    public GetPlaceByIdHandler(IPlaceService placeService)
    {
        this.placeService = placeService;
    }

    public async Task<bool> Handle(GetPlaceByIdQuery request, CancellationToken cancellationToken)
    {
        if (request.Id == Guid.Empty)
        {
            throw new ArgumentNullException("Id is empty!");
        }

        await placeService.GetPlaceByIdAsync(request.Id);

        return true;
    }
}