using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//Cài cái id sẽ tự tăng
        public int ID { set; get; }

        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        public string URL { set; get; }

        public int? DisplayOrder { set; get; }

        [Required]
        public int GroupID { set; get; }

        [ForeignKey("GroupID")]//Khóa ngoại liên kết đến bảng cha, Viết như này trường GroupID sẽ trỏ đến thuộc tính ID của bảng MenuGroup
        public virtual MenuGroup MenuGroup { set; get; }

        [MaxLength(10)]
        public string Target { set; get; }
        [Required]

        public bool Status { set; get; }
    }
}
