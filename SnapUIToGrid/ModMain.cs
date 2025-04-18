using MelonLoader;

namespace SnapUIToGrid;

public class ModMain : MelonMod
{
    public override void OnInitializeMelon()
    {
        var category = MelonPreferences.CreateCategory("SnapUIToGrid");
        var snapAmount = category.CreateEntry("SnapAmount", 5f);

        Globals.SnapAmount = snapAmount.Value;
        category.SaveToFile(false);
    }

    public const string PluginVersion = "1.0.0";
}