using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCparcial.Models
{
    public enum UnityType
    {
        Litro,
        Caja,
        Botella,
        Kg

    }

    public enum StatusType
    {
        Activo,
        Inactivo

    }

    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string Nombre { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        [Required]

        public UnityType Unit { get; set; }

        public StatusType Status { get; set; }

    }
}