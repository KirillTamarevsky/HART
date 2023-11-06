using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.CommonTables
{
    public enum _003_Transfer_Function_Code
    {
        Linear = 0,
        SquareRoot = 1,
        SqRootThirdPower = 2,
        SqRootFifthPower = 3,
        SpecCurve_DoNotUse = 4,
        Square = 5,
        SquareRootWithCutOff = 6,
        
        EqualPercentage_1_25 = 10,
        EqualPercentage_1_33 = 11,
        EqualPercentage_1_50 = 12,
        
        QuickOpen_1_25 = 15,
        QuickOpen_1_33 = 16,
        QuickOpen_1_50 = 17,

        HyperbolicShapeFactor_0_10 = 30,
        HyperbolicShapeFactor_0_20 = 31,
        HyperbolicShapeFactor_0_30 = 32,
        HyperbolicShapeFactor_0_50 = 34,
        HyperbolicShapeFactor_0_70 = 37,

        HyperbolicShapeFactor_1_00 = 40,
        HyperbolicShapeFactor_1_50 = 41,
        HyperbolicShapeFactor_2_00 = 42,
        HyperbolicShapeFactor_3_00 = 43,
        HyperbolicShapeFactor_4_00 = 44,
        HyperbolicShapeFactor_5_00 = 45,

        FlatBottomTank = 100,
        ConicalOrPyramidBottomTank = 101,
        ParabolicBottomTank = 102,
        SphericalBottomTank = 103,
        AngledBottomTank = 104,
        FlatEndCylinderTank = 105,
        ParabolicEndCylinderTank = 106,
        SphericalTank = 107,

        ManufSpecific_210 = 210, 
        ManufSpecific_211 = 211, 
        ManufSpecific_212 = 212, 
        ManufSpecific_213 = 213, 
        ManufSpecific_214 = 214, 
        ManufSpecific_215 = 215, 
        ManufSpecific_216 = 216, 
        ManufSpecific_217 = 217, 
        ManufSpecific_218 = 218, 
        ManufSpecific_219 = 219, 
        ManufSpecific_220 = 220,
        ManufSpecific_221 = 221,
        ManufSpecific_222 = 222,
        ManufSpecific_223 = 223,
        ManufSpecific_224 = 224,
        ManufSpecific_225 = 225,
        ManufSpecific_226 = 226,
        ManufSpecific_227 = 227,
        ManufSpecific_228 = 228,
        ManufSpecific_229 = 229,

        Discrete_Switch = 230,

        SquareRootPlusSpecialCurve_DoNotUse = 231,
        SquareRootThirdPowerPlusSpecialCurve_DoNotUse = 232,
        SquareRootFifthPowerPlusSpecialCurve_DoNotUse = 233,

        ManufSpecific_234 = 234,
        ManufSpecific_235 = 235,
        ManufSpecific_236 = 236,
        ManufSpecific_237 = 237,
        ManufSpecific_238 = 238,
        ManufSpecific_239 = 239,
        ManufSpecific_240 = 240,
        ManufSpecific_241 = 241,
        ManufSpecific_242 = 242,
        ManufSpecific_243 = 243,
        ManufSpecific_244 = 244,
        ManufSpecific_245 = 245,
        ManufSpecific_246 = 246,
        ManufSpecific_247 = 247,
        ManufSpecific_248 = 248,
        ManufSpecific_249 = 249,

        NotUsed = 250,
        None = 251,
        Unknown = 252,
        Special = 253
    }
}
