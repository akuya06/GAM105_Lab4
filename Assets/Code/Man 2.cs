using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Man2 : MonoBehaviour
{
    public GameObject winScreen;
    public string foodTag = "Food";
    public int totalFood = 4;
    private int collectedFood = 0;
    public AudioClip foodSound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        totalFood = GameObject.FindGameObjectsWithTag(foodTag).Length;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Vector2 pos = new Vector2(-8.5f, 2.5f);
            transform.position = pos;
        }

        if (collision.gameObject.name.Equals("Box"))
        {
            if (collectedFood >= totalFood)
            {
                winScreen.SetActive(true);
                Time.timeScale = 0f;
            }
        }

        if (collision.gameObject.CompareTag("Food"))
        {
            if (foodSound != null)
            {
                audioSource.PlayOneShot(foodSound);
            }
            collectedFood++;
            Destroy(collision.gameObject);
        }
    }
}
