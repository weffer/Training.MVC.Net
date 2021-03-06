﻿namespace CPS.WebApi.Models
{
    public class TechnicalIssue : Issue
    {
        public string ProjectDescription { get; set; }
        public string Module { get; set; }
        public string ServiceName { get; set; }
    }

    public class CommonIssue : Issue
    {
        public string Location { get; set; }
        public string Owner { get; set; }
    }


}