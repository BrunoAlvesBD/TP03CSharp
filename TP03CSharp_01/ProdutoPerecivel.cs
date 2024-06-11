using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP03CSharp_01
{

    //A)
    internal class ProdutoPerecivel : Produto, IDescontavel
    {
        private DateTime dataDeValidade;

        public ProdutoPerecivel(string nome, decimal preco, int quantidade,  DateTime dataDeValidade)
            : base(nome, preco, quantidade)
        {
            DataDeValidade = dataDeValidade;

        }

        public DateTime DataDeValidade { get => dataDeValidade; set => dataDeValidade = value; }

        public override decimal ValorTotalEstoque()
        {
            double diasRestantes = (DataDeValidade - DateTime.Now).TotalDays;
            if (diasRestantes <= 7)
            {
                return base.ValorTotalEstoque() * 0.8m;
            }
            else
            {
                return base.ValorTotalEstoque();
            }
        }


            public new void AplicarDesconto(double porcentagem)
        {
            base.AplicarDesconto(porcentagem);
        }

            //B)
            /*
                Em herança a subclasse herda atributos e metodos da superclasse.
            Possibilitando reaproveitamento de código e abstração de informações.
            Aqui a classe ProdutoPerecivel está herdando as informações da classe 
            Produto e o metodo AplicarDesconto proveniente do contrato com a interface.
         
             */
            
        }
    }

