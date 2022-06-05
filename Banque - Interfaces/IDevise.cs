using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    internal interface IDevise
    {
        Devise convert_to(string symbole);
    }
}
