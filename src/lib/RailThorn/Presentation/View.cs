using System.ComponentModel;

using OpenTK.Mathematics;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;

namespace ForgeWorks.RailThorn.Presentation;

/// <summary>
/// TODO:   implement Component base class
/// </summary>
public abstract class View : /* Component, */ IView
{
    public string Name { get; }
    public string Title { get; set; }
    public Color4 Background { get; set; }
    public Vector2i ClientSize { get; set; }
    public IGLFWGraphicsContext Context { get; set; }
    public WindowState WindowState { get; set; }

    protected View(string name)
    {
        Name = name;
    }

    public virtual void OnRenderView(FrameEventArgs args)
    {
        GL.ClearColor(Background);
        GL.Clear(ClearBufferMask.ColorBufferBit);

        Context.SwapBuffers();
    }
    public abstract void OnUpdateView(FrameEventArgs args);
    public abstract void OnClosingWindow(CancelEventArgs args);
    public abstract void OnFileDrop(FileDropEventArgs args);
    public abstract void OnFramebufferResize(FramebufferResizeEventArgs args);
    public abstract void OnKeyDown(KeyboardKeyEventArgs args);
    public abstract void OnKeyUp(KeyboardKeyEventArgs args);
    public abstract void OnMouseDown(MouseButtonEventArgs args);
    public abstract void OnMouseEnterWindow();
    public abstract void OnMouseLeaveWindow();
    public abstract void OnMouseWheel(MouseWheelEventArgs args);
    public abstract void OnRefresh();
    public abstract void OnResizeWindow(ResizeEventArgs args);
    public abstract void OnTextInput(TextInputEventArgs args);
    public abstract void OnWindowMaximized(MaximizedEventArgs args);
    public abstract void OnWindowMinimized(MinimizedEventArgs args);
    public abstract void OnWindowMove(WindowPositionEventArgs args);
}
