# Recent Touch Only Input Package

This package provides a touch input module where the next touch cancels the previous one.

## Installation

### Package Manager UI
1. Open the **Package Manager** window in Unity.
2. Click the **Add package from git URL** button.
3. Paste the following URL:
    ```text
    https://github.com/Akilaydin/RecentTouchOnly.git
    ```

### Manual Installation
1. Open the `manifest.json` file located in the `Packages` folder of your Unity project.
2. Add the dependency for `RecentTouchOnly` as shown below:
    ```json
    {
      "dependencies": {
        "com.origames.recenttouchonlyinput": "https://github.com/Akilaydin/RecentTouchOnly.git"
      }
    }
    ```
3. Save the `manifest.json` file.
4. Open Unity, which will automatically download and import the package.

Both methods will integrate the `RecentTouchOnly` package into your Unity project seamlessly.

## Usage

1. Drag and drop the `RecentTouchOnlyInput.prefab` from the `Prefabs` folder onto the scene where you want the new touch logic.
2. If you want the prefab to persist between scenes, do not destroy it between scenes.

## API

### Events

- **Action<Touch> OnTouchCancel**: This event fires every time the touch gets cancelled and a new touch starts processing. It passes the touch that got cancelled.

### Properties

- **Touch MostRecentTouch**: This property returns the touch that is currently occurring.
