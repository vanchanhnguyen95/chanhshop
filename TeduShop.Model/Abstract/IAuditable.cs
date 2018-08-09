using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { set; get; }
        string CreatedBy { set; get; }
        DateTime? UpdatedDate { set; get; }
        string UpdatedBy { set; get; }

        //Chuyển từ ISeoable
        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }
        //Chuyển từ ISwitchable
        bool Status { set; get; }
        //
    }
}
