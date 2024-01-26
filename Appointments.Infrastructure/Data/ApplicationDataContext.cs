using Appointments.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Appointments.Infrastructure.Data;

public class ApplicationDataContext : DbContext
{
    public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options) : base(options)
    {
    }

    public DbSet<Appointment> Appointments { get; private set; }
}