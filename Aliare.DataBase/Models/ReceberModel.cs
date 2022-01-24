using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaFinanceiro.Models
{
    [Table("RECEBER")]                                                          // Nome da tabela no banco;
    public class ReceberModel                                                   // Nome da classe que representa a tabela, no codigo;
    {
        [Column("REC_ID")]                                                      // Nome da coluna na tabela no banco;       
        public int Id { get; set; }                                             // Nome da propriedade que representa a coluna, no codigo;

        [Column("EMP_ID")]
        public int EmpresaId { get; set; }

        [Column("CLI_ID")]
        public int ClienteId { get; set; }

        [Column("REC_NUME")]
        public string Numero { get; set; }

        [Column("REC_VALOR")]
        public decimal Valor { get; set; }

        [Column("REC_OBSE")]
        public string Observacao { get; set; }

        [Column("REC_DATA")]
        public DateTime Data { get; set; }

        [Column("REC_STAT")]
        public string Status { get; set; }

        public virtual EmpresaModel Empresa { get; set; }
        public virtual ClienteModel Cliente { get; set; }
    }

    internal class ReceberModelMap : IEntityTypeConfiguration<ReceberModel>  // Mapeamento de relacionamentos;
    {
        public void Configure(EntityTypeBuilder<ReceberModel> builder)
        {
            builder.HasKey(Receber => new { Receber.Id });
            builder.HasOne(receber => receber.Empresa)                       // Recebimento é de uma empresa;
                   .WithMany(empresa => empresa.Recebimentos)                // Uma empresa possui vários recebimentos;
                   .HasForeignKey(receber => receber.EmpresaId);             // Chave estrangeira;

            builder.HasOne(receber => receber.Cliente)                        // Recebimento é feito por um cliente;
                   .WithMany(cliente => cliente.recebimentos)                 // Um cliente pode realizar vários pagamentos.;
                   .HasForeignKey(receber => receber.ClienteId);              // Chave estrangeira;
        }
    }
}
