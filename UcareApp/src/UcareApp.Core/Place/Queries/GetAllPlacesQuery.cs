using MediatR;
using UcareApp.Core.Place;

namespace UcareApp.Core.Place.Queries;

public class GetAllPlacesQuery : IRequest<IEnumerable<Models.Place>> {}