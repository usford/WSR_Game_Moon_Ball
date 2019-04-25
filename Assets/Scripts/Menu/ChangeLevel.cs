using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    public void Level1()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }

    public void Level2()
    {
        SceneManager.LoadScene("Level2", LoadSceneMode.Single);
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
