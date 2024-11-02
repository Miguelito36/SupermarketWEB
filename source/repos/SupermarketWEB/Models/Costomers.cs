using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupermarketWEB.Models
{
	public class Customer
	{
		public int Id { get; set; }
		public string Document_Number { get; set; }
		public string First_Name { get; set; }
		public string Last_Name { get; set; }
		public string Address { get; set; }
		public DateTime? Birthday { get; set; }
		public string Phone_Number { get; set; }
		public string Email { get; set; }
	}
}
