using FacturaProject.Context;
using FacturaProject.DataAcces.Abstract;
using FacturaProject.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacturaProject.DataAcces.Concrete
{
    public class HeaderEfDal : IHeaderDal
    {
        public FakturaHeader Insert(FakturaHeader fakturaHeader)
        {
            using (SqlContext context = new SqlContext())
            {
                var insertEntity = context.Entry(fakturaHeader);
                insertEntity.State = EntityState.Added;
                context.SaveChanges();
            }
            return fakturaHeader;
        }
    }
}
