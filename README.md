# PinBall

A Unity pinball game built with physics-based ball movement, flipper controls, plunger launching, relaunch handling, custom materials, and a simple 3D table setup.

## 🎮 Overview

**PinBall** is a small Unity project focused on creating a playable pinball-style game using Unity physics. The project includes a ball, flippers, a launch/plunger system, collision-based relaunching, table physics materials, and URP-based visuals.

The game is designed as a clean starting point for building a more advanced arcade pinball experience.

## ✨ Features

- Unity-based 3D pinball table
- Physics-driven ball movement
- HingeJoint-powered flipper system
- Plunger launch mechanic
- Trigger-based launch helper
- Ball relaunch/reset system
- Custom physics materials for the ball and table
- URP project setup
- ProBuilder assets for level/table construction
- Shader Graph material support
- Simple keyboard input controls

## 🕹️ Controls

| Action | Key |
|---|---|
| Launch ball | `L` |
| Left flipper | `A` |

> Controls can be expanded or changed inside the Unity scripts and Input System settings.

## 🧩 Main Scripts

### `Left Flipper.cs`
Controls the left flipper using a `HingeJoint` and spring force. Pressing `A` moves the flipper to its active position, then returns it when the key is released.

### `Plunger.cs`
Launches the ball once using an impulse force when `L` is pressed.

### `Plunger update.cs`
Applies an impulse force when the ball enters a launch trigger zone.

### `Relaunch.cs`
Moves the ball back to a spawn point when it collides with the drain/relaunch area.

## 📁 Project Structure

```text
PinBall/
├── Assets/
│   ├── Scenes/
│   ├── Settings/
│   ├── ProBuilder Data/
│   ├── Ball.shadergraph
│   ├── Left Flipper.cs
│   ├── Plunger.cs
│   ├── Plunger update.cs
│   ├── Relaunch.cs
│   ├── Right Flipper.cs
│   ├── Ball_physics.physicMaterial
│   ├── Table_physics.physicMaterial
│   ├── ball.mat
│   ├── Flipper.mat
│   └── Map.mat
├── Packages/
│   ├── manifest.json
│   └── packages-lock.json
├── ProjectSettings/
├── .gitignore
├── .gitattributes
├── LICENSE
└── README.md
