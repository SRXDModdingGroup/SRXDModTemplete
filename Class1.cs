using BepInEx;
using BepInEx.IL2CPP;
using UnityEngine;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRXDModTemplete
{
    [BepInPlugin("Example", "Example", "1.0.0")]
    public class Class1 : BasePlugin
    {
        public static BepInEx.Logging.ManualLogSource Logger;
        public override void Load()
        {
            Logger = Log;
            Harmony.CreateAndPatchAll(typeof(Class1));
        } 

        [HarmonyPatch(typeof(GameObject), nameof(GameObject.Find)), HarmonyPostfix]
        static void find_postfix(int __0)
        {
            Logger.LogMessage($"You can get parameters like this! {__0}");
        }

        [HarmonyPatch(typeof(GameStateManager), nameof(GameStateManager.Awake)), HarmonyPostfix]
        [HarmonyPatch(typeof(GameStateManager), nameof(GameStateManager.Update))]
        static void gamestatemanager_postfix()
        {
            Logger.LogMessage("Updated");
        }
    }
}
