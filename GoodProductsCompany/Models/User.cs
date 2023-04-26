using System.ComponentModel.DataAnnotations;

namespace GoodProductsCompany.Models
{
	public class User
	{
		[Key]
		public int UID { get; set; }
		[Required]
		[StringLength(50)]
		public string UName { get; set; }
		[Required]
		[MinLength(8)]
		public string UPassword { get; set; }
	}
}
