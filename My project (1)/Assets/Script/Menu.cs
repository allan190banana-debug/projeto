using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
public string numberScene;
public GameObject settingMenu;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

public void QuitGame()
    {
        Application.Quit();
    }
public void OpensettingsMenu()
    {
        settingMenu.SetActive(true);
    }   
public void ClosesettingsMenu()
    {
        settingMenu.SetActive(false);
    }
}

