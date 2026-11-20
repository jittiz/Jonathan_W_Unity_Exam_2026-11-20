using UnityEngine;
using TMPro;

public class CoinUI : MonoBehaviour
{
    public TMP_Text coinText;

    void Update()
    {
        coinText.text = "Coins: " + Globals.coins;
    }
}
