namespace UcareApp.Infrastructure.Place.Handlers;

using UcareApp.Core.Place.Commands;
using UcareApp.Core.Place.Base;
using MediatR;
using System.Threading.Tasks;
using System.Threading;

public class CreateHandler : IRequestHandler<CreatePlaceCommand, bool>
{
    private readonly IPlaceService placeService;

    public CreateHandler(IPlaceService placeService)
    {
        this.placeService = placeService;
    }

    public Task<bool> Handle(CreatePlaceCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}