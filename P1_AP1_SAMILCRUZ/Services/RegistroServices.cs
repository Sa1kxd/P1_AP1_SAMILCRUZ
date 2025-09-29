using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using P1_AP1_SAMILCRUZ.DAL;
using P1_AP1_SAMILCRUZ.Models;
using System.Linq.Expressions;

namespace P1_AP1_SAMILCRUZ.Services;

public class RegistroServices(IDbContextFactory<Contexto> Dbcontext)
{
    public async Task<List<Registro>> Listar(Expression<Func<Registro, bool>> criterio) 
    {
        await using var contexto = await Dbcontext.CreateDbContextAsync();
        return contexto.Registros
            .Where(criterio)
            .ToList();
    }

    
}
