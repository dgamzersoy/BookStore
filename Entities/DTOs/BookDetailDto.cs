using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
   public class BookDetailDto:IDto
    {
        public  int Id { get; set; }
        public string BookName { get; set; }
        public string CategoryName { get; set; }

        public int UnitsInStock { get; set; }

        public decimal UnitPrice { get; set; }
    }
}
