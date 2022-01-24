using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaFinanceiro.Models
{
    [Table("CIDADES")]                                         // Nome da tabela no banco;
    public class CidadeModel                                   // Nome da classe que representa a tabela, no codigo;
    {
        [Column("CID_ID")]                                     // Nome da coluna na tabela no banco;
        public int Id { get; set; }                            // Nome da propriedade que representa a coluna, no codigo;

        [Column("CID_NOME")]
        public string Nome { get; set; }

        [Column("CID_UF")]
        public string Uf { get; set; }

        public virtual IList<EnderecoModel> Enderecos { get; set; }
        public virtual IList<EmpresaModel> Empresas { get; set; }
    }

    internal class CidadeModelMap : IEntityTypeConfiguration<CidadeModel>     // Mapeamento de relacionamentos;
    {
        public void Configure(EntityTypeBuilder<CidadeModel> builder)
        {
            builder.HasKey(Cidade => new { Cidade.Id });                      // Definição de chave primária da tabela;
        }
    }
}

