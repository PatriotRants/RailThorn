
using ForgeWorks.RailThorn.Prototyping;

Console.WriteLine("CrossWind: [ForgeWorks.RailThorn]");

const string APP_NAME = "RailThorn";
const string TITLE = "Gui Prototyping";

using (var app = new GuiApplication(new GuiViewController(APP_NAME, TITLE)))
{
    app.Run();
}
