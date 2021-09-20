using System;
using System.Collections.Generic;
using System.Text;

namespace Exc3_Enum.Entities {
    class Department {

        public string Name { get; set; }

        public Department() { }

        public Department( string name) {
            Name = name;
        }
    }
}
