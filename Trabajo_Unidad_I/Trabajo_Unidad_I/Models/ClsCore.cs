using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trabajo_Unidad_I.Models
{
    public class ClsCore
    {
        public DateTime parallelStart { get; set; }
        public DateTime parallelFinish { get; set; }
        public DateTime singeStart { get; set; }
        public DateTime singeFinish { get; set; }

        public int parallel_execution_time { get; set; }
        public int Singe_execution_time { get; set; }

    }
}