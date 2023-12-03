using BepInEx;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MenuMute
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        Plugin()
        {
            HarmonyPatches.ApplyHarmonyPatches();
        }
    }
}
