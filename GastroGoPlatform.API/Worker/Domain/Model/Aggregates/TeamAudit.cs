using EntityFrameworkCore.CreatedUpdatedDate.Contracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace GastroGoPlatform.API.Worker.Domain.Model.Aggregates
{
    public partial class TeamAudit : IEntityWithCreatedUpdatedDate
    {
        [Column("CreadtedAt")] public DateTimeOffset? CreatedDate { get; set }
        [Column("UpdatedAt")] public DateTimeOffset? UpdatedDate { get; set }
    }
}
