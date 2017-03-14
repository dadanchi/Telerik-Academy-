namespace Events.Models
{
    using System;
    using System.Text;

    public class Event : IComparable
    {
        private DateTime date;
        private string title;
        private string location;

        public Event(DateTime date, string title, string location)
        {
            this.date = date;
            this.title = title;
            this.location = location;
        }

        public int CompareTo(object obj)
        {
            Event other = obj as Event;
            int comparedDate = this.date.CompareTo(other.date);
            int comparedTitle = this.title.CompareTo(other.title);
            int comparedLocation = this.location.CompareTo(other.location);

            if (comparedDate == 0)
            {
                if (comparedTitle == 0)
                {
                    return comparedLocation;
                }
                else
                {
                    return comparedTitle;
                }
            }
            else
            {
                return comparedDate;
            }
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();

            toString.Append(this.date.ToString("yyyy-MM-ddTHH:mm:ss"));
            toString.Append(" | " + this.title);

            if (this.location != null && this.location != string.Empty)
            {
                toString.Append(" | " + this.location);
            }

            return toString.ToString();
        }
    }
}
