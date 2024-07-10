using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using UcareApp.Core.Place.Services;
using UcareApp.Core.Place.Base;

namespace UcareApp.Presentation.Controllers;

public class PlaceController : Controller
{

    private readonly IPlaceService placeService;
    public PlaceController(IPlaceService placeService)
    {
        this.placeService = placeService;
    }

    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> Index()
    {
        var places = await this.placeService.GetAllAsync();
        return View(places);
    }
}
