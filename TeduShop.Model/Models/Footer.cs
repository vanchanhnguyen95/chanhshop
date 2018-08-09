using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]//ĐỊnh dạng đây là khóa chính nên có thuộc tính là Key, khi gen tự gen khóa chính
        [MaxLength(50)]
        public string ID { set; get; }

        [Required]//Bắt buộc phải nhập, ko cho phép null
        public string Content { set; get; }
    }
}