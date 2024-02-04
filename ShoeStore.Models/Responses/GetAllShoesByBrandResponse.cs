using ShoeStore.Models.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore.Models.Responses
{
    public class GetAllShoesByBrandResponse
    {
        public Brand Brand { get; set; }

        public List<Shoe> Shoe { get; set; }
    }
}
