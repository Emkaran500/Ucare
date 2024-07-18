namespace UcareApp.Infrastructure.Place.Handlers;

using UcareApp.Core.Place.Commands;
using UcareApp.Core.Place.Base;
using MediatR;
using System.Threading.Tasks;
using System.Threading;

public class DeleteHandler : IRequestHandler<DeletePlaceCommand, bool>
{
    private readonly IPlaceService placeService;

    public DeleteHandler(IPlaceService placeService)
    {
        this.placeService = placeService;
    }

    public Task<bool> Handle(DeletePlaceCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}