# GitHub Copilot Instructions for MiningCo. DrillTurret (Continued) Mod

## Mod Overview and Purpose

The **MiningCo. DrillTurret (Continued)** mod is an update of the original mod by Rikiki, enhancing gameplay in RimWorld by adding advanced mining technology. The centerpiece of this mod is the Drill Turret, a sophisticated device designed to automatically drill nearby ores and natural rocks, thereby streamlining your colony’s mining operations.

### Purpose
- Introduce an automated system to improve and simplify the mining process within the game.
- Provide players with a strategic resource management tool that enhances gameplay and immersion.

## Key Features and Systems

1. **Drill Turret Addition**:
    - Automatically drills nearby ores and natural rocks.
    - Configurable mining modes allow selection between mining only ores, only rocks, or both.

2. **Improved Drilling Efficiency**:
    - Manning the turret with a high-level miner increases its drilling speed (e.g., a level 20 miner can mine twice as fast using the turret).
    - Additional research options are available to boost the turret’s efficiency and resource yield.

3. **Research Integration**:
    - Research projects linked to improving drill turret efficiency and outcomes, integrated within the existing RimWorld research system.

4. **Dynamic Textures**:
    - Dynamically handles transparent textures to enhance visual feedback.

## Coding Patterns and Conventions

- **C# File Organization**: Code is modularly divided into specific files for different functionalities such as job management, alerts, and utility functions.
- **Consistent Naming Conventions**: Utilizes PascalCase for class and method names to maintain readability and consistency across the codebase.
- **XML Def Integration**: XML files define various game elements such as effects, jobs, research projects, and buildings, allowing for easy customization and scalability.

## XML Integration

- **Effecter_LaserDrill.xml**: Defines visual and auditory effects for the drill turret operations.
- **Jobs_Work.xml**: Specifies job definitions related to operating the drill turret.
- **ResearchProjects_DrillTurret.xml**: Contains definitions for research projects improving turret performance.
- **Buildings_DrillTurret.xml**: Outlines the construction parameters and behavior of the drill turret structure.
- **WorkGivers.xml**: Details work giver definitions for assigning operational jobs to the drill turret.

## Harmony Patching

- **Harmony** is not explicitly mentioned, but if needed, patterns for patching methods and classes should follow conventional Harmony practices, such as using HarmonyPostfix or HarmonyPrefix attributes on methods that require modification.

## Suggestions for Copilot

1. **Code Suggestions**:
   - Suggest streamlined methods for interacting with RimWorld’s job and work giver systems.
   - Offer efficient loops and conditional logic for managing turret operations and resource extraction processes.

2. **XML Definitions**:
   - Generate XML elements accurately reflecting in-game mechanics, ensuring alignment with RimWorld standards.
   - Assist in creating cohesive and error-free XML entries, particularly for new effects, job definitions, and building setups.

3. **Harmony Assistance**:
   - Propose Harmony patches for modifying existing game mechanics or introducing new functionalities without affecting core game files.

4. **Dynamic Texture Drawing**:
   - Aid in implementing efficient rendering techniques to handle dynamic texture updates on the drill turret, enhancing visual feedback.

By adhering to these structured guidelines, mod developers can effectively leverage GitHub Copilot to maintain and enhance the MiningCo. DrillTurret mod, ensuring comprehensive integration and enriched gameplay experiences.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).

