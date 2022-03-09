using SallesWebMvc.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SallesWebMvc.Models
{
    public class SallesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Ammount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SallesRecord()
        {

        }

        public SallesRecord(int id, DateTime date, double ammount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Ammount = ammount;
            Status = status;
            Seller = seller;
        }
    }
}
