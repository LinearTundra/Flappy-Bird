using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{ 
    public void loadGame() {
        SceneManager.LoadScene("Game");
    }
}
