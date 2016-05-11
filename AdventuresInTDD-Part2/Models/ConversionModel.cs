namespace AdventuresInTDD_Part2.Models
{
    public class ConversionModel
    {
        //inputs for submission
        public string InputValue { get; set; }
        public string SelectedConversionOption { get; set; }

        //input for preparing view
        public string[] ConversionOptions { get; set; }
    }
}