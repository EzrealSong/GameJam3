using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public bool gameplay = false;
    //public GameObject GameEndCanvas;
    //public Text result;
    
  

    public void GameOver()
    {
        if (gameplay == false)
        {
           // GameEndCanvas.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("GameOver");
        }
    }    

}
