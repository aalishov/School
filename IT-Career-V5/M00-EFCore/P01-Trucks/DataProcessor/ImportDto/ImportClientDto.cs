﻿namespace Trucks.DataProcessor.ImportDto
{
    using System.ComponentModel.DataAnnotations;

    public class ImportClientDto
    {
        [Required]
        [MinLength(3)]
        [MaxLength(40)]

        public string Name { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(40)]
        public string Nationality { get; set; }

        [Required]
        public string Type { get; set; }

        public int[] Trucks { get; set; }
    }
}
