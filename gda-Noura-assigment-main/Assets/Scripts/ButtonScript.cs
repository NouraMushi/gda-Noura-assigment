using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ButtonScript : MonoBehaviour
{
    [SerializeField] private Button pauseButton;
    [SerializeField] private Button resumeButton;
    [SerializeField] private GameObject pauseMenu; // Reference to your pause menu UI GameObject

    private bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        pauseButton.onClick.AddListener(() => pauseGame());
        resumeButton.onClick.AddListener(() => ResumeGame());

        // Ensure pause menu is initially hidden
        pauseMenu.SetActive(false);

    }

    public void pauseGame()
    {
        if (isPaused)
        {
            return; // Prevent redundant pausing
        }

        isPaused = true;
        Time.timeScale = 0.0f; // Pause time (game logic and physics)
        pauseMenu.SetActive(true); // Show pause menu
        // pauseButton.gameObject.SetActive(false);
    }

    public void ResumeGame()
    {
        if (!isPaused)
        {
            return; // Prevent redundant resuming
        }
        isPaused = false;
        pauseMenu.SetActive(false); // Hide pause menu
                                    //  resumeButton.gameObject.SetActive(true);
        Time.timeScale = 1.0f;
    }
    public void HandleSceneLoad()
    {
        SceneManager.LoadScene(1);
        // Scenelevel1.onClick.AddListener(HandleSceneLoad);
    }
}
