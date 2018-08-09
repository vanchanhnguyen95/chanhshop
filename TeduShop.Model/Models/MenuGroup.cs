using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("MenuGroups")]
    public class MenuGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//Cài cái id sẽ tự tăng
        public int ID { set; get; }

        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        //Cách chỉ khóa ngoại của Menu, từ bảng con trỏ đến và MenuGroup
        public virtual IEnumerable<Menu> Menus { set; get; }
    }
}
