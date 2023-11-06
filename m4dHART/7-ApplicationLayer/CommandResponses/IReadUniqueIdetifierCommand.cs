using m4dHART._2_DataLinkLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.CommandResponses
{
    public interface IReadUniqueIdetifierCommand
    {
        LongAddress LongAddress { get; }
    }
}
