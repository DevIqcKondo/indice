using System;

namespace indice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n1;
            int n2;
            int n3;

            n1=10; n2=20; n3=30;

            Console.WriteLine("Valores: \nnúmero 1={0}\nnúmero 2={1}\nnúmero 3={2}\n", n1,n2,n3);

            
            double valorcompra = 5.5;
            double valorvenda;
            double lucro = 0.1;
            string produto = "Boneca";

            valorvenda=valorcompra+(valorcompra*lucro);

            Console.WriteLine("Produto......:{0,10}",produto);
            Console.WriteLine("Vl.Compra......:{0,10:c}",valorcompra);
            Console.WriteLine("Lucro......:{0,10:p}",lucro);
            Console.WriteLine("Vl.Venda......:{0,10:c}",valorvenda);
            
        }
    }
}
