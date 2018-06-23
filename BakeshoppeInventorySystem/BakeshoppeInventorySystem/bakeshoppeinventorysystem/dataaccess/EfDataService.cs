using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BakeshoppeInventorySystem.DataAccess
{
    public interface IDataService<T> where T : class
    {
        void Add(T record);
        void AddRange(List<T> records);
        void Remove(T record);
        void RemoveRange(List<T> records);
        void Update(T record);
        void UpdateRange(List<T> records);
        T Get(Expression<Func<T, bool>> condition); // a class with a condition? di ko sure.
        List<T> GetRange(Expression<Func<T, bool>> condition);
        List<T> GetRange();
    }
    public class EfDataService<T> : IDataService<T> where T : class, new()
    {
        public void Add(T record)
        {
            using (var context = new BakeshoppeInventorySystem())
            {
                context.Entry(record).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void AddRange(List<T> records)
        {
            using (var context = new BakeshoppeInventorySystem())
            {
                foreach (var record in records)
                {
                    context.Entry(record).State = EntityState.Added;
                }
                context.SaveChanges();
            }
        }

        public void Remove(T record)
        {
            using (var context = new BakeshoppeInventorySystem())
            {
                context.Entry(record).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void RemoveRange(List<T> records)
        {
            using (var context = new BakeshoppeInventorySystem())
            {
                foreach (var record in records)
                {
                    context.Entry(record).State = EntityState.Deleted;
                }
                context.SaveChanges();
            }
        }

        public void Update(T record)
        {
            using (var context = new BakeshoppeInventorySystem())
            {
                context.Entry(record).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void UpdateRange(List<T> records)
        {
            using (var context = new BakeshoppeInventorySystem())
            {
                foreach (var record in records)
                {
                    context.Entry(record).State = EntityState.Modified;
                }
                context.SaveChanges();
            }
        }

        public T Get(Expression<Func<T, bool>> condition)
        {
            using (var context = new BakeshoppeInventorySystem())
            {
                var record = context.Set<T>().FirstOrDefault(condition);
                return record;
            }
        }

        public List<T> GetRange(Expression<Func<T, bool>> condition)
        {
            using (var context = new BakeshoppeInventorySystem())
            {
                var records = context.Set<T>().Where(condition).ToList();
                return records;
            }
        }

        public List<T> GetRange()
        {
            using (var context = new BakeshoppeInventorySystem())
            {
                var records = context.Set<T>().ToList();
                return records;
            }
        }
    }
}
