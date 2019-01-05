using BepInEx;
using Harmony;

namespace OniBoku_Demosaic
{
    [BepInPlugin("OniBoku_Demosaic", "OniBoku Demosaic", "1.0")]
    public class OniBoku_Demosaic : BaseUnityPlugin
    {
        private void Start()
        {
            HarmonyInstance.Create("OniBoku_Demosaic").PatchAll(typeof(OniBoku_Demosaic));
        }
        
        [HarmonyPatch(typeof(ChangeMozaicSize), "Start")]
        [HarmonyPrefix]
        public static bool MosaicDisable(ChangeMozaicSize __instance)
        {
            __instance.MozNum = 0;
            __instance.enabled = false;
            return false;
        }
    }
}
