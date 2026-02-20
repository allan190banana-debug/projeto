using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using Unity.VisualScripting;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;
public class Menu : MonoBehaviour
{
public string numberScene;
public GameObject settingMenu;
public GameObject buttonchangermenu;
public GameObject graficMenu;
public GameObject audioMenu;
public GameObject firstselected;
public GameObject firstselectedSetting;
private GameObject currentSelected;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       EventSystem.current.SetSelectedGameObject(firstselected);
         currentSelected = EventSystem.current.currentSelectedGameObject;
    }

    // Update is called once per frame
    void Update()
    {
      if (EventSystem.current.currentSelectedGameObject != null)
        {
            currentSelected = EventSystem.current.currentSelectedGameObject;
        }
        if(EventSystem.current.currentSelectedGameObject == null)
        {
            EventSystem.current.SetSelectedGameObject(currentSelected);
        }
    if (Keyboard.current.escapeKey.wasPressedThisFrame && settingMenu.activeInHierarchy && (!buttonchangermenu.activeInHierarchy && !graficMenu.activeInHierarchy && !audioMenu.activeInHierarchy))// temporario para fechar o menu de settings com o esc apos  
                                                                                        // criação do menu de pause de setings mais robusta alterar isso
        {
            ClosesettingsMenu();
        }
    }
    // Start Game
public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
// Quit Game
public void QuitGame()
    {
        Application.Quit();
    }
    // Open Settings Menu
public void OpensettingsMenu()
    {
        settingMenu.SetActive(true);
        firstselected= currentSelected;
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(firstselectedSetting);

    }   
    // Close Settings Menu
public void ClosesettingsMenu()
    {
        settingMenu.SetActive(false);
         EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(firstselected);
    }
}


      