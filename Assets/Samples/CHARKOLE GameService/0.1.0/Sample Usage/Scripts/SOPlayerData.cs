using UnityEngine;

[CreateAssetMenu(fileName = "SOPlayerData", menuName = "Scriptable Objects/SOPlayerData")]
public class SOPlayerData : ScriptableObject
{
    [SerializeField]
    private PlayerData playerData;

    public PlayerData GetPlayerData()
    {
        return playerData;
    }
}
