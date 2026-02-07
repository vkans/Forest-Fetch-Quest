# Forest Fetch Quest

A first-person adventure game built with Unity 6, where you explore a mysterious forest, collect magical pages, interact with NPCs, and face various challenges to complete your quest.

## Game Overview

Forest Fetch Quest is an immersive first-person exploration game set in a fantasy forest environment. Your objective is to collect scattered pages from a magical book while navigating through the forest, avoiding hazards, and interacting with the world around you.

## Features

- **First-Person Exploration**: Smooth FPS controller with walking, running, and jumping mechanics
- **Page Collection System**: Collect 3 magical pages scattered throughout the forest
- **Enemy Encounters**: Face enemies with AI-driven behavior and stun mechanics
- **NPC Interactions**: Dialogue system for interacting with characters in the world
- **Pet Companion**: A pet that follows and assists you on your journey
- **Environmental Hazards**: Navigate falling logs and other obstacles
- **Portal System**: Magical portals that transport you between locations
- **Dynamic Objectives**: Clear objectives that guide you through the quest
- **Rich Environment**: Beautiful forest setting with detailed assets and atmospheric audio

## Requirements

### Unity Version
- **Unity 6000.2.4f1** or compatible Unity 6 version

### Required Packages
The project uses the following Unity packages (automatically managed via Package Manager):
- Unity AI Navigation (2.0.9)
- Unity Input System (1.14.2)
- Universal Render Pipeline (17.2.0)
- Unity Timeline (1.8.9)
- TextMesh Pro (included)
- Visual Scripting (1.9.7)

### System Requirements
- **OS**: Windows, macOS, or Linux
- **Graphics**: DirectX 11 or OpenGL 3.2 compatible graphics card
- **RAM**: 4GB minimum (8GB recommended)
- **Storage**: ~3GB free space (includes all assets)

## Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/vkans/Forest-Fetch-Quest.git
   cd Forest-Fetch-Quest
   ```

2. **Open in Unity**:
   - Launch Unity Hub
   - Click "Add" and select the cloned project folder
   - Ensure you have Unity 6000.2.4f1 installed
   - Open the project

3. **Install Git LFS** (if not already installed):
   ```bash
   # macOS
   brew install git-lfs
   
   # Windows
   # Download from https://git-lfs.github.com/
   
   # Initialize Git LFS
   git lfs install
   ```

4. **Pull LFS files**:
   ```bash
   git lfs pull
   ```

5. **Open the main scene**:
   - Navigate to `Assets/MainScene.unity`
   - Press Play to test the game

## How to Play

### Controls
- **WASD**: Move
- **Left Shift**: Run
- **Space**: Jump
- **Mouse**: Look around
- **E**: Interact (when near interactable objects)
- **ESC**: Unlock cursor (for testing)

### Objectives
1. Explore the forest environment
2. Collect all 3 magical pages scattered throughout the world
3. Avoid or defeat enemies
4. Return to the hut once all pages are collected
5. Use the activated portal to complete your quest

## Project Structure

```
Forest-Fetch-Quest/
├── Assets/
│   ├── Scripts/              # C# game scripts
│   │   ├── FPSController.cs  # First-person player controller
│   │   ├── PageManager.cs    # Page collection system
│   │   ├── EnemyAI.cs        # Enemy behavior
│   │   ├── NPCDialogue.cs    # NPC interaction
│   │   └── ...
│   ├── Scenes/               # Unity scene files
│   │   └── MainScene.unity   # Main game scene
│   ├── Prefabs/              # Reusable game objects
│   ├── Materials/            # Material assets
│   ├── Audio/                # Sound effects and music
│   └── [Asset Packages]/     # Third-party assets
├── ProjectSettings/          # Unity project configuration
├── Packages/                 # Unity package dependencies
└── README.md                 # This file
```

## Assets & Credits

This project includes assets from various sources:

- **AllSky Free**: Sky and environment assets
- **Fantasy Forest Environment Free Sample**: Forest terrain and vegetation
- **Cozy Mountain Cabin**: Cabin and building assets
- **NPC Casual Set**: Character models and animations
- **Monster Ghosts FREE**: Enemy character assets
- **BookHeadMonster**: Monster character
- **Nature Sound FX**: Environmental audio
- **TextMesh Pro**: Text rendering (Unity package)
- Various other free and paid assets from the Unity Asset Store

## Building the Project

### WebGL Build
1. Go to `File > Build Settings`
2. Select `WebGL` platform
3. Click `Build` or `Build and Run`
4. Output will be in the `Forest Fetch Final/` directory

### Standalone Build
1. Go to `File > Build Settings`
2. Select your target platform (Windows, macOS, or Linux)
3. Click `Build` or `Build and Run`
4. Choose an output directory

## Known Issues

- Large file sizes: The project uses Git LFS for binary assets. Ensure Git LFS is properly installed and initialized.
- Build artifacts: The `.gitignore` excludes build folders. Rebuild the project after cloning.

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## License

This project is provided as-is. Please check individual asset licenses for usage rights.

## Acknowledgments

- Unity Technologies for the Unity Engine
- All asset creators and contributors
- The Unity community for support and resources

---

**Note**: This project uses Git LFS for large binary files. Make sure Git LFS is installed and initialized before cloning.

