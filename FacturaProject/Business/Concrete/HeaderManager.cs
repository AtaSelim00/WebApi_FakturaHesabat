using FacturaProject.Business.Abstract;
using FacturaProject.DataAcces.Abstract;
using FacturaProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacturaProject.Business.Concrete
{
    public class HeaderManager : IHeaderService
    {
        IHeaderDal _headerDal;

        public HeaderManager(IHeaderDal headerDal)
        {
            _headerDal = headerDal;
        }

        public FakturaHeader Insert(FakturaHeader fakturaHeader)
        {
           return _headerDal.Insert(fakturaHeader);
        }

        
    }
}
