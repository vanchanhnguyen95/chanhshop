using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("PostCategories")]
    public class PostCategory : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar")]//chỉ ra được chính xác kiểu dữ liệu của nó, thường dùng Alias chỉ để varchar thôi
        [MaxLength(256)]
        public string Alias { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        public int? ParentID { set; get; }
        public int? DisplayOrder { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }

        public bool? HomeFlag { set; get; }

        public virtual IEnumerable<Post> Posts { set; get; }
    }
}