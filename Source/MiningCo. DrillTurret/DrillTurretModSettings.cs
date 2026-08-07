using Verse;

namespace DrillTurret;

public class DrillTurretModSettings : ModSettings
{
    public bool EnableIdlePowerDraw;

    public override void ExposeData()
    {
        base.ExposeData();
        Scribe_Values.Look(ref EnableIdlePowerDraw, "EnableIdlePowerDraw");
    }
}
