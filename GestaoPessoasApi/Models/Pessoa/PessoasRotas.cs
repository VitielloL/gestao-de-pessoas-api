using GestaoPessoasApi.Data;
using GestaoPessoasApi.Models.Pessoa.Request;
using Microsoft.EntityFrameworkCore;

namespace GestaoPessoasApi.Models.Pessoa
{
    public static class PessoasRotas
    {
        public static void AddRotasPessoas(this WebApplication app)
        {
            var pessoasRotas = app.MapGroup("Pessoas");

            //Create
            pessoasRotas.MapPost("", async (AddPessoaRequest request, AppDbContext contexto) =>
            {
                var existe = await contexto.Pessoas.AnyAsync(x => x.Nome.Equals(request.nome) && x.Documento.Equals(request.documento));
                if (existe)
                    return Results.Conflict("Já existe...");


                var pessoa = new Pessoa(request.nome, request.documento);
                await contexto.Pessoas.AddAsync(pessoa);
                await contexto.SaveChangesAsync();
                return Results.Ok(pessoa);
            });


            //Read
            pessoasRotas.MapGet("", async (AppDbContext contexto) =>
            {
                return await contexto.Pessoas.ToListAsync();
            });

            //Upade
            pessoasRotas.MapPut("{id}", async (int id, UpdatePessoaRequest request, AppDbContext context) =>
            {
                var pessoa = await context.Pessoas.SingleOrDefaultAsync(x => x.Id == id);
                if (pessoa is null)
                    return Results.NotFound();

                pessoa.AtualizarNome(request.nome);
                pessoa.AtualizarDocumento(request.documento);
                await context.SaveChangesAsync();

                return Results.Ok(pessoa);

            });

            //Delete
            pessoasRotas.MapDelete("{id}", async (int id, AppDbContext contexto) =>
            {
                var pessoa = await contexto.Pessoas.SingleOrDefaultAsync(x => x.Id == id);
                if (pessoa is null)
                    return Results.NotFound();

                contexto.Pessoas.Remove(pessoa);
                await contexto.SaveChangesAsync();

                return Results.Ok();
            });
        }
    }
}
