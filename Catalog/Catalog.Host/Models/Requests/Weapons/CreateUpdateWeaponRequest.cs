﻿using System.ComponentModel.DataAnnotations;

namespace Catalog.Host.Models.Requests.Weapons
{
    public class CreateUpdateWeaponRequest
    {
        [Required]
        [StringLength(10, ErrorMessage = "{0} Rarity must be less then 10", MinimumLength = 3)]
        public string Weapon { get; set; } = null!;
    }
}
