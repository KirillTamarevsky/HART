using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.CommonTables
{
    public enum _021_Device_Variable_Classification_Code
    {
        Device_Variable_Not_Classified = 0,

        Temperature = 64,
        Pressure = 65,
        Volumetric_Flow = 66,
        Velocity = 67,
        Volume = 68,
        Length = 69,
        Time = 70,
        Mass = 71,
        Mass_Flow = 72,
        Mass_Per_Volume = 73,
        Viscosity = 74,
        Angular_Velocity = 75,
        Area = 76,
        Energy_Work = 77,
        Force = 78,
        Power = 79,
        Frequency = 80,
        Analytical = 81,
        Capacitance = 82,
        Electromotive_Force_Electric_Potential = 83,
        Current = 84,
        Resistance = 85,
        Conductance = 87,
        Volume_Per_Volume = 88,
        Volume_Per_Mass = 89,
        Concentration = 90,

        Acceleration = 96,
        Turbidity = 97,
        Temperature_Difference = 98,
        Volumetric_Gas_Flow_per_Second = 99,
        Volumetric_Gas_Flow_per_Minute = 100,
        Volumetric_Gas_Flow_per_Hour = 101,
        Volumetric_Gas_Flow_per_Day = 102,

        Volumetric_Liquid_Flow_per_Second = 103,
        Volumetric_Liquid_Flow_per_Minute = 104,
        Volumetric_Liquid_Flow_per_Hour = 105,
        Volumetric_Liquid_Flow_per_Day = 106,

        Thermal_Expansion = 107,
        Volumetric_Energy_Density = 108,
        Mass_Energy_Density = 109,
        Torque = 110,
        Miscellaneous = 111,
        Torsion_Stiffness = 112,
        Linear_Stiffness = 113
    }
}
