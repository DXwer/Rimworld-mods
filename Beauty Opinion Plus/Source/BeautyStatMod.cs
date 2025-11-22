using RimWorld;
using Verse;
using HarmonyLib;
using UnityEngine;
using System;
using System.Collections.Generic;
using Verse.Noise;

namespace BeautyOpinionMod
{
    [StaticConstructorOnStartup]
    public static class BeautyOpinionMods
    {
        
        static BeautyOpinionMods()
        {
            var harmony = new Harmony("beautyopinionmod.caravan.patch");
            harmony.PatchAll();

            
        }

    }

}
