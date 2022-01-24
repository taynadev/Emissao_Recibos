using Aliare.DataBase.Repositories;
using FastReport;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TccAliare.Impressao
{
    public class FastReport_Imprime
    {

        private string nomeRecebedor;
        private string cpfCnpjRecebedor;
        private string Logradouro;
        private string Numero;
        private string Bairro;
        private string Complemento;
        private string Cep;
        private string Cidade;
        private string Estado;
        private string nomePagador;
        private string CpfCnpjPagador;
        private decimal valor;
        private string valorExtenso;
        private string descricao;
        private string cidadeEmpresa;
        private string UFEmpresa;
        public void DadosRecibo(int id)
        {
            RecebedorRepository recebedorRepository = new RecebedorRepository();
            var receber = recebedorRepository.GetByIdRecebimento(id);
            valor = receber.Valor;
            descricao = receber.Observacao;

            nomePagador = receber.Cliente.Nome;
            CpfCnpjPagador = receber.Cliente.CpfCnpj;

            nomeRecebedor = receber.Empresa.RazaoSocial;

            if (receber.Empresa.Cnpj != null)
                cpfCnpjRecebedor = receber.Empresa.Cnpj;
            else
                cpfCnpjRecebedor = receber.Empresa.Cpf;

            Logradouro = receber.Empresa.Logradouro;
            Numero = receber.Empresa.Numero;
            Bairro = receber.Empresa.Bairro;
            Complemento = receber.Empresa.Complemento;
            Cep = receber.Empresa.Cep.ToString();
            Cidade = receber.Empresa.Cidade.Nome;
            Estado = receber.Empresa.Cidade.Uf;
            cidadeEmpresa = receber.Empresa.Cidade.Nome;
            UFEmpresa = receber.Empresa.Cidade.Uf;

            Imprimir();
        }
        public void DadosPagamento(int id)
        {
            PagarRepository pagarRepository = new PagarRepository();
            var pagamento = pagarRepository.GetByIdPagamento(id);
            valor = pagamento.Valor;
            descricao = pagamento.Observacao;

            nomeRecebedor = pagamento.Fornecedor.Nome;
            cpfCnpjRecebedor = pagamento.Fornecedor.CnpjCpf;

            Logradouro = pagamento.Fornecedor.Endereco.Logradouro;
            Numero = pagamento.Fornecedor.Endereco.Numero;
            Bairro = pagamento.Fornecedor.Endereco.Bairro;
            Complemento = pagamento.Fornecedor.Endereco.Complemento;
            Cep = pagamento.Fornecedor.Endereco.Cep;

            Cidade = pagamento.Fornecedor.Endereco.Cidade.Nome;
            Estado = pagamento.Fornecedor.Endereco.Cidade.Uf;

            nomePagador = pagamento.Empresa.RazaoSocial;
            if (pagamento.Empresa.Cnpj != null)
                CpfCnpjPagador = pagamento.Empresa.Cnpj;
            else
                CpfCnpjPagador = pagamento.Empresa.Cpf;

            cidadeEmpresa = pagamento.Empresa.Cidade.Nome;
            UFEmpresa = pagamento.Empresa.Cidade.Uf;

            Imprimir();
        }
        public void Imprimir()
        {
            valorExtenso = Conversor.EscreverExtenso(valor);
            TextoFormatado textoformatado = new TextoFormatado()
            {
                Texto_formatado =
                    $"Eu {nomeRecebedor} ({cpfCnpjRecebedor}), localizado em " +
                    (string.IsNullOrEmpty(Logradouro) ? "" : Logradouro + ", ") +
                    (string.IsNullOrEmpty(Numero.ToString()) ? "" : Numero.ToString() + ", ") +
                    (string.IsNullOrEmpty(Complemento) ? "" : Complemento + ", ") +
                    (string.IsNullOrEmpty(Cep) ? "" : Cep + ", ") +
                    (string.IsNullOrEmpty(Bairro) ? "" : Bairro + ", ") +
                    (string.IsNullOrEmpty(Cidade) ? "" : Cidade + "-") +
                    (string.IsNullOrEmpty(Estado) ? "" : Estado + ", ") +
                    $"declaro para os devidos fins que recebi de " +
                    $"{nomePagador} ({CpfCnpjPagador}), o valor de R$ {valor}" +
                    $" ({valorExtenso})" +
                    (string.IsNullOrEmpty(descricao) ? "." : ", em virtude de " + descricao + "."),
                DataCompleta = cidadeEmpresa + " - " + UFEmpresa + ", " + DateTime.Now.ToString("dd/MM/yyyy"),
                ValorExtenso = valorExtenso
            };
            using (Report report = new Report())
            {
                report.Load("Untitled.frx");
                report.RegisterData(new[] { textoformatado }, "cliente");
                report.Design();
            }
        }
        public class TextoFormatado
        {
            public string Texto_formatado { get; set; }
            public string DataCompleta { get; set; }
            public string ValorExtenso { get; set; }
        }

    }
}
