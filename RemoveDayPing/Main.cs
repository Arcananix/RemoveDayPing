using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Harmony;
using System.Reflection;

namespace RemoveDayPing
{
    public class Main
    {
        public static void Init(string directory, string settings)
        {
            HarmonyInstance.Create("Arcananix.RemoveDayPing").PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
