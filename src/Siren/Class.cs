using System.Collections.Generic;

namespace Siren {
    public class Class : List<string> {
        public static implicit operator Class(string value) {
            return new Class { value };
        }
    }
}
