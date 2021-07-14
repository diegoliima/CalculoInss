using Domain.Helpers;
using INSS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDescontoInss
{
	class Program
	{
		static void Main(string[] args)
		{

			try
			{
				decimal salario;
				DateTime dataBase;

				Console.WriteLine("Informe a data base para o calculo (XX/XX/XXXX)");

				var dataBaseEntry = Console.ReadLine();

				DateTime.TryParse(dataBaseEntry, out dataBase);

				Console.WriteLine("Informe o salario na data base");
				var salarioEntry = Console.ReadLine();

				decimal.TryParse(salarioEntry, out salario);

				CalculadorInss calculadora = new CalculadorInss();

				decimal valor = calculadora.CalcularDesconto(dataBase, salario);

				Console.WriteLine($"O valor do seu INSS é de {valor}");
			}
			catch (Exception e)
			{
				if(e.InnerException is DadosException || e.InnerException is TabelaAnualNotFoundException || e.InnerException is CalculoDescontoException)
				{
					Console.WriteLine(e.Message);
				}
				else
				{
					Console.WriteLine("Dados em formato incorretos. A aplicação sera finalizada.");
				}
			}
		}
	}
}
