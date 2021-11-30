using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IOrderService
    {
        IDataResult<List<Order>> GetAll();
        IDataResult<Order> GetAllByOrderId(int Id); 
        IResult Add(Order order);
        IResult Delete(Order order);
        IResult Update(Order order);
    }
}
