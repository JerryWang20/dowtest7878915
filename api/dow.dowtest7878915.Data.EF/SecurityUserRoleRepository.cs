using System;
using System.Linq;
using System.Collections.Generic;
using dow.dowtest7878915.Data.Interface;

namespace dow.dowtest7878915.Data.EF
{  
	public  class SecurityUserRoleRepository : Repository<SecurityUserRole>, ISecurityUserRoleRepository
	{
		public SecurityUserRoleRepository(IUnitOfWork uow) : base(uow)
		{
		}
	}
}


