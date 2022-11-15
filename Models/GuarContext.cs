
using Microsoft.EntityFrameworkCore;

namespace Guarantee.Models
{
    public class GuarContext : DbContext
{
    public DbSet<TheGuarantor> TheGuarantors { get; set; }
    public DbSet<GuaranteeAgreement> GuaranteeAgreements { get; set; }

    public GuarContext(DbContextOptions<GuarContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }
}
}

