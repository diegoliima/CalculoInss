using Domain;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Helpers;

namespace INSS
{
	public class BuscaTabelaInss
	{
		public TabelaInss GetTabelaInns(int ano)
		{
			try
			{
				List<TabelaInss> data = TabelaInssDAO.Load();

				TabelaInss tabela = data.FirstOrDefault(val => val.Ano == ano);

				return tabela;
			}
			catch (DadosException e)
			{ 
				throw e;
			}
			catch (Exception e)
			{
				throw new TabelaAnualNotFoundException("Nenhuma tabela de calculo disponivel para o ano encontrado.");
			}
		}
	}
}
