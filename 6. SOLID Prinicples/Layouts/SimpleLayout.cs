


using LoggerT.Layouts.Contracts;

namespace LoggerT.Layouts
{

    public class SimpleLayout : ILayout
    {

        private const string defaultFormat = "{0} - {1} - {2}";


        public SimpleLayout()
        {
            this.Format = defaultFormat;
        }


        public string Format { get; }
    }
}
