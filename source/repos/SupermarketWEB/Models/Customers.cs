using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupermarketWEB.Models
{
	public class Customers
	{
		public int Id { get; set; }
		public string Document_Number { get; set; } = string.Empty;
		public string First_Name { get; set; } = string.Empty;
		public string Last_Name { get; set; } = string.Empty;
		public string Address { get; set; }
		public DateTime? Birthday { get; set; }
		public string Phone_Number { get; set; }
		public string Email { get; set; }
	}
}
