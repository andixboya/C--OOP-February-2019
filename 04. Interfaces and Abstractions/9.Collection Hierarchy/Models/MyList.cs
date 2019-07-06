namespace CollectionHierarchy.Models
{
    using CollectionHierarchy.Contracts;
    using System;
    using System.Collections.Generic;

    public class MyList : AddRemoveCollection, IMyList
    {



        public IReadOnlyCollection<string> Used { get; }

        public override string RemoveElement()
        {
            string dataToReturn = Data[0];
            base.Data.RemoveAt(0);
            return dataToReturn;

        }
    }
}
