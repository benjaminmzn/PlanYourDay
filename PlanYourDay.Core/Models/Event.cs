using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanYourDay.Core.Models
{
    internal class Event
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public DateTime fromDateTime { get; set; }
        public DateTime toDateTime { get; set; }
    }
}
