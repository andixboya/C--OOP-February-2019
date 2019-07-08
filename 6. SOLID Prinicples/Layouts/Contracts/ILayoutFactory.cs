

namespace LoggerT.Layouts.Contracts
{
    public interface ILayoutFactory
    {
        ILayout GenerateLayout(string type);
    }
}
