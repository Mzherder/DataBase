using Sports.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Context context = new Context())
            {
                List<Team> list = context.Teams.Where(t => t.Country.StartsWith("S")).ToList();

            }
        }
    }
}
