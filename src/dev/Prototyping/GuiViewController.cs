using System.ComponentModel;
using OpenTK.Mathematics;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Common;

using ForgeWorks.CrossWind.Components;
using ForgeWorks.RailThorn.Presentation;

namespace ForgeWorks.RailThorn.Prototyping;

public class GuiViewController : ViewController
{
    private readonly GuiView view;

    public IView View => view;

    public GuiViewController(string name, string title) : base(name)
    {
        view = new(Name, title, (1200, 900), WindowState.Maximized)
        {
            Background = Color4.DarkGray
        };
    }

    protected override void OnInitializing(IWindowController controller)
    {
        WindowController = controller;
    }

    private void OnLoad()
    {

    }

    private void OnUnload()
    {

    }

    private void OnClosing(CancelEventArgs args)
    {

    }
}
