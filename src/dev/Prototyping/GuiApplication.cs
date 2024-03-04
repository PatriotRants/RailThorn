using ForgeWorks.CrossWind.Core;
using ForgeWorks.CrossWind.Presentation;

namespace ForgeWorks.RailThorn.Prototyping;

public class GuiApplication : Application
{
    //  not even sure we need this property
    private GuiViewController ViewController { get; }
    private WindowController WindowController { get; }

    public GuiApplication(GuiViewController viewController) : base(viewController.Name)
    {
        var view = (ViewController = viewController).View;
        WindowController = new WindowController(view.Name, view.Title, view.WindowState);
    }

    protected override void OnStartUp()
    {
        base.OnStartUp();
        //  view controller needs to initialize with the window controller
        ViewController.Initialize(WindowController);
        //  now the window controller can run
        WindowController.Run();
    }
}