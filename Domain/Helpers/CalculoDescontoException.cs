﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Helpers
{
	public class CalculoDescontoException : Exception
	{
		public CalculoDescontoException(string message)
			: base(message)
		{

		}
	}
}
