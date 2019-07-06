namespace CollectionHierarchy.Contracts
{
    using System;

    public interface IAddRemoveCollection : IAddCollection
    {

        string RemoveElement();

    }
}
