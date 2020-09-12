namespace Naif.Core.DateTime
{
    public enum DateType
    {
        Exact = 1,      // Exact Date - Day, Month, Year,
        About = 2,      // About Date
        Estimated = 3,  // Estimated Date
        Calculated = 4, // Calculated Date
        From = 5,       // From Date
        To = 6,         // To Date
        FromTo = 7,     // From Date1 to Date2
        Before = 8,     // Before Date
        After = 9,      // After Date
        Between = 10,    // Between Date1 and Date2
    }
}
