//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("MetodoPago")]
    public partial class MetodoPago
    {            
        public int PagoId { get; set; }
        [DisplayName("Metodo de Pago")]
        public string MetodoPago1 { get; set; }
    }
}