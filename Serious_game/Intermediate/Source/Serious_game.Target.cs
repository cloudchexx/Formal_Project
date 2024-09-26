using UnrealBuildTool;

public class Serious_gameTarget : TargetRules
{
	public Serious_gameTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Serious_game");
	}
}
