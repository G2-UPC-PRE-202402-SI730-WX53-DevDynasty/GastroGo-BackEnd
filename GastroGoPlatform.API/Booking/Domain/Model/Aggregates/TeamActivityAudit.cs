using System.ComponentModel.DataAnnotations.Schema;
using EntityFrameworkCore.CreatedUpdatedDate.Contracts;

namespace GastroGoPlatform.API.Booking.Domain.Model.Aggregates
{
    public partial class TeamActivityAudit : IEntityWithCreatedUpdatedDate
    {
        [Column("CreadtedAt")] public DateTimeOffset? CreatedDate { get; set; }
        [Column("UpdatedAt")] public DateTimeOffset? UpdatedDate { get; set; }
    }
}
