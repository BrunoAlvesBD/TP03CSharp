using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TP03CSharp_01
{
    internal class Produto : IDescontavel
    {
        // A)
        private string _nome;
        private decimal _preco;
        private int _quantidade;

        public Produto(string nome, decimal preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
           
        }

        public string Nome { get => _nome; set => _nome = value; }
        public decimal Preco { get => _preco; set => _preco = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }

        //B)
        public virtual decimal ValorTotalEstoque()
        {

            return Preco * Quantidade;
        }

        public void AplicarDesconto(double porcentagem)
        {
            Preco -= Preco * (decimal)(porcentagem / 100);
        }

        //C)
            /*Os atruibutos desta classe estão privados, ou seja não podem ser acessa e/ou modificados fora da classe Produtos.
             O encapsulamento com get e set permite a utilização desses atributos fora da classe, seja por métodos ou 
            simplesmente para mostrar o valor destes. Esse processo permite menter os atributos seguros dentro da classe.*/


    }
}
