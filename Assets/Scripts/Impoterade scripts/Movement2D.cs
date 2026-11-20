using UnityEngine;

public class Movement2D : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(x, y, 0);

        //transform.Translate(movement * speed * Time.deltaTime);
        transform.position += movement * speed * Time.deltaTime;
    }
}
