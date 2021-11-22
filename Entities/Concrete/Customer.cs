using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Customer:IEntity
    {
        public  int Id { get; set; }
        public string ContactName { get; set; }
        public string CampanyName { get; set; }
        public string City { get; set; }
    }
}
