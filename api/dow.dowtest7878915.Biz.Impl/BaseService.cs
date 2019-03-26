using dow.dowtest7878915.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dow.dowtest7878915.Biz.Impl
{
    public abstract class BaseService
    {
        protected IUnitOfWork context;

        public BaseService(IUnitOfWork uow)
        {
            context = uow;
        }
    }

}
