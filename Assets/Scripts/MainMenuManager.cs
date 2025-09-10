using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject titleUI;
    public GameObject optionsUI;
    public Toggle music;
    public Toggle sfx;
    private bool musicOn;
    private bool sfxOn;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Play()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void Options()
    {
        titleUI.SetActive(false);
        optionsUI.SetActive(true);
    }

    public void ToggleMusic()
    {
        if (music.isOn)
        {
            musicOn = false;
        }
        else
        {
            musicOn = true;
        }
    }

        public void ToggleSFX()
    {
        if (sfx.isOn)
        {
            sfxOn = false;
        }
        else
        {
            sfxOn = true;
        }
    }

    public void Back()
    {
        optionsUI.SetActive(false);
        titleUI.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
