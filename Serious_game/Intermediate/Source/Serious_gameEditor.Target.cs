using UnrealBuildTool;

public class Serious_gameEditorTarget : TargetRules
{
	public Serious_gameEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Serious_game");
	}
}
