using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TP4_Ajax.Models;

namespace TP4_Ajax.ViewModels
{
    public class ClientCreateVM
    {
        public int ClientId { get; set; }

        [DisplayName("Nom")]
        [Required(ErrorMessage = "Ce champ doit être rempli.")]
        public string Nom { get; set; }

        [DisplayName("Âge")]
        [Required(ErrorMessage = "Ce champ doit être rempli.")]
        [Range(20, 75, ErrorMessage = "Votre  âge doir être compris entre 20 et 75 ans.")]
        public int Age { get; set; }

        [DisplayName("Courriel")]
        [Required(ErrorMessage = "Ce champ doit être rempli.")]
        [EmailAddress(ErrorMessage = "Vous devez rentrer un courriel valide.")]
        public string Courriel { get; set; }

        [DisplayName("Téléphone")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:(###) ###-####}")]
        [StringLength(10)]
        public string NoTelephone { get; set; }

        public void NoTelephoneFormat()
        {
            string.Format("{0:(###) ###-####}", NoTelephone);
        }


        [DisplayName("Type d'abonnement")]
        [Required(ErrorMessage = "Ce champ doit être rempli.")]
        public int AbonnementId { get; set; }
        public List<SelectListItem> ListeAbonnementSelectItems { get; set; }
        public Abonnement Abonnement { get; set; }
    }
}
