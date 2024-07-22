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

    public async Task<bool> Handle(DeletePlaceCommand request, CancellationToken cancellationToken)
    {
        if (request.Id == Guid.Empty)
        {
            throw new ArgumentNullException("Id is empty!");
        }

        await placeService.DeletePlaceAsync(request.Id);

        return true;
    }
}