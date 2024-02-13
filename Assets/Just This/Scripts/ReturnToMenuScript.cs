using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenuScript : MonoBehaviour
{
    public void ReturnToMenu()
    {
        // Load the scene named "StartMenu"
        SceneManager.LoadScene("StartMenu");
    }
}