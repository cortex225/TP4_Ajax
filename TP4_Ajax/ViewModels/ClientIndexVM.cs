using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TP4_Ajax.Models;

namespace TP4_Ajax.ViewModels
{
    public class ClientIndexVM
    {
        public int ClientId { get; set; }

        [DisplayName("Nom")]
        public string Nom { get; set; }

        [DisplayName("Âge")]
        public int Age { get; set; }

        [DisplayName("Courriel")]
        public string Courriel { get; set; }

        [DisplayName("Téléphone")]
        [DisplayFormat(DataFormatString = "{0:(###) ###-####}")]
        public string NoTelephone { get; set; }

        [DisplayName("Type d'abonnement")]
        public int AbonnementId { get; set; }
        public Abonnement Abonnement { get; set; }
    }
}
