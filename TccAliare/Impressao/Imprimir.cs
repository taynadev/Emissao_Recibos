using Aliare.DataBase.Repositories;
using SistemaFinanceiro.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TccAliare.Impressao
{
    public class Imprimir
    {
        PrintDocument document;
        private string nomeRecebedor;
        private string cpfCnpjRecebedor;
        private string Logradouro;
        private int Numero;
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

        public Imprimir()
        {
            document = new PrintDocument();
            document.PrintController = new StandardPrintController();
            document.DocumentName = "Comprovante";
        }

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
            document.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            PrintPreviewDialog dialog = new PrintPreviewDialog();
            dialog.Document = document;
            (dialog as Form).WindowState = FormWindowState.Maximized;
            dialog.ShowDialog();
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
            document.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            PrintPreviewDialog dialog = new PrintPreviewDialog();
            dialog.Document = document;
            (dialog as Form).WindowState = FormWindowState.Maximized;
            dialog.ShowDialog();
        }

        public void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            valorExtenso = Conversor.EscreverExtenso(valor);

            string texto =
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
                    (string.IsNullOrEmpty(descricao) ? "." : ", em virtude de " + descricao + ".");

            string dataCompleta = cidadeEmpresa + " - " + UFEmpresa + ", " + DateTime.Now.ToString("dd/MM/yyyy");
            string linhaAssintura = ("\n\n\n\n_______________________________________________\n\n");

            StringFormat sf = new StringFormat();

            sf.Alignment = StringAlignment.Center;

            //Captura todo o retângulo dos limites da página
            RectangleF rect = e.PageBounds;

            //Aumenta a coordenada de localização Y
            rect.Y += 100;
            rect.X += 40;
            rect.Width -= 60;

            e.Graphics.DrawString("Recibo", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, rect, sf);
            rect.Y += 100;
            e.Graphics.DrawString(texto, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, rect, sf);
            rect.Y += 150;
            sf.Alignment = StringAlignment.Near;
            e.Graphics.DrawString(dataCompleta, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, rect, sf);
            rect.Y += 50;
            sf.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(linhaAssintura + nomePagador + linhaAssintura + nomeRecebedor, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, rect, sf);
        }
    }
}
