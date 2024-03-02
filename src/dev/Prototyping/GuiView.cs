using System.ComponentModel;
using OpenTK.Mathematics;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Common;

using ForgeWorks.RailThorn.Presentation;

namespace ForgeWorks.RailThorn.Prototyping;

public class GuiView : View
{
    public GuiView(string name, string title, Vector2i size, WindowState windowState) : base(name)
    {
        Title = title;
        ClientSize = size;
        State = windowState;
    }

    public override void OnClosingWindow(CancelEventArgs args)
    {

    }

    public override void OnFileDrop(FileDropEventArgs args)
    {

    }

    public override void OnFramebufferResize(FramebufferResizeEventArgs args)
    {

    }

    public override void OnKeyDown(KeyboardKeyEventArgs args)
    {

    }

    public override void OnKeyUp(KeyboardKeyEventArgs args)
    {

    }

    public override void OnMouseDown(MouseButtonEventArgs args)
    {

    }

    public override void OnMouseEnterWindow()
    {

    }

    public override void OnMouseLeaveWindow()
    {

    }

    public override void OnMouseWheel(MouseWheelEventArgs args)
    {

    }

    public override void OnRefresh()
    {

    }

    public override void OnRenderView(FrameEventArgs args)
    {
        Console.WriteLine("GuiView.OnRender");

        base.OnRenderView(args);
    }

    public override void OnResizeWindow(ResizeEventArgs args)
    {
        Console.WriteLine("GuiView.OnResize");

        // Update the opengl viewport
        GL.Viewport(0, 0, ClientSize.X, ClientSize.Y);
    }

    public override void OnTextInput(TextInputEventArgs args)
    {

    }

    public override void OnUpdateView(FrameEventArgs args)
    {

    }

    public override void OnWindowMaximized(MaximizedEventArgs args)
    {

    }

    public override void OnWindowMinimized(MinimizedEventArgs args)
    {

    }

    public override void OnWindowMove(WindowPositionEventArgs args)
    {

    }
}
