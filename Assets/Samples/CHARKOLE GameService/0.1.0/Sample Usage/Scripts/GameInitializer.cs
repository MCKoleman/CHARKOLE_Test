using CHARKOLE_GameService;
using UnityEngine;

public class GameInitializer : ServiceInitializer
{
    protected override void RegisterServices()
    {
        base.RegisterServices();
        RegisterService<DataManager>();
    }
}
