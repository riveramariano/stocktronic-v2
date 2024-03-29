﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stocktronic.Models
{
    public class ConfirmacionJoin
    {
        public long ID_ORDEN { get; set; }
        public DateTime ORD_FEC_ORDEN { get; set; }
        public decimal ORD_MONTO_TOTAL { get; set; }
        public string PAG_NUM_TARJETA { get; set; }
        public string PAG_DIR_FACTURACION { get; set; }
        public string PAG_DIR_FACTURACION2 { get; set; }
        public string METP_NOMBRE { get; set; }
    }
}