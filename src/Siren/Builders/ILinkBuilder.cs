
namespace Siren.Builders {
    public interface ILinkBuilder : IFluent {
        ILinkBuilder Rel(Rel value);
        ILinkBuilder Href(Href value);
    }
}

