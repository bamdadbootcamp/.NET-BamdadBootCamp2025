using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bamdad.WinForm
{
    public partial class CustomTextBox
    {
		private string _text;
		
		public string Text
		{
			get { return _text; }
			set { _text = value; }
		}
	}


}
