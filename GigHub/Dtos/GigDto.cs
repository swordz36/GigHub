﻿using System;
using System.ComponentModel.DataAnnotations;

namespace GigHub.Dtos
{
    public class GigDto
    {
        public int Id { get; set; }

        public UserDto Artist { get; set; }

        public DateTime DateTime { get; set; }
        public string Venue { get; set; }

        public GenreDto Genre { get; set; }

        [Required]
        public byte GenreId { get; set; }

        public bool IsCanceled { get; set; }
    }
}