using Microsoft.EntityFrameworkCore;
using SistemaFinanceiro.Models;

namespace SistemaFinanceiro.Context
{
    public class FinanceiroContext : DbContext                                              // Classe Herda de DbContext;
    {
        public DbSet<EmpresaModel> Empresas { get; set; }                                    //Quais as classes que o contexto deve persistir;
        public DbSet<EnderecoModel> Enderecos { get; set; }
        public DbSet<CidadeModel> Cidades { get; set; }
        public DbSet<FornecedorModel> Fornecedores { get; set; }
        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<PagarModel> Pagamentos { get; set; }
        public DbSet<ReceberModel> Recebimentos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)      // Reescreve metodo OnConfiguring, passando a string de conexão com o banco;
        {
            optionsBuilder.UseSqlServer(@"Data Source=NTB-C56D2L3;Initial Catalog=SISTEMAFINANCEIRO;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)                 // Implementa configurações de relacionamentos mapeadas;
        {
            modelBuilder
                .ApplyConfiguration(new EmpresaModelMap())
                .ApplyConfiguration(new CidadeModelMap())
                .ApplyConfiguration(new FornecedorModelMap())
                .ApplyConfiguration(new PagarModelMap())
                .ApplyConfiguration(new ReceberModelMap())
                .ApplyConfiguration(new EnderecoModelMap())
                .ApplyConfiguration(new ClienteModelMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
