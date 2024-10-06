using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        //Purpose: Retrieves all records from the data store for the given entity type.
        //Return Type: IEnumerable<T> represents a collection of T entities.
        //Use Case: Useful for returning all rows in a database table, such as getting a list of all products.
        IEnumerable<T> GetAll(string? includeProperties = null);
        //Purpose: Retrieves a single entity from the data store that matches the specified filter condition.
        //Parameter:Expression<Func<T, bool>> filter: Represents a LINQ expression used to filter records, such as product => product.Id == 5.
        //Return Type: T — Returns a single entity that matches the criteria or null if no match is found.
        //Use Case: Fetch a single record based on a specific condition, such as getting a product by ID or by name.
        T Get(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = false);
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
    }
}
