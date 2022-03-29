using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public bool gameplay = false;
    public GameObject GameEndCanvas;

  

    public void GameOver()
    {
        if (gameplay == false)
        {
            GameEndCanvas.SetActive(true);
        }
    }    
}
