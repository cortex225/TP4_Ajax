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

        [DisplayName("Âge")]
        public int Age { get; set; }

        [DisplayName("Courriel")]
        public string Courriel { get; set; }

        [DisplayName("Téléphone")]
        public string NoTelephone { get; set; }

        [DisplayName("Type d'abonnement")]
        public int AbonnementId { get; set; }
        public Abonnement Abonnement { get; set; }
    }
}
