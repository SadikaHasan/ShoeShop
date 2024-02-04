using ShoeStore.Models.Requests;
using ShoeStore.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore.BL.Interfaces
{
    public interface ILibraryService
    {
        GetAllShoesByBrandResponse?
            GetAllByBrandsAfterReleaseDate(
            GetAllShoesByBrandRequest request);

        int CheckShoeCount(int input);
    }
}
