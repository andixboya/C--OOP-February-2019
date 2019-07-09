namespace _03BarracksFactory.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            var type = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name == unitType);

            IUnit instance =  (IUnit) Activator.CreateInstance(type, null);

            if (instance is null)
            {
                throw new ArgumentException($"{unitType} is not valid!");
            }


            return instance;

        }
    }
}
