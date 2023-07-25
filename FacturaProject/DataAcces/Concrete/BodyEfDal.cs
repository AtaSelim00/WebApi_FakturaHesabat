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
    public class BodyEfDal : IBodyDal
    {
        public FakturaBody Insert(FakturaBody fakturaBody)
        {
            using (SqlContext context = new SqlContext())
            {
                var insertEntity = context.Entry(fakturaBody);
                insertEntity.State = EntityState.Added;
                context.SaveChanges();
            }
            return fakturaBody;
        }
    }
}
