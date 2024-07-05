using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public Score_Manager sm;
    public bool PlayerDeath = false;

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Score"){
            sm.score++;
        }
        else {
            Destroy(gameObject);
            PlayerDeath = true;
            SceneManager.LoadScene("EndGame");
        }
    }
}
