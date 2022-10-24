using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
public class PauseMenu : MonoBehaviour
{
    [SerializeField] private UnityEvent <int> onMenuPause = new UnityEvent<int>();
    public bool paused;
    [SerializeField] 
    private GameObject pauseMenu;
    [SerializeField] 
    private GameObject mainPauseScreen;
    [SerializeField] 
    private GameObject optionMenu;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && paused == false)
        {
           MenuActivity();
            
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && paused)
        {
           MenuActivity();
        }
        
    }

    public void MenuActivity()
    {
        if (paused == false)
        {
            pauseMenu.SetActive(true);
            paused = true;
            onMenuPause.Invoke(0);
        }
        else if (paused)
        {
            
            pauseMenu.SetActive(false);
            paused = false;
            onMenuPause.Invoke(1);
            OnOptionMenu(false);
        }
    }

    public void OnOptionMenu(bool activity)
    {
        if (activity)
        {
            mainPauseScreen.SetActive(false);
            optionMenu.SetActive(true);
        }
        else if (activity == false)
        {
            mainPauseScreen.SetActive(true);
            optionMenu.SetActive(false);
        }
    }
    public void PauseTime(int timeflow)
    {
        print("freeze");
        Time.timeScale = timeflow;
    }
}
