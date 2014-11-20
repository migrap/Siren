using System;

namespace Siren {
    public partial class Document {        
        public Class Class { get; set; } = new Class();

        public Object Properties { get; set; }

        public Entities Entities { get; set; } = new Entities();

        public Links Links { get; set; } = new Links();

        public Actions Actions { get; set; } = new Actions();

        public Rel Rel { get; set; }

        public Href Href { get; set; }
    }
}