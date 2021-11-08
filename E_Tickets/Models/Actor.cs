﻿using E_Tickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace E_Tickets.Models
{
    public class Actor: IEntityBase
    {
        [key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50, MinimumLength =3 , ErrorMessage ="Full Name must be between 3 and 50 chars ")]
        public string  FullName { get; set; }

        [Display(Name = "Bio")]
        [Required(ErrorMessage = "Biography is required")]

        public string Bio { get; set; }
        //Relationship
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
