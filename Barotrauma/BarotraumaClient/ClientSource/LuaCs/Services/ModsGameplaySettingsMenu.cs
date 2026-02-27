namespace Barotrauma.LuaCs;

internal sealed class ModsGameplaySettingsMenu : ModsSettingsMenu
{
    public ModsGameplaySettingsMenu(GUIFrame contentFrame, 
        IPackageManagementService packageManagementService, 
        IConfigService configService, 
        SettingsMenu settingsMenuInstance) : base(contentFrame, packageManagementService, configService, settingsMenuInstance)
    {
        
    }

    protected override void DisposeInternal()
    {
        // TODO: Finish this later.
    }
}
