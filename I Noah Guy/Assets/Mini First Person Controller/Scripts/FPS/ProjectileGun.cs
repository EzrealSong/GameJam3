using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileGun : MonoBehaviour
{
    [SerializeField] private Transform gunBarrel;
    [SerializeField] private GameObject ammo;
    [SerializeField] private float power = 3.0f;
    [SerializeField] private float fireRate = 10.0f;
    [SerializeField] private float timer;
    private float shotDelay;
    private bool canShoot = true;
    // Start is called before the first frame update
    void Start()
    {
        shotDelay = 1.0f / fireRate; //bullets per second
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= shotDelay)
        {
            canShoot = true;
            
        }
        if (canShoot)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                GameObject bullet = Instantiate(ammo, gunBarrel.position, Quaternion.identity);
                bullet.GetComponent<Rigidbody>().AddForce(gunBarrel.forward * power, ForceMode.Impulse);
                canShoot = false;
                timer = 0.0f;
            }
        }
    }
}
