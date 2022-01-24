using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaFinanceiro.Models
{
    [Table("EMPRESAS")]                                              // Nome da tabela no banco;
    public class EmpresaModel                                        // Nome da classe que representa a tabela, no codigo;
    {
        [Column("EMP_ID")]                                           // Nome da propriedade que representa a coluna, no codigo;
        public int Id { get; set; }                                  // Nome da propriedade que representa a coluna, no codigo;

        [Column("EMP_RAZA")]
        public string RazaoSocial { get; set; }

        [Column("EMP_FANT")]
        public string NomeFantasia { get; set; }

        [Column("EMP_CNPJ")]
        public string Cnpj { get; set; }

        [Column("EMP_CPF")]
        public string Cpf { get; set; }

        [Column("EMP_LOGR")]
        public string Logradouro { get; set; }

        [Column("EMP_BAIR")]
        public string Bairro { get; set; }

        [Column("EMP_COMP")]
        public string Complemento { get; set; }

        [Column("EMP_NUME")]
        public int Numero { get; set; }

        [Column("EMP_CEP")]
        public string Cep { get; set; }

        [Column("CID_ID")]
        public int CidadeId { get; set; }

        [Column("EMP_IE")]
        public string InscEstadual { get; set; }

        public virtual CidadeModel Cidade { get; set; }
        public virtual IList<PagarModel> Pagamentos { get; set; }
        public virtual IList<ReceberModel> Recebimentos { get; set; }
    }

    internal class EmpresaModelMap : IEntityTypeConfiguration<EmpresaModel>    // Mapeamento de relacionamentos;
    {
        public void Configure(EntityTypeBuilder<EmpresaModel> builder)
        {
            builder.HasKey(Empresa => new { Empresa.Id });                     // Definição de chave primária da tabela;
            builder.HasOne(empresa => empresa.Cidade)                          // Empresa está em uma cidade;
                   .WithMany(cidade => cidade.Empresas)                        // Cidade pode ter várias empresas;
                   .HasForeignKey(empresa => empresa.CidadeId);                // Chave estrangeira;
        }
    }

}