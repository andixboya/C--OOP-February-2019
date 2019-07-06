namespace CollectionHierarchy.Models
{
    using CollectionHierarchy.Contracts;
    using System;
    using System.Linq;

    public class AddRemoveCollection : AddCollection, IAddRemoveCollection
    {



        public virtual string RemoveElement()
        {
            string resultToBeRemoved = Data[Data.Count - 1];
            this.Data.RemoveAt(Data.Count - 1);
            return resultToBeRemoved;
        }

        public override int AddItem(string item)
        {
            this.Data.Insert(0, item);
            return 0;
        }
    }
}
