using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    public enum Status
    {
        current,
        missed,
        finished
    }
    public class Call
    {
        private DateTime callTime { get; set; }
        private Status status { get; set; }

        public Call(DateTime callTime, Status status)
        {
            this.callTime = callTime;
            this.status = status;
        }
    }
}
