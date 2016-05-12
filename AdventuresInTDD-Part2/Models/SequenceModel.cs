namespace AdventuresInTDD_Part2.Models
{
    public class SequenceModel
    {        
        //inputs for submission
        public string InputValue { get; set; }
        public string SelectedSequenceDataType { get; set; }
        public string SelectedSequenceIncrement { get; set; }
        public bool SortAscending { get; set; }
        public bool SortDescending { get; set; }

        //input for preparing view
        public string[] SequenceDataTypes { get; set; }
        public string[] SequenceIncrementOptions { get; set; }
    }
}