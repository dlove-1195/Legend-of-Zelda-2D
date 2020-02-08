using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public interface IController
    {
        Game1 Game { get; set; }
        void Update();
    }
}
