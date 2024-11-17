using System.Net.Mime;
using GastroGoPlatform.API.Booking.Domain.Model.Queries;
using GastroGoPlatform.API.Booking.Domain.Services;
using GastroGoPlatform.API.Booking.Interfaces.REST.Resources;
using GastroGoPlatform.API.Booking.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace GastroGoPlatform.API.Booking.Interfaces.REST;

[ApiController]
[Route("api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
[Tags("TeamActivity")]
public class TeamActivityController(
    ITeamActivityCommandService teamActivityCommandService,
    ITeamActivityQueryService teamActivityQueryService
    ) : ControllerBase
{
    [HttpPost]
    [SwaggerOperation(
        Summary = "Create a new team activity",
        Description = "Creates a team activity with a list of team members",
        OperationId = "CreateTeamActivity"
    )]
    
    [SwaggerResponse(201, "The team activity was created successfully", typeof(TeamActivityResource))]
    [SwaggerResponse(400, "Invalid input")]
    public async Task<IActionResult> CreateTeamActivity([FromBody] CreateTeamActivityResource resource)
    {
        var createTeamActivityCommand = CreateTeamActivityCommandFromResourceAssembler.ToCommandFromResource(resource);
        var teamActivity = await teamActivityCommandService.Handle(createTeamActivityCommand);
        if (teamActivity == null) return BadRequest();
        var teamActivityResourceResult = TeamActivityResourceFromEntityAssembler.ToResourceFromEntity(teamActivity);
        
        return CreatedAtAction(nameof(GetTeamActivityById), new { teamId = teamActivity.TeamId }, teamActivityResourceResult);
    }
    
    [HttpGet]
    [SwaggerOperation(
        Summary = "Get all team activities",
        Description = "Retrieve a list of all team activities",
        OperationId = "GetAllTeamActivities"
    )]
    [SwaggerResponse(200, "A list of team activities was retrieved", typeof(IEnumerable<TeamActivityResource>))]
    public async Task<IActionResult> GetAllTeamActivities()
    {
        var getAllTeamActivityQuery = new GetAllTeamsQuery();
        var teamActivities = await teamActivityQueryService.Handle(getAllTeamActivityQuery);
        var resources = teamActivities.Select(TeamActivityResourceFromEntityAssembler.ToResourceFromEntity);
        return Ok(resources);
    }
    
    [HttpGet("{teamId:int}")]
    [SwaggerOperation(
        Summary = "Get a team activity by ID",
        Description = "Retrieve a team activity by team ID",
        OperationId = "GetTeamActivityById"
    )]
    [SwaggerResponse(200, "The team activity was found", typeof(TeamActivityResource))]
    public async Task<IActionResult> GetTeamActivityById([FromRoute] int teamId)
    {
        var teamActivity = await teamActivityQueryService.Handle(new GetTeamActivityByIdQuery(teamId));
        if (teamActivity == null) return NotFound();
        var resource = TeamActivityResourceFromEntityAssembler.ToResourceFromEntity(teamActivity);
        return Ok(resource);
    }
    
    [HttpPost("{teamId:int}/roles")]
    [SwaggerOperation(
        Summary = "Add a role to a team activity",
        Description = "Add a role to a team activity by team ID",
        OperationId = "AddRoleToTeamActivity"
    )]
    [SwaggerResponse(200, "The role was added successfully", typeof(TeamActivityResource))]
    public async Task<IActionResult> AddRoleToTeamActivity([FromRoute] int teamId, [FromBody] AddRoleResource resource)
    {
        var addRoleCommand = AddRoleCommandFromResourceAssembler.ToCommandFromResource(resource, teamId);
        await teamActivityCommandService.Handle(addRoleCommand);
        return Ok();
    }
}