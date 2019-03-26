using dow.dowtest7878915.Biz.Interface;
using dow.dowtest7878915.Biz.Interface.Model;
using dow.dowtest7878915.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace dow.dowtest7878915.Service.Controllers
{
    [Authorize]
    [RoutePrefix("api/order")]
    public class OrderController : ApiController
    {
        private IOrderService orderServie;

        public OrderController(IOrderService service)
        {
            this.orderServie = service;
        }
        
        public List<OrderVM> Get()
        {
            var orders = orderServie.GetAllOrders();
            return orders;
        }
        
        public OrderVM Get(int id)
        {
            var order = orderServie.GetOrderById(id);
            return order;
        }

        public void Post(OrderVM ordervm)
        {
            orderServie.UpdateOrder(ordervm);
        }


    }
}
