// Copyright 2015-2022 MY.GAMES. All Rights Reserved.

using System.IO;

namespace UnrealBuildTool.Rules
{
	public class PsDataEditor : ModuleRules
	{
		public PsDataEditor(ReadOnlyTargetRules Target) : base(Target)
		{
			PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

			PrivateIncludePaths.AddRange(
				new string[] {
					"PsDataEditor/Private",
				}
			);

			PublicDependencyModuleNames.AddRange(
				new string[]
				{
					"Core",
					"CoreUObject",
					"PsData",
					"Engine",
					"Json",
					"Xml",
				}
			);

			PrivateDependencyModuleNames.AddRange(
				new string[]
				{
					"AnimGraph",
					"BlueprintGraph",
					"UnrealEd",
					"GraphEditor",
					"AssetTools",
					"UnrealEd",
					"KismetWidgets",
					"KismetCompiler",
					"Kismet",
					"PropertyEditor",
					"EditorStyle",
					"Sequencer",
					"Settings",
					"RenderCore",
					"Slate",
					"SlateCore",
					"Conda",
					"DetailCustomizations",
					"DesktopPlatform",
					"ToolMenus"
				}
			);
		}
	}
}
