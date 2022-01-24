using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaFinanceiro.Models
{
    [Table("FORNECEDORES")]                                                             // Nome da tabela no banco;    
    public class FornecedorModel                                                        // Nome da classe que representa a tabela, no codigo;
    {
        [Column("FOR_ID")]
        public int Id { get; set; }                                                // Nome da propriedade que representa a coluna, no codigo;

        [Column("FOR_NOME")]
        public string Nome { get; set; }

        [Column("CNPJ_CPF")]
        public string CnpjCpf { get; set; }

        [Column("END_ID")]
        public int EnderecoId { get; set; }

        public virtual EnderecoModel Endereco { get; set; }
        public virtual IList<PagarModel> Pagamentos { get; set; }
    }

    internal class FornecedorModelMap : IEntityTypeConfiguration<FornecedorModel>           // Mapeamento de relacionamentos;
    {
        public void Configure(EntityTypeBuilder<FornecedorModel> builder)
        {
            builder.HasKey(Fornecedor => new { Fornecedor.Id });                             // Definição de chave primária da tabela;
            builder.HasOne(fornecedor => fornecedor.Endereco)                                // Fornecedor possui um endereço;
                   .WithOne(endereco => endereco.Fornecedor)                                 // Endereço pertence a um Fornecedor;
                   .HasForeignKey<FornecedorModel>(fornecedor => fornecedor.EnderecoId);     // Chave estrangeira;
        }
    }
}
