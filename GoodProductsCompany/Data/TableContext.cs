using GoodProductsCompany.Models;
using Microsoft.EntityFrameworkCore;

namespace GoodProductsCompany.Data
{
	public class TableContext : DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<Employee> Employees { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseMySQL(WebApplication.CreateBuilder().Configuration.GetConnectionString("GoodProductsCompanyDB"));
		}
	}
}
