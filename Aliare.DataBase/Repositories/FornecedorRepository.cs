using Microsoft.EntityFrameworkCore;
using SistemaFinanceiro.Models;
using System.Collections.Generic;
using System.Linq;

namespace Aliare.DataBase.Repositories
{
    public class FornecedorRepository : GenericRepository<FornecedorModel>
    {
        public FornecedorModel GetByCnpjCpf(string cnpjcpf)
        {
            return context.Fornecedores
                   .Include(fornecedor => fornecedor.Endereco)
                        .ThenInclude(end => end.Cidade)
                   .Where(cli => cli.CnpjCpf == cnpjcpf)
                   .FirstOrDefault();
        }

        public object GetByNome(string nome)
        {
            return context.Fornecedores
           .Include(frn => frn.Endereco)
             .ThenInclude(end => end.Cidade)
           .Where(frn => frn.Nome.Contains(nome))
           .Select(frn => new
           {
               frn.Id,
               frn.Nome,
               frn.CnpjCpf,
               frn.Endereco.Numero,
               frn.Endereco.Bairro,
               frn.Endereco.Complemento,
               frn.Endereco.Cep,
               frn.Endereco.Logradouro,
               NomeCidade = frn.Endereco.Cidade.Nome,
               frn.Endereco.Cidade.Uf
           }

           ).ToList();

        }
    }
}
