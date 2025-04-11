using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_Stone_Evan
{
     class Car
    {
        //sets up the properties for model and make
        private string model;

        public string Model { get { return model; } set { model = value; } }

        public string Make { get; set; }

    }
}
