using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.inventory.Models.ViewModels
{
	internal class LoginVM
	{
		//[Required(ErrorMessage = "帳號必填")]
		public string Account { get; set; }


		//[Required(ErrorMessage = "密碼必填")]
		public string Password { get; set; }
	}
}
