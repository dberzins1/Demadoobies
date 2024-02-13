using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour
{
    public void StartGame()
    {
        // Load the scene named "Level1"
        SceneManager.LoadScene("Main Level");
    }
}