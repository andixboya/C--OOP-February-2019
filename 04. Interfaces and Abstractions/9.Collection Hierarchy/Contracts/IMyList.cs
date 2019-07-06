namespace CollectionHierarchy.Contracts
{
    using System;
    using System.Collections.Generic;

    public interface IMyList
    {

       IReadOnlyCollection<string> Used { get;  }
        

    }
}
