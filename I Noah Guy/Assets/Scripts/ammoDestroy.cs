using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammoDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    public int ChickenNum = 0;
    public int CowNum = 0;
    public int PigNum = 0;
    public int SheepNum = 0;
    public int scores = 0;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Cow"))
        {
            scores++;
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Chicken"))
        {
            scores++;
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Sheep"))
        {
            scores++;
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Pig"))
        {
            scores++;
            Destroy(gameObject);
        }
    }
}
