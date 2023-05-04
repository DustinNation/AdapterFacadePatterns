using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Components
{
    public class Projector
    {
        public StreamingPlayer Player { get; set; }

        public void On()
        {
            Console.WriteLine("Projector on");
        }

        public void Off()
        {
            Console.WriteLine("Projector off");
        }

        public void TvMode()
        {
            Console.WriteLine("Projector in standard aspect ratio");
        }

        public void WideScreenMode()
        {
            Console.WriteLine("Projector in widescreen mode (16x9 aspect ratio)");
        }

    }
}
