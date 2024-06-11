using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP03CSharp_01
{
    //A)
    internal interface IDescontavel
    {
        void AplicarDesconto(double porcentagem);
    }

    //B)
    /*com o metodo desta interface é possivel sreceber a porcentagem de desconto  conforme o produto
    e retornar o valor com o desconto.*/

    //C)
    /*Com a interface é possivel estabeler contratos nos códigos, onde as classe 
     que herdam os metodos da interface podem seguir determinados padrões 
    facilitamdo a criação dos algoritmos.*/
}
