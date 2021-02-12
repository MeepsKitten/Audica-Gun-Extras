using System.Resources;
using System.Reflection;
using System.Runtime.InteropServices;
using MelonLoader;
using AudicaModding.GunExtras;

[assembly: AssemblyTitle(GunExtras.BuildInfo.Name)]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(GunExtras.BuildInfo.Company)]
[assembly: AssemblyProduct(GunExtras.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + GunExtras.BuildInfo.Author)]
[assembly: AssemblyTrademark(GunExtras.BuildInfo.Company)]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
//[assembly: Guid("")]
[assembly: AssemblyVersion(GunExtras.BuildInfo.Version)]
[assembly: AssemblyFileVersion(GunExtras.BuildInfo.Version)]
[assembly: NeutralResourcesLanguage("en")]
[assembly: MelonInfo(typeof(GunExtras), GunExtras.BuildInfo.Name, GunExtras.BuildInfo.Version, GunExtras.BuildInfo.Author, GunExtras.BuildInfo.DownloadLink)]


// Create and Setup a MelonModGame to mark a Mod as Universal or Compatible with specific Games.
// If no MelonModGameAttribute is found or any of the Values for any MelonModGame on the Mod is null or empty it will be assumed the Mod is Universal.
// Values for MelonModGame can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame("Harmonix Music Systems, Inc.", "Audica")]