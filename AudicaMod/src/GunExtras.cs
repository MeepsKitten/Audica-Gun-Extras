using System;
using System.Collections.Generic;
using MelonLoader;
using UnityEngine;

namespace AudicaModding.GunExtras
{
    public class GunExtras : MelonMod
    {
        public static class BuildInfo
        {
            public const string Name = "Gun Extras";  // Name of the Mod.  (MUST BE SET)
            public const string Author = "MeepsKitten"; // Author of the Mod.  (Set as null if none)
            public const string Company = null; // Company that made the Mod.  (Set as null if none)
            public const string Version = "1.0.2"; // Version of the Mod.  (MUST BE SET)
            public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
        }

        public class GunConfig
        {
            public class types
            {
                //vanilla
                public struct scaleFactor
                {
                    float x;
                    float y;
                    float z;
                }
                public struct orientationOffset
                {
                    float x;
                    float y;
                    float z;
                }
                public struct positionOffset
                {
                    float x;
                    float y;
                    float z;
                }

                //extras
                public class firepoint
                {
                    public float x;
                    public float y;
                    public float z;
                }
            }

            //Default

            public types.scaleFactor scaleFactor;
            public types.orientationOffset orientationOffset;
            public types.positionOffset positionOffset;
            public float shading;
            public float reflection;
            public bool recalculateNormals;

            //Extras

            public types.firepoint firepoint;
        }

        public static GunConfig gunConfig_L;
        public static GunConfig gunConfig_R;
    }
}



