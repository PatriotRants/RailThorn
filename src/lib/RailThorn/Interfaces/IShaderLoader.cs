using OpenTK.Graphics.OpenGL4;

namespace ForgeWorks.RailThorn.Graphics;

public interface IShaderLoader
{
    int Load(ShaderType shaderType, string sourceName);
    void CreateProgram(string programName, params int[] shaders);
    void DeleteProgram(string programName);
    int GetProgram(string programName);
}
