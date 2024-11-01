using GastroGoPlatform.API.Worker.Domain.Model.Commnads;
using GastroGoPlatform.API.Worker.Domain.Model.Queries;
using GastroGoPlatform.API.Worker.Domain.Services.Command;
using GastroGoPlatform.API.Worker.Domain.Services.Query;
using GastroGoPlatform.API.Worker.Interfaces.REST.Resources;
using GastroGoPlatform.API.Worker.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace GastroGoPlatform.API.Worker.Interfaces.REST
{
    public class OrderController(
        IOrderCommandService orderCommandService,
        IOrderQueryService orderQueryService) : ControllerBase
    {
        [SwaggerOperation(
            Summary = "Create a new order",
            Description = "Creates a new order with the provided details",
            OperationId = "CreateOrder"
        )]
        [SwaggerResponse(201, "The order was created successfully", typeof(OrderResource))]
        public async Task<ActionResult> CreateOrder([FromBody] CreateOrderResource resource)
        {
            var createOrderCommand = CreateOrderCommandFromResourceAssembler.ToCommandFromResource(resource);
            var result = await orderCommandService.Handle(createOrderCommand);

            if (result is null) return BadRequest();

            return CreatedAtAction(nameof(GetOrderById), new { id = result.OrderId }, OrderResourceFromEntityAssembler.ToResourceFromEntity(result));
        }

        [HttpGet("by-customer")]
        [SwaggerOperation(
            Summary = "Get orders by customer ID",
            Description = "Retrieves all orders associated with a specific customer ID",
            OperationId = "GetOrderByCustomerId"
        )]
        [SwaggerResponse(200, "Orders found", typeof(IEnumerable<OrderResource>))]
        public async Task<ActionResult> GetOrderByCustomerId([FromQuery] int customerId)
        {
            var getOrderByCustomerIdQuery = new GetOrderByCustomerIdQuery(customerId);
            var result = await orderQueryService.Handle(getOrderByCustomerIdQuery);
            if (result is null) return NotFound();

            // Assuming the result can be a list of orders for the given customer
            var resources = result.Select(OrderResourceFromEntityAssembler.ToResourceFromEntity);
            return Ok(resources);
        }

        [HttpGet("all")]
        [SwaggerOperation(
            Summary = "Get all orders",
            Description = "Retrieves all orders in the system",
            OperationId = "GetAllOrders"
        )]
        [SwaggerResponse(200, "Orders found", typeof(IEnumerable<OrderResource>))]
        public async Task<ActionResult> GetAllOrders()
        {
            var getAllOrdersQuery = new GetAllOrdersQuery(0); // Adjust query parameters as needed
            var result = await orderQueryService.Handle(getAllOrdersQuery);
            if (result == null || !result.Any()) return NotFound();

            var resources = result.Select(OrderResourceFromEntityAssembler.ToResourceFromEntity);
            return Ok(resources);
        }

        [HttpGet("{id}")]
        [SwaggerOperation(
            Summary = "Get an order by ID",
            Description = "Retrieves a specific order by its ID",
            OperationId = "GetOrderById"
        )]
        [SwaggerResponse(200, "Order found", typeof(OrderResource))]
        public async Task<ActionResult> GetOrderById(int id)
        {
            var getOrderByIdQuery = new GetOrderByIdQuery(id);
            var result = await orderQueryService.Handle(getOrderByIdQuery);
            if (result is null) return NotFound();

            var resource = OrderResourceFromEntityAssembler.ToResourceFromEntity(result);
            return Ok(resource);
        }

        [HttpDelete("{id}")]
        [SwaggerOperation(
            Summary = "Delete an order by ID",
            Description = "Deletes an order by its ID",
            OperationId = "DeleteOrder"
        )]
        [SwaggerResponse(204, "Order deleted successfully")]
        public async Task<ActionResult> DeleteOrder(int id)
        {
            var deleteOrderCommand = new DeleteOrderCommand(id);
            var result = await orderCommandService.Handle(deleteOrderCommand);

            if (result is null) return NotFound();

            return NoContent();
        }
    }
}





