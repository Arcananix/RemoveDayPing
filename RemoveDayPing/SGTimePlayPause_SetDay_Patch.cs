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
    [HarmonyPatch(typeof(SGTimePlayPause), "SetDay")]
    public static class SGTimePlayPause_SetDay_Patch
    {
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions, ILGenerator iL)
        {
            var codes = new List<CodeInstruction>(instructions);

            int startIndex = -1;
            int endIndex = -1;
            bool foundCheck = false;
            bool foundPing = false;

            for (int i = 0; i < codes.Count; i++)
            {
                if (codes[i].opcode == OpCodes.Ldc_I4 && (int)codes[i].operand == 235)
                {
                    foundCheck = true;
                    startIndex = i;
                }

                if (foundCheck && codes[i].opcode == OpCodes.Ldc_I4_0)
                {
                    foundPing = true;
                    endIndex = i;
                }
            }

            if (foundPing)
            {
                codes.RemoveRange(startIndex, endIndex - startIndex);
            }

            return codes.AsEnumerable();
        }
    }

    
}
