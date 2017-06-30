using Pilcrow.Db.Models;
using System;

namespace Pilcrow.Db.Repositories.Results
{
    public class UpdateResult<TModel>: OperationResult<TModel>, IUpdateResult<TModel>
        where TModel : class, IEntity
    {
        public UpdateResult() : base(null)
        {}
        
        public UpdateResult(Exception exception) : base(exception)
        {}
    }
}
