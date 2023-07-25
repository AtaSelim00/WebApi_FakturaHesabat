using FacturaProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacturaProject.DataAcces.Abstract
{
    public interface IHeaderDal
    {
        FakturaHeader Insert(FakturaHeader fakturaHeader);
    }
}
