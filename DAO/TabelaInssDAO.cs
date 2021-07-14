using Domain;
using Domain.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public static class TabelaInssDAO
    {
      public static List<TabelaInss> Load()
		  {
				try
				{
					using (StreamReader file = File.OpenText(@"TabelaInss.json"))
					{
						JsonSerializer serializer = new JsonSerializer();
						List<TabelaInss> tabela = (List<TabelaInss>)serializer.Deserialize(file, typeof(List<TabelaInss>));

						return tabela;
					}
				}
				catch (Exception)
				{
					throw new DadosException("Não foi possível localizar as tabelas de base no banco de dados.");
				}
		  }
    }
}
