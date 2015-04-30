using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Siren {
    public class Entities : IEnumerable<Entity> {
        private List<Entity> _collection;

        public Entities(IEnumerable<Entity> collection = null) {
            _collection = new List<Entity>(collection ?? Enumerable.Empty<Entity>());
        }

        public Entities Add(params Entity[] collection) {
            _collection.AddRange(collection);
            return this;
        }

        public IEnumerator<Entity> GetEnumerator() {
            return _collection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }
}