using Domain;
using Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
	public class CalculadorInss : ICalculadorInss
	{
		public decimal CalcularDesconto(DateTime data, decimal salario)
		{
			try
			{
				BuscaTabelaInss buscaTabelaInss = new BuscaTabelaInss();

				//Busca tabela do ano repassado
				TabelaInss tabela = buscaTabelaInss.GetTabelaInns(data.Year);

				// Verifica Faixa Salarial
				FaixaSalarial faixaSalarial = tabela.FaixasSalariais.SingleOrDefault(faixa => salario >= faixa.SalarioInicial && salario <= faixa.SalarioFinal);

				if (faixaSalarial != null)
				{
					//Calcula valor baseado na aliquota
					return salario * (faixaSalarial.Aliquota / 100);
				}

				return tabela.Teto;
			}
			catch (DadosException e)
			{ 
				throw e;
			}
			catch (TabelaAnualNotFoundException e)
			{
				throw e;
			}
			catch (Exception e)
			{
				throw new CalculoDescontoException("Não foi possivel realizar o calculo com as informações obtidas.");
			}
		}
	}
}
