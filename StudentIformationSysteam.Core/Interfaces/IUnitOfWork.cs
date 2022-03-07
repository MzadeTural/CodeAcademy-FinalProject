using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudentIformationSysteam.Core.Interfaces
{
    public interface IUnitOfWork<TEntity>
    {
        Task<List<TEntity>> GetAllUsers(Expression<Func<TEntity, bool>> exp = null, params string[] includes);
    }
}
