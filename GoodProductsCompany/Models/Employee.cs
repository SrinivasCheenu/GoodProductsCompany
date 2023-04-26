using System.ComponentModel.DataAnnotations;

namespace GoodProductsCompany.Models
{
	public class Employee
	{
		[Key]
		public int EID { get; set; }
		[Required]
		[StringLength(50)]
		public string EmpName { get; set; }
		[Required]
		public DateTime EDOB { get; set; }
		[Required]
		public string EmpMail { get; set; }
	}
}
