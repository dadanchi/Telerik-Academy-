namespace SmapleProject.Models
{
    /// <summary>
    /// This is a sample class for the sandcastle functionality
    /// </summary>
    public class SampleClass
    {
        private string sampleText;

        /// <summary>
        /// Simple constructor for the example
        /// </summary>
        /// <param name="sampleText">Random string to work with in the class</param>
        public SampleClass(string sampleText)
        {
            this.SampleText = sampleText;
        }

        /// <summary>
        /// A property for the sample string that is given in the constructor
        /// </summary>
        public string SampleText
        {
            get
            {
                return this.sampleText;
            }

            set
            {
                this.sampleText = value;
            }
        }

        /// <summary>
        /// A method to test the functionality of sandcastle
        /// </summary>
        public void DoSomeSampleStuff()
        {
            this.sampleText += this.sampleText;
        }
    }
}
