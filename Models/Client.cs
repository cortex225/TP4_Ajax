using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP4_Ajax.Models
{
    public class Client
    {
        public int ClientId { get; set; }

        public string Nom { get; set; }

        public int Age { get; set; }

        public string Courriel { get; set; }
        
        public string NoTelephone { get; set; }


        public int AbonnementId { get; set; }
        public Abonnement Abonnement { get; set; }
        
    }
}
