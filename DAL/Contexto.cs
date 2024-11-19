using AlmaMaria_AP1_P2.Models;
using Microsoft.EntityFrameworkCore;

namespace AlmaMaria_AP1_P2.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }

    public DbSet<Articulos> Articulos { get; set; }
    public DbSet<Combos> Combos {  get; set; }
    public DbSet<CombosDetalle> CombosDetalles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Articulos>().HasData(
            new List<Articulos>()
            {
             new()
             {
                 ArticuloId = 1,
                 Descripcion = "Procesador",
                 Monto = 15000,             
             },
             new()
             {
                 ArticuloId = 2,
                 Descripcion = "Tarjeta Gráfica",
                 Monto = 24000,
                
             },
             new()
             {
                 ArticuloId = 3,
                 Descripcion = "Ram",
                 Monto = 7000,
                 
             },
             new()
             {
                 ArticuloId = 4,
                 Descripcion = "SSD",
                 Monto = 8000,
                 
             },
             new()
             {
                 ArticuloId = 5,
                 Descripcion = "Refrigeración",
                 Monto = 12000,
             },
             new()
             {
                 ArticuloId = 6,
                 Descripcion = "Placa Madre",
                 Monto = 13000,
             }
            }
        );
        base.OnModelCreating(modelBuilder);
    }

}
