using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Double teste, S, Ns, Imp;
            Console.WriteLine("1 - Imposto");
            Console.WriteLine("2 - Novo Salario");
            Console.WriteLine("3 - Classificação");
            Console.WriteLine("4 - Finalizar");
            Console.WriteLine("Digite a opção desejada");
            teste = Convert.ToDouble(Console.ReadLine());
            switch (teste)
            {
                case 1:
                    Console.WriteLine("__Imposto__");
                    Console.WriteLine("Digite o seu salario: ");
                    S = Convert.ToDouble(Console.ReadLine());
                    if (S < 500)
                    {
                        Imp = S * 0.05;

                    }
                    else if (S >= 500 && S <= 850)
                    {
                        Imp = S * 0.10;
                        Console.WriteLine("O valor do imposto é de: " + Imp);
                    }
                    else
                    {
                        Imp = S * 0.15;
                        Console.WriteLine("O valor do imposto é de: " + Imp);


                    }
                    break;
                case 2:
                    Console.WriteLine("__Novo Salario__");
                    Console.WriteLine("Digite o seu salario: ");
                    S = Convert.ToDouble(Console.ReadLine());
                    if (S > 1500)
                    {
                        Ns = S + 25;
                        Console.WriteLine("O valor do Novo salario é de: " + Ns);
                    }
                    else if (S >= 750 && S <= 1500)
                    {
                        Ns = S + 50;
                        Console.WriteLine("O valor do Novo salario é de: " + Ns);
                    }
                    else if (S >= 450 && S <= 750)
                    {
                        Ns = S + 75;
                        Console.WriteLine("O valor do Novo salario é de: " + Ns);
                    }
                    else
                    {
                        Ns = S + 100;
                        Console.WriteLine("O valor do Novo salario é de: " + Ns);

                    }
                    break;
                case 3:
                    Console.WriteLine("__Classificação__");
                    Console.WriteLine("Digite o seu salario: ");
                    S = Convert.ToDouble(Console.ReadLine());
                    if (S <= 700)
                    {
                        Console.WriteLine("O funcionario é Mal-remunerado");
                    }
                    else
                        Console.WriteLine("O Funcionario é bem remunerado");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Você decidiu finalizar a consulta :D");
                    break;







            }
            Console.ReadKey();













        }
    }
}
