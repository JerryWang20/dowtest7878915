using dow.dowtest7878915.Biz.Interface.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dow.dowtest7878915.Biz.Interface
{
    public interface IOrderService
    {
        List<OrderVM> GetAllOrders();

        OrderVM GetOrderById(int orderId);

        void UpdateOrder(OrderVM ordervm);
    }
}
