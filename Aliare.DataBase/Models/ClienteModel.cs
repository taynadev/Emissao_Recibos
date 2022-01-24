using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaFinanceiro.Models
{
    [Table("CLIENTES")]                                         // Nome da tabela no banco;    
    public class ClienteModel                                   // Nome da classe que representa a tabela, no codigo;
    {
        [Column("CLI_ID")]                                      // Nome da coluna na tabela no banco;        
        public int Id { get; set; }                             // Nome da propriedade que representa a coluna, no codigo;

        [Column("CLI_NOME")]
        public string Nome { get; set; }

        [Column("CPF_CNPJ")]
        public string CpfCnpj { get; set; }

        [Column("END_ID")]
        public int EnderecoId { get; set; }

        public virtual EnderecoModel Endereco { get; set; }
        public virtual IList<ReceberModel> recebimentos { get; set; }
    }

    internal class ClienteModelMap : IEntityTypeConfiguration<ClienteModel>       // Mapeamento de relacionamentos;
    {
        public void Configure(EntityTypeBuilder<ClienteModel> builder)
        {
            builder.HasKey(Cliente => new { Cliente.Id });                        // Chave primária;
            builder.HasOne(cliente => cliente.Endereco)                           // Cliente possui um endereço;
                   .WithOne(endereco => endereco.Cliente)                         // Endereço pertence a um cliente;
                   .HasForeignKey<ClienteModel>(cliente => cliente.EnderecoId);   // Chave estrangeira;
        }
    }
}