using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class TabelaInss
	{
		public int Ano { get; set; }
		public decimal Teto { get; set; }
		public List<FaixaSalarial> FaixasSalariais;
	}
}
