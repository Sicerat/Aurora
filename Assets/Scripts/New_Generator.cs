using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    public static class New_Generator
    {
        public static string StringMatrixGenerator(int n)
        {
            Random r = new Random();
            StringBuilder sb = new StringBuilder(n * n);

            for (int i = 0; i < n * n; i++)
            {
                sb.Append(r.Next(0, 10));
            }

            var s = sb.ToString();

            return s;
        }
    }
}
