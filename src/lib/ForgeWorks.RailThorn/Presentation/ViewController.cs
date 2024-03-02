using OpenTK.Mathematics;
using OpenTK.Windowing.Common;

using ForgeWorks.CrossWind.Core;
using ForgeWorks.CrossWind.Components;
using ForgeWorks.CrossWind.Collections;

namespace ForgeWorks.RailThorn.Presentation;

public abstract class ViewController : Controller, IViewController
{
    /// <summary>
    /// <inheritdoc />
    /// </summary>
    public event OnViewControllerInitializing Initializing;

    /// <summary>
    /// <inheritdoc />
    /// </summary>
    public bool IsInitialized { get; private set; }
    public string Title { get; init; }
    public Vector2i Size { get; set; } = new(800, 600);
    public WindowState State { get; set; } = WindowState.Normal;
    public Color4 Background { get; set; } = Color4.LightGray;

    protected IWindowController WindowController { get; set; }

    /// <summary>
    /// Instantiates a new registered view controller 
    /// </summary>
    /// <param name="name">ViewController name</param>
    protected ViewController(string name) : base(name)
    {
        Registries.Controllers.Add(this);
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public void Initialize(IWindowController windowController)
    {
        Initializing?.Invoke(Id);
        OnInitializing(windowController);

        IsInitialized = true;
    }

    /// <summary>
    /// When implemented in a <see cref="ViewController"/> descendent, configure 
    /// <see cref="View"/> parameters and additional resources here.
    /// </summary>
    /// <param name="view"><see cref="ViewController"/>'s View</param>
    protected abstract void OnInitializing(IWindowController windowController);
}
