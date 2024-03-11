using OpenTK.Mathematics;
using OpenTK.Graphics.OpenGL4;

using ForgeWorks.CrossWind.Components;

namespace ForgeWorks.RailThorn.Presentation;

public interface IView : IClient
{
    string Name { get; }
    Color4 Background { get; set; }

    int LoadShader(ShaderType shaderType, string sourceName);
    void CreateProgram(string programName, params int[] shaders);
    void DeleteProgram(string programName);
}