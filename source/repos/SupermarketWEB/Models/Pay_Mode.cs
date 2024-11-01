using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupermarketWEB.Models
{
	public class Pay_Mode
	{
			public int Id { get; set; }
			public string Name { get; set; } = string.Empty;
			public string Observation { get; set; } = string.Empty;
	}
}
