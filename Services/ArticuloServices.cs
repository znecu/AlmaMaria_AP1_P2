using AlmaMaria_AP1_P2.DAL;
using AlmaMaria_AP1_P2.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AlmaMaria_AP1_P2.Services;

public class ArticuloServices(IDbContextFactory<Contexto> DbFactory)
{
    public async Task<List<Articulos>> Listar(Expression<Func<Articulos, bool>> criterio)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Articulos
            .Where(criterio)
            .AsNoTracking()
            .ToListAsync();
    }
}
