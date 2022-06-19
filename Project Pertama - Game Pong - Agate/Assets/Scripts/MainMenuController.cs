using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Play Scene");
        Debug.Log("Create by Aditheo Firman Saputra-149251970100-108");
    }

    public void Credit()
    {
        SceneManager.LoadScene("Credit");
    }
}
