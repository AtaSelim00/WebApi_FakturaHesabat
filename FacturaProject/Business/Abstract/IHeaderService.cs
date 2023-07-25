using FacturaProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacturaProject.Business.Abstract
{
    public interface IHeaderService
    {
        FakturaHeader Insert(FakturaHeader fakturaHeader );
    }
}
