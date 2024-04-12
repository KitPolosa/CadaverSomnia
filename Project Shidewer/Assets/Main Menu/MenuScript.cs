using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    [SerializeField] private GameObject levelSwitchingWindow;
    [SerializeField] private GameObject mainWindow;
    private GameObject currentWindow;

    private void Start()
    {
        currentWindow = mainWindow;
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void OpenLevelSwitching()
    {
        currentWindow.SetActive(false);
        levelSwitchingWindow.SetActive(true);
        currentWindow = levelSwitchingWindow;
    }

    public void OpenMain()
    {
        currentWindow.SetActive(false);
        mainWindow.SetActive(true);
        currentWindow = mainWindow;
    }

    public void openAnimTest()
    {
        SceneManager.LoadScene(1);
    }
}