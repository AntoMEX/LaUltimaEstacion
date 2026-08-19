// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UltimaEstacion : ModuleRules
{
	public UltimaEstacion(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"UltimaEstacion",
			"UltimaEstacion/Variant_Horror",
			"UltimaEstacion/Variant_Horror/UI",
			"UltimaEstacion/Variant_Shooter",
			"UltimaEstacion/Variant_Shooter/AI",
			"UltimaEstacion/Variant_Shooter/UI",
			"UltimaEstacion/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
