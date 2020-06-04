using System;
using System.Globalization;

namespace exercicio05
{
    class Program
    {
        static void Main()
        {
            double[] num = new double[9];

            Console.Write("Insira o seu nome: ");
            string nome = Console.ReadLine(); 

            Console.Write("\n1-) Número de peça: ");
            num[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n1-) Quantidade de unidades: ");
            num[1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n1-) Valor da peça: ");
            num[2] = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            num[3] = num[1] * num[2];
            Console.Write("\n--------------------------------------------------\n");
            Console.Write("\n2-) Número de peça: ");
            num[4] = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n2-) Quantidade de unidades: ");
            num[5] = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n2-) Valor da peça: ");
            num[6] = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            num[7] = num[5] * num[6];
            num[8] = num[7] + num[3];

            Console.Clear();
            Console.WriteLine("Todas as informações sobre a sua compra {0}.\n",nome);
            Console.WriteLine("1-) Informações: número da peça: {0} valor da compra das peças: {1:c}", num[0],num[3]);
            Console.WriteLine("2-) Informações: número da peça: {0} valor da compra das peças: {1:c}", num[4], num[7]);

            Console.WriteLine("\nValor total a pagar: R$:{0}",num[8].ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
