using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleTech;
using BattleTech.UI;
using Harmony;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using UnityEngine;

namespace RemoveDayPing
{
    //[HarmonyPatch(typeof(SGTimePlayPause), "SetTimeMoving")]
    //public static class SGTimePlayPause_SetTimeMoving_Patch
    //{
    //    public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions, ILGenerator iL)
    //    {
    //        var codes = new List<CodeInstruction>(instructions);


    //        int startIndex1 = -1;
    //        int endIndex1 = -1;
    //        int found_Ldarg0Count = 0;
    //        bool foundCheck1 = false;
    //        bool foundSound1 = false;

    //        Label jumpToPoint = iL.DefineLabel();

    //        for (int i = 0; i < codes.Count; i++)
    //        {
    //            if (codes[i].opcode == OpCodes.Ldc_I4 && (int)codes[i].operand == 419)
    //            {
    //                foundCheck1 = true;
    //                startIndex1 = i;
    //            }

    //            if (foundCheck1 && codes[i].opcode == OpCodes.Ldarg_0)
    //            {
    //                found_Ldarg0Count++;
    //                if (found_Ldarg0Count > 1)
    //                {
    //                    foundSound1 = true;
    //                    endIndex1 = i - 1;
    //                    codes[i].labels.Add(jumpToPoint);
    //                    break;
    //                }
    //            }

    //        }

    //        if (foundSound1)
    //        {
    //            //codes.RemoveRange(startIndex1, endIndex1 - startIndex1);
    //            //for(int i = startIndex1; i<= endIndex1; i++)
    //            //{
    //            //    codes[i].opcode = OpCodes.Nop;
    //            //}
    //            codes.Insert(startIndex1, new CodeInstruction(OpCodes.Br, jumpToPoint));
    //        }
           
    //        return codes.AsEnumerable();
    //    }
    //}
}
