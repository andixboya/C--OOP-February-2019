

namespace CustomAttribute
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]




    public class CustomAttribute : Attribute
    {
        private const string AuthorInfo = "Pesho";
        private const string defaultRevision = "3";
        private const string description = "Used for C# OOP Advanced Course - Enumerations and Attributes.";
        private const string reviewers = "Pesho, Svetlio";

        public CustomAttribute()
        {
            this.Author = AuthorInfo;
            this.Revision = defaultRevision;
            this.Description = description;
            this.Reviewers = reviewers;
        }

        //•	revision = 3
        //•	description = "Used for C# OOP Advanced Course - Enumerations and Attributes."
        //•	reviewers = "Pesho", "Svetlio"


        public string Author { get; set; }

        public string Revision { get; set; }

        public string Description { get; set; }

        public string Reviewers { get; set; }

    }
}
