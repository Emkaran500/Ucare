using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using UcareApp.Core.Place.Services;
using UcareApp.Core.Place.Base;
using UcareApp.Core.Place.Models;

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
        var places = await this.placeService.GetAllPlacesAsync();
        return View(places);
    }

    [ActionName("Get")]
    [HttpGet("[controller]/[action]/{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var place = await placeService.GetPlaceByIdAsync(id);

        return base.View("OnePlace", place);
    }

    [HttpGet("[action]", Name = "CreatePlace")]
    public IActionResult Create()
    {
        return base.View();
    }

    [HttpPost("[controller]/[action]")]
    public async Task<IActionResult> Create(Place newPlace)
    {
        await placeService.CreateNewPlaceAsync(newPlace);

        return base.RedirectToAction("Index");
    }

    [HttpGet("[action]/{id}", Name = "UpdatePlace")]
    public async Task<IActionResult> Update(Guid id)
    {
        var place = await this.placeService.GetPlaceByIdAsync(id);

        return base.View(place);
    }

    [HttpGet("api/[controller]/[action]")]
    public async Task<IActionResult> Update(Place? place)
    {
        await this.placeService.UpdatePlaceAsync(place);

        return base.RedirectToAction("Get", new {place?.Id});
    }
}
