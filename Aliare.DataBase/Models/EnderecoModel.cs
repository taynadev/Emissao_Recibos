using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaFinanceiro.Models
{
    [Table("ENDERECOS")]                                              // Nome da tabela no banco;
    public class EnderecoModel                                        // Nome da classe que representa a tabela, no codigo;
    {                                                                 // Nome da propriedade que representa a coluna, no codigo;
        [Column("END_ID")]
        public int Id { get; set; }

        [Column("END_NUME")]
        public string Numero { get; set; }

        [Column("END_BAIR")]
        public string Bairro { get; set; }

        [Column("END_COMP")]
        public string Complemento { get; set; }

        [Column("END_CEP")]
        public string Cep { get; set; }

        [Column("END_LOGR")]
        public string Logradouro { get; set; }

        [Column("CID_ID")]
        public int CidadeId { get; set; }

        public virtual CidadeModel Cidade { get; set; }
        public virtual ClienteModel Cliente { get; set; }
        public virtual FornecedorModel Fornecedor { get; set; }
    }

    internal class EnderecoModelMap : IEntityTypeConfiguration<EnderecoModel>   // Mapeamento de relacionamentos;
    {
        public void Configure(EntityTypeBuilder<EnderecoModel> builder)
        {
            builder.HasKey(Endereco => new { Endereco.Id });                    // Chave primária da tabela;
            builder.HasOne(endereco => endereco.Cidade)                         // Endereço pertence a uma cidade;
                   .WithMany(cidade => cidade.Enderecos)                        // Cidade pode ter vários endereços;       
                   .HasForeignKey(endereco => endereco.CidadeId);              // Chave estrangeira;            
        }
    }
}
