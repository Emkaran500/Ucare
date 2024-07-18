using MediatR;

namespace UcareApp.Core.Place.Queries;

public class GetPlaceByIdQuery : IRequest<bool>
{
    public Guid Id { get; set; }
}