using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public IResult Add(Order order)
        {
            return new SuccessResult(Messages.OrderAdded);
        }

        public IResult Delete(Order order)
        {
            return new SuccessResult(Messages.OrderDeleted);
        }

        public IDataResult<List<Order>> GetAll()
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll());
        }

        public IDataResult<Order> GetAllByOrderId(int Id)
        {
            return new SuccessDataResult<Order>(_orderDal.Get(o => o.Id == Id));
        }

        public IResult Update(Order order)
        {
            return new SuccessResult(Messages.OrderUpdated);
        }
    }
}
