using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Assets.Scripts
{
    [DataContract]
    public class New_LevelAdder
    {
        [DataMember]
        public int Number { get; set; }

        [DataMember]
        public string Matrix { get; set; }

        public New_LevelAdder(int number, string matrix)
        {
            Number = number;
            Matrix = matrix;
        }
    }
}
