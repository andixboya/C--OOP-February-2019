namespace CollectionHierarchy.Models
{
    using CollectionHierarchy.Contracts;
    using System;
    using System.Collections.Generic;

    public class AddCollection : IAddCollection
    {

        protected List<string> Data { get; set; } // does it have to be protected ? 

        public AddCollection()
        {
            this.Data = new List<string> { };
        }

        public virtual int AddItem(string item)
        {
            this.Data.Add(item); //
            return Data.Count - 1; // gives us the element returned
        }
    }
}
