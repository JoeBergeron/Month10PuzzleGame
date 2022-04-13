using UnrealBuildTool;

public class PuzzleGameTemplateTarget : TargetRules
{
	public PuzzleGameTemplateTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("PuzzleGameTemplate");
	}
}
