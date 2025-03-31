using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 2.0f;


    void Start()
    {

    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(x, y);
        transform.Translate(movement * speed * Time.deltaTime);
    }


}
