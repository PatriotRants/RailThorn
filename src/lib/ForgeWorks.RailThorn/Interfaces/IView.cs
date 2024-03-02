using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using ForgeWorks.CrossWind.Components;

namespace ForgeWorks.RailThorn.Presentation;

public interface IView : IClient
{
    string Name { get; }
    string Title { get; }
    Color4 Background { get; set; }
    Vector2i ClientSize { get; set; }
    WindowState State { get; set; }
}