using Mlie;
using UnityEngine;
using Verse;

namespace DrillTurret;

public class DrillTurretMod : Mod
{
    public static DrillTurretModSettings Settings;
    private static string currentVersion;

    public DrillTurretMod(ModContentPack content) : base(content)
    {
        Settings = GetSettings<DrillTurretModSettings>();
        currentVersion = VersionFromManifest.GetVersionFromModMetaData(content.ModMetaData);
    }

    public override void DoSettingsWindowContents(Rect inRect)
    {
        var listing = new Listing_Standard();
        listing.Begin(inRect);
        listing.CheckboxLabeled("MCDT.EnableIdlePowerDraw".Translate(), ref Settings.EnableIdlePowerDraw,
            "MCDT.EnableIdlePowerDrawTT".Translate());
        if (currentVersion != null)
        {
            listing.Gap();
            GUI.contentColor = Color.gray;
            listing.Label("MCDT.CurrentModVersion".Translate(currentVersion));
            GUI.contentColor = Color.white;
        }

        listing.End();
        base.DoSettingsWindowContents(inRect);
    }

    public override string SettingsCategory()
    {
        return "MiningCo. Drill turret";
    }
}