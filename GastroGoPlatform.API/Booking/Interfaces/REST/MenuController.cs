using GastroGoPlatform.API.Booking.Application.Internal;
using GastroGoPlatform.API.Booking.Domain.Model.Queries;
using GastroGoPlatform.API.Booking.Domain.Services;
using GastroGoPlatform.API.Booking.Interfaces.REST.Resources;
using GastroGoPlatform.API.Booking.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Net.Mime;

namespace GastroGoPlatform.API.Booking.Interfaces.REST;

[ApiController]
[Route("api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
[Tags("Menu")]
public class MenuController(
        IMenuCommandService menuCommandService,
        IMenuQueryService menuQueryService) : ControllerBase
{
    [HttpPost]
    [SwaggerOperation(
        Summary = "Create a new menu",
        Description = "Creates a menu with a list of products",
        OperationId = "CreateMenu"
    )]
    [SwaggerResponse(201, "The menu was created successfully", typeof(MenuResource))]
    public async Task<ActionResult> CreateMenu([FromBody] CreateMenuResource resource)
    {
        var createMenuCommand = CreateMenuCommandFromResourceAssembler.ToCommandFromResource(resource);
        var result = await menuCommandService.Handle(createMenuCommand);

        if (result is null) return BadRequest();

        return CreatedAtAction(nameof(GetMenuById), new { id = result.Id }, MenuResourceFromEntityAssembler.ToResourceFromEntity(result));
    }

    [HttpGet]
    [SwaggerOperation(
            Summary = "Get all menus",
            Description = "Retrieve a list of all menus",
            OperationId = "GetAllMenus"
        )]
    [SwaggerResponse(200, "A list of menus was retrieved", typeof(IEnumerable<MenuResource>))]
    public async Task<ActionResult> GetAllMenu()
    {
        var query = new GetAllMenusQuery();
        var result = await menuQueryService.Handle(query);

        var resources = result.Select(MenuResourceFromEntityAssembler.ToResourceFromEntity).ToList();
        return Ok(resources);
    }

    [HttpGet("{id}")]
    [SwaggerOperation(
            Summary = "Get a menu by ID",
            Description = "Retrieve a menu along with its products by menu ID",
            OperationId = "GetMenuById"
        )]
    [SwaggerResponse(200, "The menu was found", typeof(MenuResource))]
    [SwaggerResponse(404, "Menu not found")]
    public async Task<ActionResult> GetMenuById(int id)
    {
        var query = new GetMenuByIdQuery(id);
        var result = await menuQueryService.Handle(query);

        if (result is null) return NotFound();

        var resource = MenuResourceFromEntityAssembler.ToResourceFromEntity(result);
        return Ok(resource);
    }
}
