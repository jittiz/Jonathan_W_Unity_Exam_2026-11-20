using UnityEngine;

public class Coin : MonoBehaviour
{
    public string triggerTag = "Player";

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(triggerTag))
        {
            Globals.coins += 1;
            Destroy(gameObject);
        }
    }
}
