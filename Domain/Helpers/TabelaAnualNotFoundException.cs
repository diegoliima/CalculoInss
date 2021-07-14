using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Helpers
{
	public class TabelaAnualNotFoundException : Exception
	{

		public TabelaAnualNotFoundException(string message)
			: base(message)
		{

		}
	}
}
