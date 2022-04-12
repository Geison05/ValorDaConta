using System;
using System.Globalization;

namespace Project
{
    class Progam
    {
        static void Main(string[] args)
        {
            //Variavel
            int cod, qte;
            double valor, total;

            //entrada 
            string[] Valor = Console.ReadLine().Split(' ');
            cod = int.Parse(Valor[0]);
            qte = int.Parse(Valor[1]);


            //Processamento
            if (cod == 1)
                total = qte * 4.0;
            else if (cod == 2)
                total = qte * 4.5;
            else if (cod == 3)
                total = qte * 5.0;
            else if (cod == 4)
                total = qte * 2.0;
            else
                total = qte * 1.5;

                //saida
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}