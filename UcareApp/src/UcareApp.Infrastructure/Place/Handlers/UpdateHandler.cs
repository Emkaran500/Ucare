namespace UcareApp.Infrastructure.Place.Handlers;

using UcareApp.Core.Place.Commands;
using UcareApp.Core.Place.Base;
using MediatR;
using System.Threading.Tasks;
using System.Threading;

public class UpdateHandler : IRequestHandler<UpdatePlaceCommand, bool>
{
    private readonly IPlaceService placeService;

    public UpdateHandler(IPlaceService placeService)
    {
        this.placeService = placeService;
    }

    public Task<bool> Handle(UpdatePlaceCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}