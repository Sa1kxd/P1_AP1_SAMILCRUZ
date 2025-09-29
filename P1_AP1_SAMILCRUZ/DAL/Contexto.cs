using Microsoft.EntityFrameworkCore;
using P1_AP1_SAMILCRUZ.Models;

namespace P1_AP1_SAMILCRUZ.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }

    DbSet<Registro> Registros { get; set; }

}
