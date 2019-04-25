using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPanel : MonoBehaviour
{
    public GameObject panel;
    public GameObject btnRepeat;
    public GameObject btnExit;

    private bool setAct = false;

    void Awake()
    {
        panel.SetActive(false);                                                                                                                                                                                                                                                                                                                                                                                                                     //соси
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            setAct = !setAct;
            panel.SetActive(setAct);
            Time.timeScale = setAct ? 0 : 1;
        }
    }

    public void Repeat()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
        Time.timeScale = 1;
    }

    public void Exit()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        Time.timeScale = 1;
    }
}
