using CHARKOLE_GameService;
using UnityEngine;

public class DataManager : GameService
{
    [SerializeField]
    private SOPlayerData playerData;

    public override void Init()
    {
        base.Init();
    }

    public PlayerData GetPlayerData()
    {
        return playerData.GetPlayerData();
    }
}
