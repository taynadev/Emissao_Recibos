using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaFinanceiro.Models
{
    [Table("PAGAR")]                                                          // Nome da tabela no banco;
    public class PagarModel                                                   // Nome da classe que representa a tabela, no codigo;
    {
        [Column("PAG_ID")]                                                    // Nome da coluna na tabela no banco;    
        public int Id { get; set; }                                           // Nome da propriedade que representa a coluna, no codigo;

        [Column("EMP_ID")]
        public int EmpresaId { get; set; }

        [Column("FOR_ID")]
        public int FornecedorId { get; set; }

        [Column("PAG_NUME")]
        public string Numero { get; set; }

        [Column("PAG_VALOR")]
        public decimal Valor { get; set; }

        [Column("PAG_OBSE")]
        public string Observacao { get; set; }

        [Column("PAG_DATA")]
        public DateTime Data { get; set; }

        [Column("PAG_STAT")]
        public string Status { get; set; }

        public virtual EmpresaModel Empresa { get; set; }
        public virtual FornecedorModel Fornecedor { get; set; }
    }

    internal class PagarModelMap : IEntityTypeConfiguration<PagarModel>      // Mapeamento de relacionamentos;
    {
        public void Configure(EntityTypeBuilder<PagarModel> builder)
        {
            builder.HasKey(Pagar => new { Pagar.Id });                       // Chave primária;
            builder.HasOne(pagar => pagar.Empresa)                           // Pagamento é realizado por uma empresa;
                   .WithMany(empresa => empresa.Pagamentos)                  // Uma empresa possui vários pagamentos;
                   .HasForeignKey(pagar => pagar.EmpresaId);                 // Chave estrangeira;

            builder.HasOne(pagar => pagar.Fornecedor)                        // Pagamento é para um Fornecedor;
                   .WithMany(fornecedor => fornecedor.Pagamentos)            // Um fornecedor pode receber vários pagamentos;
                   .HasForeignKey(pagar => pagar.FornecedorId);             // Chave estrangeira;
                    
        }
    }
}
