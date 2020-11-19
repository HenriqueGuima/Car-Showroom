using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayShowroom(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlaySports(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void QuitGame() {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void Back(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);

    }

    public void Back2(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -3);

    }

    public void Back3(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -4);

    }
}
