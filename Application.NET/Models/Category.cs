using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Application.NET.Models
{
    public class Category
    {
		/*[Key] if variable is something else except id, then we add this key for primary key otherwise id can be 
         * by-default considered as primary key*/

		[Key]
		public int Id { get; set; }
		[Required]
		[MaxLength(30)]
		[DisplayName("Category Name")]
		public string Name { get; set; }
		[DisplayName("Display Order")]
		[Range(1, 20, ErrorMessage = "Display Order must be between 1-5")]
		public int DisplayOrder { get; set; }

	}
}
