using MediatR;
using UcareApp.Core.Place;

namespace UcareApp.Core.Place.Queries;

public class GetPlaceByIdQuery : IRequest<Models.Place>
{
    public Guid Id { get; set; }

    public GetPlaceByIdQuery(Guid id)
    {
        this.Id = id;
    }
}