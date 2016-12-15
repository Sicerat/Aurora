using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
//using System.Runtime.Serialization.Json;
using System.Text;

/* namespace Assets.Scripts
{
    public class New_Serializer
    {
        public static MemoryStream Serialize()
        {
            MemoryStream ms = new MemoryStream();

            for (int i = 1; i < 11; i++)
            {
                New_Generator g = new New_Generator();
                New_LevelAdder la = new New_LevelAdder(i, g.StringMatrixGenerator(6));

                DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(New_LevelAdder));
                js.WriteObject(ms, la);
            }

            ms.Position = 0;

            return ms;
        }
    }
}
*/