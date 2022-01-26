using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    private void Start()
    {
        
    }

    // Start is called before the first frame update
   public void BackStartScene()
    {
        SceneManager.LoadScene("Scenes/Start", LoadSceneMode.Single);
    }

   public void RestartMain()
    {
        Debug.Log("ren");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
