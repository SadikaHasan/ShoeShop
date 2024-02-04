using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore.Models.Requests
{
    public class GetAllShoesByBrandRequest
    {
        public int BrandId { get; set; }

        public DateTime DateAfter { get; set;  }
    }
}
