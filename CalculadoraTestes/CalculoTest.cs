using Domain;
using INSS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTestes
{
	[TestClass]
	public class CalculoTest
	{
		[TestMethod]
		public void CalculaDesconto()
		{
			DateTime dataBase = new DateTime(2011, 10, 01);
			decimal salario = 1000;

			CalculadorInss calculadora = new CalculadorInss();

			decimal valor = calculadora.CalcularDesconto(dataBase, salario);

			Assert.IsTrue(valor == 80);
		}

		[TestMethod]
		public void CalculaTeto()
		{
			DateTime dataBase = new DateTime(2011, 10, 01);
			decimal salario = 4000;

			CalculadorInss calculadora = new CalculadorInss();

			decimal valor = calculadora.CalcularDesconto(dataBase, salario);

			Assert.IsTrue(Decimal.Compare(valor, Convert.ToDecimal(405.86)) == 0);
		}
	}
}
