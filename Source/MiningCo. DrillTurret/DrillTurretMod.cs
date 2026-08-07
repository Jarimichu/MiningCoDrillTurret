using UnityEngine;
using Verse;

namespace DrillTurret;

public class DrillTurretMod : Mod
{
    public static DrillTurretModSettings Settings;

    public DrillTurretMod(ModContentPack content) : base(content)
    {
        Settings = GetSettings<DrillTurretModSettings>();
    }

    public override void DoSettingsWindowContents(Rect inRect)
    {
        var listing = new Listing_Standard();
        listing.Begin(inRect);
        listing.CheckboxLabeled("MCDT.EnableIdlePowerDraw".Translate(), ref Settings.EnableIdlePowerDraw,
            "MCDT.EnableIdlePowerDrawTT".Translate());
        listing.End();
        base.DoSettingsWindowContents(inRect);
    }

    public override string SettingsCategory()
    {
        return "MiningCo. Drill turret";
    }
}
