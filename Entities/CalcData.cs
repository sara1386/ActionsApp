using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class CalcData
    {
        [Required]
        public string Operator { get; set; }
        [Required]
        public int value1 { get; set; }
        [Required]
        public int value2 { get; set; }


    }
}