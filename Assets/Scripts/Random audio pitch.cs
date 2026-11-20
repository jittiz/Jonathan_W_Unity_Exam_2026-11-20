using UnityEngine;

public class Randomaudiopitch : MonoBehaviour
{

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        audioSource.pitch = Random.Range(0.5f, 2f);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.Play();
        }
    }
}
