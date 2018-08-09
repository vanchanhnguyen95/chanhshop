using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Pages")]
    public class Page : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Column(TypeName = "varchar")]//chỉ ra được chính xác kiểu dữ liệu của nó, thường dùng Alias chỉ để varchar thôi
        [MaxLength(256)]
        [Required]
        public string Alias { set; get; }

        public string Content { set; get; }
    }
}
