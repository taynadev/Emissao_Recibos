using Microsoft.EntityFrameworkCore;
using SistemaFinanceiro.Models;
using System.Collections.Generic;
using System.Linq;

namespace Aliare.DataBase.Repositories
{
    public class ClienteRepository : GenericRepository<ClienteModel>
    {
        public ClienteModel GetByCpfCnpj(string cpfcnpj)
        {
            return context.Clientes
                   .Include(cli => cli.Endereco)
                        .ThenInclude(end => end.Cidade)
                   .Where(cli => cli.CpfCnpj == cpfcnpj)
                   .FirstOrDefault();
        }

        public object GetByNome(string nome)
        {

            return context.Clientes
            .Include(cli => cli.Endereco)
            .ThenInclude(end => end.Cidade)
            .Where(cli => cli.Nome.Contains(nome))
               .Select(cli => new
               {
                   cli.Id,
                   cli.Nome,
                   cli.CpfCnpj,
                   cli.Endereco.Numero,
                   cli.Endereco.Bairro,
                   cli.Endereco.Complemento,
                   cli.Endereco.Cep,
                   cli.Endereco.Logradouro,                   
                   NomeCidade = cli.Endereco.Cidade.Nome,
                   cli.Endereco.Cidade.Uf

               })
            .ToList();

        }
    }
}
