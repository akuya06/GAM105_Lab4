using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f;
    public float direction = 1f;

   

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = new Vector2(direction, 0f);
        transform.Translate(movement * speed * Time.deltaTime);

        if (Mathf.Abs(transform.position.x) >= 4.5)
        {
            direction *= -1;
        }
    }
}
