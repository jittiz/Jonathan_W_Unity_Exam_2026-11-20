using UnityEngine;
using TMPro;

public class NPC : MonoBehaviour
{
    public int requiredCoins = 5;
    public TMP_Text dialogueText;
    public string Demand;
    public string Done;

    bool playerNearby = false;

    void Update()
    {
        if (playerNearby && Input.GetKeyDown(KeyCode.E))
        {
            if (Globals.coins < requiredCoins)
            {
                dialogueText.text = Demand;
            }
            else
            {
                dialogueText.text = Done;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerNearby = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerNearby = false;
            dialogueText.text = "";
        }
    }
}
