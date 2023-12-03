using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine.SceneManagement;
using UnityEngine;

namespace MenuMute.Patches
{
    [HarmonyPatch(typeof(MenuManager))]
    [HarmonyPatch("Update", MethodType.Normal)]
    internal class ExamplePatch
    {
        private static void Postfix(MenuManager __instance)
        {
            if (SceneManager.GetActiveScene().name == "MainMenu")
            {
                __instance.gameObject.GetComponent<AudioSource>().clip = null;
                return;
            }
            else
            {
                return;
            }
        }
    }
}
