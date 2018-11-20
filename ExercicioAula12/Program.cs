using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula12
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<Figura>();


            int opcao = 1;

            Console.Clear();

            while (opcao == 1)
            {
                Console.WriteLine("Qual figura deseja Cadastrar? 1 - Triangulo ou 2- Quadrado");
                var forma = Console.ReadLine();

                switch (forma)
                {
                    case "1":

                        var triangulo = new Triangulo();

                        Console.WriteLine("Informe a Descrição do Triângulo: ");
                        triangulo.Descricao = Console.ReadLine();
                        Console.WriteLine("Informe o Tamanho do Lado em cm? ");
                        triangulo.Lado = decimal.Parse(Console.ReadLine());

                        lista.Add(triangulo);
                        Console.Clear();

                        break;
                    case "2":
                        var quadrado = new Quadrado();
                        Console.WriteLine("Informe a Descrição do Quadrado: ");
                        quadrado.Descricao = Console.ReadLine();
                        Console.WriteLine("Informe o tamanho do lado em cm? ");
                        quadrado.Lado = decimal.Parse(Console.ReadLine());

                        lista.Add(quadrado);
                        Console.Clear();

                        break;
                    default:
                        break;
                }
                Console.WriteLine("Incluir alguma figura? 1- SIM 0 - NÃO");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();

            }

            foreach (var item in lista)
            {
                Console.WriteLine("Descrição: " + item.Descricao);
                Console.WriteLine("Lado: " + item.Lado + " cm");
                Console.WriteLine("Area: " + item.CalculoArea() + " cm²");
                Console.WriteLine("Perimetro: " + item.CalculoPerimetro() + " cm");
                Console.WriteLine("--------------------------------------");
            }
            Console.ReadKey();
        }
    }
}
