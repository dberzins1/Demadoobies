using UnityEngine;

public class PauseMenuScript : MonoBehaviour
{
    private GameObject Pause; // The pause menu canvas

    void Start()
    {
        // Find the pause menu canvas by name
        Pause = GameObject.Find("Pause");
    }

    void Update()
    {
        // Check if the Escape key was pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Toggle the active state of the pause menu canvas
            Pause.SetActive(!Pause.activeSelf);
        }
    }
}