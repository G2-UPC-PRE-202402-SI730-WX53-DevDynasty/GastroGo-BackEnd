using GastroGoPlatform.API.Worker.Domain.Model.Queries;
using GastroGoPlatform.API.Worker.Domain.Services.Command;
using GastroGoPlatform.API.Worker.Domain.Services.Query;
using GastroGoPlatform.API.Worker.Interfaces.REST.Resources;
using GastroGoPlatform.API.Worker.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI.Common;
using System.Net.Mime;

namespace GastroGoPlatform.API.Worker.Interfaces.REST
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [Produces(MediaTypeNames.Application.Json)]
    [Tags("Order")]
    public class OrderController(
        IOrderCommandService orderCommandService,
        IOrderQueryService orderQueryService) : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult> CreateOrder([FromBody] CreateOrderResource resource)
        {
            var createOrderCommand = CreateOrderCommandFromResourceAssembler.ToCommandFromResource(resource);
            var result = await orderCommandService.Handle(createOrderCommand);

            if (result is null) return BadRequest();

            return CreatedAtAction(nameof(GetOrderById), new { id = result.OrderId }, OrderResourceFromEntityAssembler.ToResourceFromEntity(result));
        }


        [HttpGet]
        public async Task<ActionResult> GetOrderByCustomerId([FromQuery] int customerId)
        {
            var getOrderByCustomerIdQuery = new GetOrderByCustomerIdQuery(customerId);
            var result = await orderQueryService.Handle(getOrderByCustomerIdQuery);
            if (result is null) return BadRequest();
            var resource = OrderResourceFromEntityAssembler.ToResourceFromEntity(result);
            return Ok(resource);
        }

        [HttpGet]
        public async Task<ActionResult> GetAllOrders([FromQuery] int OrderId)
        {
            var getAllOrdersQuery = new GetAllOrdersQuery(OrderId);
            var result = await orderQueryService.Handle(getAllOrdersQuery);
            if (result is null) return BadRequest();
            var resource = OrderResourceFromEntityAssembler.ToResourceFromEntity(result);
            return Ok(resource);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetOrderById(int id)
        {
            var getOrderByIdQuery = new GetOrderByIdQuery(id);
            var result = await orderQueryService.Handle(getOrderByIdQuery);
            if (result is null) return BadRequest();
            var resource = OrderResourceFromEntityAssembler.ToResourceFromEntity(result);
            return Ok(resource);
        }


    }
}





