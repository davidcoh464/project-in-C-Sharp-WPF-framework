﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
   public class LineStation
    {
        public int BusStationKey { get; set; }
        public int LineID { get; set; }
        public int LineStationIndex { get; set; }
        public override string ToString() => this.ToStringProperty();
    }
}
