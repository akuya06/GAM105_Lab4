using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject winScreen;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Vector2 pos = new Vector2(-7.5f, 0.5f);
            transform.position = pos;
        }

        if (collision.gameObject.name.Equals("Box")){
            SceneManager.LoadScene("Man 2");
            
        }
    }
}
