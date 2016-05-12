using System.Web.Mvc;

namespace AdventuresInTDD_Part2.Models
{
    public class ConversionModel
    {
        //inputs for submission
        public string InputValue { get; set; }
        public string SelectedConversionOptionFrom { get; set; }
        public string SelectedConversionOptionTo { get; set; }

        //input for preparing view
        public string[] ConversionOptionsFrom { get; set; }
        public string[] ConversionOptionsTo { get; set; }
    }
}