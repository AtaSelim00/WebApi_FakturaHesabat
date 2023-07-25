using FacturaProject.Business.Abstract;
using FacturaProject.DataAcces.Abstract;
using FacturaProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacturaProject.Business.Concrete
{
    public class BodyManager : IBodyService
    {

        IBodyDal _bodyDal;

        public BodyManager(IBodyDal bodyDal)
        {
            _bodyDal = bodyDal;
        }

        public FakturaBody Insert(FakturaBody fakturaBody)
        {
            return _bodyDal.Insert(fakturaBody);
        }
    }
}
