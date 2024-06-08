# Recent Touch Only Input Package

This package provides a touch input module where the next touch cancels the previous one.

## Installation

1. Add the following to your `manifest.json` in the `Packages` folder of your Unity project:
    ```json
    {
      "dependencies": {
        "com.origames.recenttouchonly": "https://github.com/Akilaydin/RecentTouchOnly.git"
      }
    }
    ```

2. Open Unity and it will automatically download and import the package.

## Usage

1. Drag and drop the `RecentTouchOnlyInput.prefab` from the `Prefabs` folder onto the scene where you want the new touch logic.
2. If you want the prefab to persist between scenes, do not destroy it between scenes.

## API

### Events

- **Action<Touch> OnTouchCancel**: This event fires every time the touch gets cancelled and a new touch starts processing. It passes the touch that got cancelled.

### Properties

- **Touch MostRecentTouch**: This property returns the touch that is currently occurring.