# 3D Pacman Game

Welcome to the **3D Pacman Game** repository! This project is a modern reimagining of the classic Pacman game, built using Unity. The game features 3D graphics, player controls, ghost AI, and various gameplay mechanics.

---

## Features

### Player Mechanics
- **Movement**: Control Pacman using arrow keys or WASD keys to navigate the maze.
- **Pickups**: Collect items scattered throughout the map to increase your score.
- **Win Condition**: Reach the target score to win the game.

### Ghost AI
- **Patrolling**: Ghosts patrol predefined points in the maze.
- **Chasing**: Ghosts chase Pacman when he enters their chase radius.
- **Return to Patrol**: Ghosts return to patrolling after a set chase duration.

### Camera
- **Follow Player**: The camera dynamically follows Pacman, maintaining a fixed offset.

### Minimap
- **Player Icon**: A minimap icon represents Pacman's position and orientation.

### Teleportation
- **Fixed Coordinates**: Teleport Pacman to specific coordinates when he enters a teleportation zone.

### Rotating Objects
- **Rotator**: Objects in the game rotate continuously to add visual interest.

---

## Scripts Overview

### [`PlayerController`](Assets/Scripts/PlayerController.cs)
Handles player movement, pickup collection, and win condition logic.

### [`GhostPatrol`](Assets/Scripts/GhostPatrol.cs)
Controls ghost patrolling behavior using Unity's NavMesh system.

```csharp
using UnityEngine;
using UnityEngine.AI;

public class GhostPatrol : MonoBehaviour
{
    public Transform[] patrolPoints; // Patrol points for the ghost
    private NavMeshAgent agent;
    private int currentPoint;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        GotoNextPoint();
    }

    void GotoNextPoint()
    {
        if (patrolPoints.Length == 0) return;

        agent.destination = patrolPoints[currentPoint].position;
        currentPoint = (currentPoint + 1) % patrolPoints.Length;
    }

    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
            GotoNextPoint();
    }
}

GhostBehavior
Manages ghost chasing and patrolling logic based on proximity to Pacman.

CameraController
Keeps the camera positioned relative to Pacman.

MinimapIcon
Updates the minimap icon to match Pacman's position and orientation.

TeleportWithFixedCoordinates
Teleports Pacman to fixed coordinates when he enters a teleportation zone.

Rotator
Rotates objects continuously for visual effects.

How to Play
Clone the repository:
Open the project in Unity.
Build and run the game.
Use arrow keys or WASD to control Pacman and collect all pickups while avoiding ghosts.
Requirements
Unity 2021 or later
NavMesh system enabled in Unity
TextMesh Pro package installed
Contributing
Contributions are welcome! Feel free to open issues or submit pull requests to improve the game.

License
This project is licensed under the MIT License. See the LICENSE file for details.
