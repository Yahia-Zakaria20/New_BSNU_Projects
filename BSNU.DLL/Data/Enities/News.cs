using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSNU.DLL.Data.Enities
{
    public class News : BaseEntite
    {
        public string Title { get; set; } 
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public string Type { get; set; }
    }
}
