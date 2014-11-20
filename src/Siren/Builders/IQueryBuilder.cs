
namespace Siren.Builders {
    public interface IQueryBuilder : IFluent {
        IQueryBuilder Href(Href value);
        IQueryBuilder Rel(Rel value);
        IQueryBuilder Prompt(string value);
    }
}