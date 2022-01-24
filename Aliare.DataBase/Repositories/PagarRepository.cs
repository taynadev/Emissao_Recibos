using Microsoft.EntityFrameworkCore;
using SistemaFinanceiro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliare.DataBase.Repositories
{
    public class PagarRepository : GenericRepository <PagarModel>
    {
        public object GetByNome(string nome)
        {
            return context.Pagamentos
            .Include(pag => pag.Fornecedor)
            .Include(pag => pag.Empresa)
            .Where(pag => pag.Fornecedor.Nome.Contains(nome))
            .Select(pag => new
            {
                pag.Id,
                CPF = pag.Fornecedor.CnpjCpf,
                Fornecedor = pag.Fornecedor.Nome,                
                Empresa = pag.Empresa.RazaoSocial,
                Valor = pag.Valor,
                Numero = pag.Numero,
                Status = pag.Status,
                Observacao = pag.Observacao
            })
            .ToList();
        }

        public PagarModel GetByIdPagamento(int Id)
        {
            return context.Pagamentos
                .Include(pag => pag.Fornecedor)
                    .ThenInclude(fornecedor => fornecedor.Endereco.Cidade)                    
                .Include(pag => pag.Empresa)                    
                .Where(pag => pag.Id == Id)
                .FirstOrDefault();
        }
    }
}
