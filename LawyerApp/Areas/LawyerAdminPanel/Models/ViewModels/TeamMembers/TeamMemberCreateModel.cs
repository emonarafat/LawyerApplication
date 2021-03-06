﻿using System.ComponentModel.DataAnnotations;

namespace LawyerApp.Areas.LawyerAdminPanel.Models
{
    public class TeamMemberCreateModel
    {
        [Required]
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Surname { get; set; }
        [Required]
        [StringLength(maximumLength:2000)]
        public string Description { get; set; }
        public int LanguageId { get; set; }
    }

}
