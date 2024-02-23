﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Test_Aiko.Models
{
    public class VehiclePosition
    {
        [Key]
        [DisplayName("Id")]
        public long Id { get; set; }

        [Required(ErrorMessage = "A latitude é obrigatória.")]
        [Range(-90, 90, ErrorMessage = "A latitude deve estar entre -90 e 90.")]
        [DisplayName("Latitude")]
        public double Latitude { get; set; }

        [Required(ErrorMessage = "A longitude é obrigatória.")]
        [Range(-180, 180, ErrorMessage = "A longitude deve estar entre -180 e 180.")]
        [DisplayName("Longitude")]
        public double Longitude { get; set; }

        [Required(ErrorMessage = "O ID do veículo é obrigatório.")]
        [DisplayName("Id do Veículo")]
        public long VehicleId { get; set; }
    }
}
