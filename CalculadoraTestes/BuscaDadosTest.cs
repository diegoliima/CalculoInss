using DAO;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculadoraTestes
{
	[TestClass]
	public class BuscaDadosTest
	{
		[TestMethod]
		public void BuscaDados()
		{
			List<TabelaInss> data = TabelaInssDAO.Load();

			Assert.IsTrue(data.Count > 0);
		}

		[TestMethod]
		public void BuscaDadosAno()
		{
			int ano = 2011;

			List<TabelaInss> data = TabelaInssDAO.Load();

			TabelaInss tabela = data.FirstOrDefault(val => val.Ano == ano);

			Assert.IsTrue(tabela != null && tabela.FaixasSalariais.Count > 0);
		}
	}
}
