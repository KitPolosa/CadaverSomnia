using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IngameMenuScript : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    public AudioSource audioSource;
    public AudioClip pauseSound;

    public void OpenPauseMenu()
    {
        StartCoroutine(PlayPauseSound());
        StartCoroutine(OpenPauseMenuDelayed());
    }

    public void ExitToMenu()
    {
        AudioListener.pause = false;
        Time.timeScale = 1f;
        StartCoroutine(ExitMenu());
    }

    public void ClosePauseMenu()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        AudioListener.pause = false;
    }

    IEnumerator PlayPauseSound()
    {
        audioSource.PlayOneShot(pauseSound);
        yield return null;
    }

    IEnumerator OpenPauseMenuDelayed()
    {
        yield return new WaitForSeconds(0.3f);
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        AudioListener.pause = true;
    }

    IEnumerator ExitMenu()
    {
        //AudioListener.pause = false;
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(0);
    }
}