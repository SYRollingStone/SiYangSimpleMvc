
# SiYangUnityMVC - A Simple Unity MVC Framework
[中文](README.md)

SiYangUnityMVC is a lightweight Unity MVC framework designed to simplify the implementation of the MVC structure in Unity projects. It provides the simplest design for Model, View, and Controller, allowing developers to integrate and use quickly. The framework includes basic binding, subscription, and event notification mechanisms to help you better manage data and user interaction logic.

## Features

- Simple and easy-to-use MVC structure
- Supports data binding and event notification
- Lightweight design, suitable for rapid development
- Uses C# standard library and Unity UI components

## Installation

1. Download or clone this repository.
2. Place the `SiYangUnityMVC` folder into your Unity project's `Assets` folder.
3. Start using the MVC pattern with tools like `BindUtil`, `IMvcController`, and `SYMvcDisposer`.

## Usage

Please check Samples first.

### Bind Data and View
```csharp
using _02_Scripts._LikeBallBlast.SiYangMVC;

// Create an observable
SYMvcObservable<int> observable = new SYMvcObservable<int>();

// Create a disposer to manage the binding lifecycle
SYMvcDisposer disposer = new SYMvcDisposer();

// Bind data changes to view rendering
disposer.Bind(observable, value => Debug.Log("Data Changed: " + value));

// Update the data, automatically triggering view update
observable.Value = 10;
```

### Bind Button Events
```csharp
using UnityEngine;
using UnityEngine.UI;
using _02_Scripts._LikeBallBlast.SiYangMVC;

public class ButtonHandler : MonoBehaviour
{
    public Button button;
    private SYMvcDisposer disposer = new SYMvcDisposer();

    void Start()
    {
        disposer.OnClick(button, () => Debug.Log("Button Clicked!"));
    }
}
```

### Implement Controller Interface
```csharp
public class MyController : MonoBehaviour, IMvcController
{
    public void Bind()
    {
        // Implement binding logic
    }

    public void Unbind()
    {
        // Implement unbinding logic
    }
}
```

## Contributing

Feel free to submit issues and pull requests!

## License

MIT License.
