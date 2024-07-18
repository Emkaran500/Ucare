using MediatR;

namespace UcareApp.Core.Place.Commands;

public class UpdatePlaceCommand : IRequest<bool>
{
    public Guid Id { get; set; }
}