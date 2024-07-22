namespace UcareApp.Core.Place.Commands;

using MediatR;
using UcareApp.Core.Place.Models;

public class CreatePlaceCommand : IRequest<bool>
{
    public Place? Place { get; set; }

    public CreatePlaceCommand(Place? place)
    {
        this.Place = place;
    }
}