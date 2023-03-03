using System.ComponentModel.DataAnnotations;

namespace TipCalculator.Models
{
    public class TipsCalculator
    {
        [Required(ErrorMessage ="Error, invalid input")]
        [Range(0, 10000, ErrorMessage ="Error, the item cost should be in the range of 0 to 10,000")]
        public double? ItemCost { get; set; }
        public double CalculateTip(double percent)
        {
            if (ItemCost.HasValue)
            {
                var tip = percent * ItemCost.Value;
                return tip;
            }
            return 0.0;
        }
    }
}
