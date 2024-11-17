using GastroGoPlatform.API.Booking.Domain.Model.Entities;

namespace GastroGoPlatform.API.Booking.Interfaces.REST.Resources;

public record TeamActivityResource(int TeamId, string Name, IEnumerable<Role> Roles);