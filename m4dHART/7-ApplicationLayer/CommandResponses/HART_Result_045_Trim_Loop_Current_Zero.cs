﻿using m4dHART._2_DataLinkLayer.Wired_Token_Passing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.CommandResponses
{
    public class HART_Result_045_Trim_Loop_Current_Zero : CommandResponse
    {
        public HART_Result_045_Trim_Loop_Current_Zero(HARTDatagram command) : base(command)
        {
        }
        public float ActualMeasuredPVLoopCurrentLevel => new byte[] { Data[0], Data[1], Data[2], Data[3] }.To_HART_Single();
    }
}
