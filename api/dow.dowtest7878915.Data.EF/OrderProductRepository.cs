using System;
using System.Linq;
using System.Collections.Generic;
using dow.dowtest7878915.Data.Interface;

namespace dow.dowtest7878915.Data.EF
{  
	public  class OrderProductRepository : Repository<OrderProduct>, IOrderProductRepository
	{
		public OrderProductRepository(IUnitOfWork uow) : base(uow)
		{
		}

	}
}


