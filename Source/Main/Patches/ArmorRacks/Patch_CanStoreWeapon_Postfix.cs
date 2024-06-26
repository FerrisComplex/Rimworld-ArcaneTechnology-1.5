﻿using ArmorRacks.Things;
using HarmonyLib;
using Verse;

namespace DArcaneTechnology.ArmorRackPatches
{
    internal class Patch_CanStoreWeapon_Postfix
    {
        private static void Postfix(Thing weapon, ref bool __result)
        {
            if (__result) __result = __result && !Base.IsResearchLocked(weapon.def);
        }
    }
}
