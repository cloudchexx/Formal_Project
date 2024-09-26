using UnrealBuildTool;

public class Serious_gameServerTarget : TargetRules
{
	public Serious_gameServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Serious_game");
	}
}
