using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishedgame : MonoBehaviour
{

    public void playgame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void QuitGame() {

        Application.Quit();
    }// Start is called before the first frame update
}