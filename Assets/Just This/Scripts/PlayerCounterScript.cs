using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerCounterScript : MonoBehaviour
{
    public Text counterText; // UI Text element for the counter
    public int counter = 0; // Counter for picked up items

    public void IncreaseCounter()
    {
        // Increase the counter and update the UI Text
        counter++;
        counterText.text = counter.ToString();
        if (counter >= 5)
        {
            // Load the "WinScreen" scene
            SceneManager.LoadScene("WinScreen");
        }
    }
    
    
}