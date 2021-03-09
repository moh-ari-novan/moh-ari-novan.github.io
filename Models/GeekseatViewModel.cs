using GeekSeat.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekSeat.Models
{
    public class GeekseatViewModel
    {
        public Person FirstPerson { get; set; }
        public Person SecondPerson { get; set; }
        public decimal AverageDeath { get; set; }
    }
}
