using UnrealBuildTool;

public class Serious_gameClientTarget : TargetRules
{
	public Serious_gameClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Serious_game");
	}
}
