using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartAR : MonoBehaviour{

    

    public void kemainmenu()
    {
        SceneManager.LoadScene(0);
    }

    public void MasukAR()
    {
        SceneManager.LoadScene(1);
    }

    public void MasukGame()
    {
        SceneManager.LoadScene(2);
    }
    public void MasukInformasi()
    {
        SceneManager.LoadScene(3);
    }

    public void QuitGame()
    {
        Debug.Log("quit!");
        Application.Quit();
    }

      public void OpenURL()
      {
          Application.OpenURL("https://drive.google.com/uc?export=download&id=1vtpxi6AGqByHw3wOOhkzXpPkQqRGDAyy");
          Debug.Log("is this working?");
      }
}
