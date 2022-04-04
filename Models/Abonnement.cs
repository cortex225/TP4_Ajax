using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP4_Ajax.Models
{
    public class Abonnement
    {
        public int AbonnementId { get; set; }

        public string Type { get; set; }

        public float PrixMensuel { get; set; }

        public int RabaisPourcentage { get; set; }
    }
}
