using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Order:IEntity
    {
        public int  Id { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }

        public int ShipCityId { get; set; }


    } 
}
