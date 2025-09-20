using UnityEngine;
using TMPro;

public class UIPlayerData : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI healthText;
    [SerializeField]
    private TextMeshProUGUI speedText;
    [SerializeField]
    private TextMeshProUGUI damageText;

    private void Update()
    {
        PlayerData playerData = GameServices.DataManager.GetPlayerData();
        healthText.text = "Health: " + playerData.health.ToString();
        speedText.text = "Speed: " + playerData.speed.ToString();
        damageText.text = "Damage: " + playerData.damage.ToString();
    }
}
