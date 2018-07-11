using System;
using System.ComponentModel.DataAnnotations;

namespace ModelBindFaultSample.Models
{
    public class Bird
    {
        [Key]
        public int BirdId { get; set; }

        public string EnglishName { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
