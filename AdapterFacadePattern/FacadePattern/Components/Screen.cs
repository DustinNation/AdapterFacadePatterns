using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Components
{
    public class Screen
    {
        public void Up()
        {
            Console.WriteLine("Theater screen going up");
        }

        public void Down()
        {
            Console.WriteLine("Theater screen going down");
        }
    }
}
