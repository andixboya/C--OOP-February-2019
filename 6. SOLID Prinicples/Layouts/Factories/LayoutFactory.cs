

namespace LoggerT.Layouts.Factories
{
    using LoggerT.Layouts.Contracts;
    using System;

    public class LayoutFactory : ILayoutFactory
    {


        public ILayout GenerateLayout(string type)
        {

            ILayout layout = null;

            switch (type)
            {
                case "SimpleLayout":
                    layout = new SimpleLayout();
                    break;

                case "XmlLayout":
                    layout = new XmlLayout();
                    break;

                default:
                    throw new ArgumentException("No such Layout");
            }

            return layout;
        }
    }
}
