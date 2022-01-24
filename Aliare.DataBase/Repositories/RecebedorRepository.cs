using SistemaFinanceiro.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliare.DataBase.Repositories
{
    public class RecebedorRepository : GenericRepository <ReceberModel>
    {
        public object GetByNome(string nome)
        {

            return context.Recebimentos
            .Include(rec => rec.Cliente)
            .Include(rec => rec.Empresa)
            .Where(rec => rec.Cliente.Nome.Contains(nome))
            .Select(rec => new
            {
                rec.Id,
                CPF = rec.Cliente.CpfCnpj,
                Cliente = rec.Cliente.Nome,
                Empresa = rec.Empresa.RazaoSocial,
                Valor = rec.Valor,
                Numero = rec.Numero,
                Status = rec.Status,
                Observacao = rec.Observacao
            })
            .ToList();
        }

        public ReceberModel GetByIdRecebimento(int Id)
        {
            return context.Recebimentos
                .Include(rec => rec.Cliente)
                .Include(rec => rec.Empresa)
                    .ThenInclude(emp => emp.Cidade)
                .Where(rec => rec.Id == Id)
                .FirstOrDefault();
        }
    }
}
