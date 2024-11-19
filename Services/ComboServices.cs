using AlmaMaria_AP1_P2.DAL;
using AlmaMaria_AP1_P2.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AlmaMaria_AP1_P2.Services
{
    public class ComboServices(IDbContextFactory<Contexto> DbFactory)
    {
        public async Task<bool> Guardar(Combos combo)
        {
            if(!await Existe(combo.CombosId))
                return await Insertar(combo);
            else
                return await Modificar(combo);

        }

        private async Task<bool> Modificar(Combos combo)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            contexto.Update(combo);
            return await contexto
                .SaveChangesAsync() > 0;

        }

        private async Task<bool> Insertar(Combos combo)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            contexto.Add(combo);
            return await contexto
                .SaveChangesAsync() > 0;
        }

        private async Task<bool> Existe(int Id)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            return await contexto.Combos
                .AnyAsync(c => c.CombosId == Id);
        }

        public async Task<bool> Eliminar(int Id)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            return await contexto.Combos
                .Where(c => c.CombosId == Id)
                .ExecuteDeleteAsync() > 0;

        }

        public async Task<Combos?> Buscar(int Id)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            return await contexto.Combos
                .FirstOrDefaultAsync(c => c.CombosId == Id);
        }

        public async Task<List<Combos>> Listar(Expression<Func<Combos, bool>> criterio)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync(); 
            return await contexto.Combos
                .Where(criterio)
                .AsNoTracking()
                .ToListAsync();
        }

    }
}
