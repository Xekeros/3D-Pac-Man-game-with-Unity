# 3D Pacman Game

Welcome to the **3D Pacman Game** repository! This project is a modern 3D reimagining of the classic Pacman game, built with Unity. The game features player controls, ghost AI, pickups, teleportation, a minimap, and more.

---

## Features

### Player Mechanics
- **Movement**: Control Pacman using arrow keys or WASD to navigate the maze.
- **Pickups**: Collect items scattered throughout the map to increase your score.
- **Win Condition**: Reach the target score to win the game.

### Ghost AI
- **Patrolling**: Ghosts patrol predefined points in the maze.
- **Chasing**: Ghosts chase Pacman when he enters their chase radius.
- **Return to Patrol**: Ghosts return to patrolling after a set chase duration.

### Camera
- **Follow Player**: The camera follows Pacman with a fixed offset.

### Minimap
- **Player Icon**: A minimap icon shows Pacman's position and orientation.

### Teleportation
- **Fixed Coordinates**: Teleport Pacman to specific coordinates when he enters a teleportation zone.

### Rotating Objects
- **Rotator**: Some objects rotate continuously for visual effect.

---

## Scripts Overview

### [`PlayerController`](Assets/Scripts/PlayerController.cs)
Handles player movement, pickup collection, and win condition logic.

### [`GhostBehavior`](Assets/Scripts/GhostBehavior.cs)
Manages ghost chasing and patrolling logic based on proximity to Pacman.

### [`GhostPatrol`](Assets/Scripts/GhostPatrol.cs)
Controls ghost patrolling behavior using Unity's NavMesh system.

### [`CameraController`](Assets/Scripts/CameraController.cs)
Keeps the camera positioned relative to Pacman.

### [`MinimapIcon`](Assets/Scripts/PlayerIcon.cs)
Updates the minimap icon to match Pacman's position and orientation.

### [`TeleportWithFixedCoordinates`](Assets/Scripts/TeleportPlayer.cs)
Teleports Pacman to fixed coordinates when he enters a teleportation zone.

### [`Rotator`](Assets/Scripts/Rotator.cs)
Rotates objects continuously for visual effects.

---

## How to Play

1. Clone the repository:
   ```sh
   git clone <repo-link>
   ```
2. Open the project in Unity.
3. Build and run the game.
4. Use arrow keys or WASD to control Pacman, collect all pickups, and avoid ghosts.

---

## Requirements

- Unity 2021 or later
- NavMesh system enabled in Unity
- TextMesh Pro package installed

---

## Contributing

Contributions are welcome! Feel free to open issues or submit pull requests to improve the game.


