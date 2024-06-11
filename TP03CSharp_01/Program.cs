namespace TP03CSharp_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto computador = new Produto("PC", 4.000m, 3);
            computador.AplicarDesconto(5);
            Console.WriteLine($"Valor em estoque: {computador.Nome}: {computador.ValorTotalEstoque()}");

            ProdutoPerecivel algodaoDoce = new ProdutoPerecivel("Algodão doce", 7.50m, 12, DateTime.Now.AddDays(10));
            algodaoDoce.AplicarDesconto(5);
            Console.WriteLine($"Valor em estoque {algodaoDoce.Nome} com desconto: {algodaoDoce.ValorTotalEstoque()}");


            
        }
    }
}
