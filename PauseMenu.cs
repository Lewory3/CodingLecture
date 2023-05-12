using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false; //false is state in which game starts
    public GameObject pausemenuUI;


    void Update() {

        if (Input.GetKeyDown(KeyCode.Escape)) {

            if (GameIsPaused) {

                Resume();
            
            }else {

                Pause();
            
            }
        
        }

        //checks whenever Esc is pressed and calls function based on the state of the bool

    }

    void Pause() {

        pausemenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    
    }

    public void Resume() {

        pausemenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

        //sets bool again to activate if, resume the passing of time which gets disabled in pause to avoid game to continue when UI is active


    }

    public void QuitGame() {

        Application.Quit();

    }

    public void MainMenu() {

        //loads main menu scene in the build based on the index it has in the build
        SceneManager.LoadScene("0");

    }

}
