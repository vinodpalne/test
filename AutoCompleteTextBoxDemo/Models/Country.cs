using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace AutoCompleteTextBoxDemo.Models
{
    [Table("Country")]
    public class Country
    {
        public Int64 ID { get; set; }
        public string CountryName { get; set; }
    }
}