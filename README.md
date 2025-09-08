# Reusable Triggers

A lightweight Unity package for creating and managing reusable trigger events, making it easy to handle interactions across multiple objects and scenes.

## Features

- Simple and reusable trigger system  
- Works with **colliders** and **events**  
- Plug-and-play with **UnityEvents**  
- Minimal setup, easy to extend  
- Supports both 2D and 3D colliders  

## Installation

1.  Go to **Window > Package Manager**.

2.  Click the **+** button → **Add package from git URL...**.

3.  Paste the repo URL: https://github.com/douglasdasilva17/com.supertactic.reusabletriggers.git

## How to Use

1. Add the **TriggerZone** (3D) or **TriggerZone2D** script to your GameObject and assign a Collider component (use **Collider2D** for **TriggerZone2D**).

2. In the Inspector, enable the **Is Trigger** checkbox on the Collider.

3. Set the target's tag in the `Collision Tag` field.

4. Done! Your reusable trigger is now ready to use.
