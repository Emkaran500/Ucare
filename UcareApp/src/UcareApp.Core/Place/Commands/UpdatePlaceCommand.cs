namespace UcareApp.Core.Place.Commands;

using MediatR;
using UcareApp.Core.Place.Models;

public class UpdatePlaceCommand : IRequest<bool>
{
    public Place? Place { get; set; }
}