using System.Globalization;
namespace Course
{
    class Produto
    {
        //São os atributos da classe, os dados que ela va ter.
        public string Nome;
        public double Preco;
        public int Quantidade;

        //O construtor vai levar o mesmo nome da classe
        public Produto(string nome, double preco, int quantidade)// aqui estamos definindo que tem que ter esses valores
        {
            Nome = nome;//O atributo Nome vai receber o valor nomes (que será enviado pelo usuario)
            Preco = preco;
            Quantidade = quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}