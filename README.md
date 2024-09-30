# Demo of GODS (Globally Observable Data Structures)

## Overview
GODS (Globally Observable Data Structures) allows you to easily manage and respond to changes in your Unity game's data without the need for complex object references or tightly coupled code by leveraging globally accessible observable variables, lists, hash sets and events.
Save and load your data easily through the GODS SaveSlot system.

## Key Features
- **Observable Variables, Lists, and Hash Sets**: Globally accessible data structures that trigger events when their values change.
- **Scriptable Object-Based Architecture**: Decouple systems and reduce scene dependencies for a more modular and maintainable codebase.
- **Reactive Event System**: Automatically respond to data changes, enabling dynamic and responsive gameplay.
- **Binding Components**: Sliders, Filled Images, Toggles, Materials, Texture, ..., keep visuals updated without effort.
- **Intelligent Tagging System**: Tag Observables for filtering and reset purposes.
- **Reference Tracking**: Easily investigate which objects are listening for events at runtime..
- **GODS Hub**: A powerful management window for filtering, searching, and bulk operations on observables.
- **Flexible Save Management**: Supports multi-user save slots, auto/manual saving, encryption, and screenshots.
- **Customizable**: Easily generate new observable types and extend the system to fit your project needs.

## Installation
1. Clone or download this repository.
2. Open the project in Unity (version 2021.3.33f1 or later is recommended).
3. After loading the project, follow the demo scene instructions to start exploring the functionality of GODS.

> **Note**: Ensure you have the required Unity Editor version to avoid compatibility issues.

## How to Use the Demo
1. Open a `DemoScene` in the `GODS Observables/Examples/Scenes` folder.
2. Press Play in the Unity Editor to interact with the demo.
3. Use the elements in the UI to manipulate the data of variables and see the scene updating accordingly through references to these variables.

### Key Features to Try:
- Modify data values and observe updates.
- Test the system by creating new data structures like Variables/Lists/HashSets. Then reference them in your scene and use the OnValueChanged methods to easily react to changes.

## Demo Limitations
This demo version of GODS includes features from **GODS: Globally Observable Data Structures v1.0.0** with the following limitations:

- **Non-commercial use only**: The demo is licensed for personal, non-commercial use only.
- **Not working in build**: The demo is restricted to the Unity Editor and cannot be used in builds.
- **GODS Hub window not available**: The centralized management window (GODS Hub) is disabled in the demo.
- **Limited Reset Data Tags**: Reset Data Tags are limited to: `OnEnable`, `OnSceneLoaded`, `OnSceneLoadedAdditive`, and `OnSceneUnloaded` only.
- **SaveSlots**: SaveSlot features are limited to 10 data entries, with no encryption or screenshots available.
- **GODS Binders**: Lerp functionality in GODS Binders is disabled in this version.
- **Quality of Life**: Missing some QoL features like automatic variable naming
- **Icons**: Default ScriptableObject icons are used for SaveSlots, Variables, Lists, and other elements.

For full functionality, please consider purchasing the full version. Get it here: [GODS](https://assetstore.unity.com/packages/slug/294571)

## License
This demo is licensed under a custom license that allows for personal, non-commercial use only. See [LICENSE.txt](https://github.com/TobiFroi/Demo-of-GODS-Globally-Observable-Data-Structures/blob/main/License.txt) for full details.

## Support
If you encounter any issues while using the demo or have any questions, please feel free to [open an issue](https://github.com/Demo-of-GODS-Globally-Observable-Data-Structures/issues) or contact me at [tobias.froihofer@gmx.at](mailto:tobias.froihofer@gmx.at).

