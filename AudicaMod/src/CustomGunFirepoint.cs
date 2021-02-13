using System;
using System.Collections.Generic;
using MelonLoader;
using UnityEngine;
using Harmony;
using Newtonsoft.Json;
using System.IO;

namespace AudicaModding.GunExtras.CustomGunFirepoint
{
    public class CustomGunFirepoint
    {
        private static GunExtras.GunConfig LoadConfig(string filename)
        {
            if (File.Exists(filename))
            {
                GunExtras.GunConfig hand = JsonConvert.DeserializeObject<GunExtras.GunConfig>(File.ReadAllText(filename));
                return hand;

            }
            else
            {
                MelonLogger.LogWarning("No gun config found for: " + filename);
                return null;
            }
        }

        private static void SetFirepoint(GunExtras.GunConfig handConfig, Target.TargetHandType hand)
        {
            Gun desiredGun = KataConfig.I.GetGun(hand);

            if (desiredGun == null)
            {
                MelonLogger.LogError("Can not find gun");
                return;
            }

            if (handConfig != null && handConfig.firepoint != null)
            {
                desiredGun.firepoint.localPosition = new Vector3(handConfig.firepoint.x, handConfig.firepoint.y, handConfig.firepoint.z);

            }
            else
            {
                desiredGun.firepoint = desiredGun.firepointDefaultPosition;
            }
        }


        [HarmonyPatch(typeof(CustomModelLoader), "UpdateCustomGun", new Type[] { typeof(CustomModelLoader.CustomModelType), typeof(Gun) })]
        private static class OnNewGunLoaded
        {
            private static void Postfix(CustomModelLoader __instance)
            {
                GunExtras.gunConfig_L = null;
                GunExtras.gunConfig_R = null;

                string file_l = __instance.GetConfigFilename(CustomModelLoader.CustomModelType.GunLeft);
                string file_r = __instance.GetConfigFilename(CustomModelLoader.CustomModelType.GunRight);
                GunExtras.gunConfig_L = LoadConfig(file_l);
                GunExtras.gunConfig_R = LoadConfig(file_r);

                SetFirepoint(GunExtras.gunConfig_L, Target.TargetHandType.Left);

                SetFirepoint(GunExtras.gunConfig_R, Target.TargetHandType.Right);
            }


        }
    }
}
