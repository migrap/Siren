
namespace Siren.Builders {
    public interface IEntityBuilder : IFluent {
        IEntityBuilder Class(Class value);
        IEntityBuilder Properties(object value);
        IEntityBuilder Entities(Entities value);
        IEntityBuilder Links(Links value);
        IEntityBuilder Actions(Actions value);
        IEntityBuilder Rel(Rel value);
        IEntityBuilder Href(Href value);
    }
}

