using OpenTK.Mathematics;
using OpenTK.Windowing.Common;

using ForgeWorks.CrossWind;
using ForgeWorks.CrossWind.Core;
using ForgeWorks.CrossWind.Components;

namespace ForgeWorks.RailThorn.Presentation;

public delegate void OnViewControllerInitializing(ControllerId controllerId);

public interface IViewController : IController
{
    /// <summary>
    /// Event raised when <see cref="ViewController"/> is initializing 
    /// </summary>
    event OnViewControllerInitializing Initializing;

    /// <summary>
    /// Determines if the <see cref="ViewController"/> has been initialized 
    /// </summary>
    bool IsInitialized { get; }
    Vector2i Size { get; }
    WindowState State { get; }
    Color4 Background { get; }
    string Title { get; }

    void Initialize(IWindowController windowController);
}
