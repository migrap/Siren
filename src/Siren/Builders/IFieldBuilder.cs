
namespace Siren.Builders {
	public interface IFieldBuilder : IFluent {
        IFieldBuilder Name(string value);
        IFieldBuilder Type(string value);
        IFieldBuilder Value(object value);
	}
}

