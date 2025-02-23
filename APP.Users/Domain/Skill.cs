﻿using CORE.APP.Domain;
using System.ComponentModel.DataAnnotations;

namespace APP.Users.Domain
{
    public class Skill : Entity
    {
        [Required, StringLength(125)]
        public string Name { get; set; }

    }
}