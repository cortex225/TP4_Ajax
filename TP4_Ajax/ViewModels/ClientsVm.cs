using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using TP4_Ajax.Models;

namespace TP4_Ajax.ViewModels
{
    public class ClientsVm
    {
        public int ClientId { get; set; }

        [DisplayName("Nom")]
        public string Nom { get; set; }

        public int Age { get; set; }

        public string Courriel { get; set; }

        public string NoTelephone { get; set; }

        public int AbonnementId { get; set; }
        public Abonnement Abonnement { get; set; }
    }
}
