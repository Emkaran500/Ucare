using MediatR;

namespace UcareApp.Core.Place.Commands;

public class DeletePlaceCommand : IRequest<bool>
{
    public Guid Id { get; set; }
}