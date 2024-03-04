using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using ForgeWorks.CrossWind.Components;

namespace ForgeWorks.RailThorn.Presentation;

public interface IView : IClient
{
    string Name { get; }
    Color4 Background { get; set; }
}