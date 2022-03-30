using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform teleportTarget;
    [SerializeField] private AudioSource ding;
    [SerializeField] private AudioSource teleportNoise;
    private int counter = 0;
    
    void OnTriggerEnter(Collider other)
    {
        if(this.tag == "Chicken") {
            this.transform.position = teleportTarget.transform.position;
            teleportNoise.Play(0);
        } else if (this.tag == "Cow")
        {
            if(counter == 4)
            {
                this.transform.position = teleportTarget.transform.position;
                counter = 0;
                teleportNoise.Play(0);
            }
            else
            {
                counter++;
                ding.Play(0);

            }
        } else if(this.tag == "Pig")
        {
            if(counter == 2)
            {
                this.transform.position = teleportTarget.transform.position;
                counter = 0;
                teleportNoise.Play(0);
            }
            else
            {
                counter++;
                ding.Play(0);

            }
        } else if(this.tag == "Sheep")
        {
            if(counter == 3)
            {
                this.transform.position = teleportTarget.transform.position;
                counter = 0;
                teleportNoise.Play(0);
            }
            else
            {
                counter++;
                ding.Play(0);

            }
        }
        
        
    }
}


//this.transform.position = teleportTarget.transform.position;