using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))//if the Escape button is pressed
        {
            Destroy(GameObject.FindGameObjectWithTag("GameManager")); //Destroys the GameObject with tag "GameManager" So that when you click on menu it doesn's have two GameManager objects

            
            SceneManager.LoadScene(0); //Loads very first scene
            
        }

        if (Input.GetKeyDown(KeyCode.R))//if the Escape button is pressed
        {
            SceneManager.LoadScene(1); //Loads very first scene
        }

    }

    public void StartButton() //Makes function "StartButton()"
    {
        SceneManager.LoadScene(1); //Goes to the next scene
    }

    public void ExitGame() //Makes function "ExitGame()"
    {
        Application.Quit(); //Quits the game
    }

    

}
