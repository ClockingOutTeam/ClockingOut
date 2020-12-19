using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
<<<<<<< HEAD
        SceneManager.LoadScene("ClockLevel 1");
=======
        SceneManager.LoadScene("ClockLevel");
>>>>>>> 8d9619ee4717d19bd32d597bd18c7981ef8364aa
    }

    public void QuitGame ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
