using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GunShoot : MonoBehaviour
{
    [SerializeField] private InputActionAsset actionAsset;
    [SerializeField] private InputActionReference controllerRTrigger;
    
    
    public float sensitivity = 5.0f;
    public GameObject bullet;
    public GameObject bulletSpawner;
    public float bulletSpeed = 10.0f;
    private void OnEnable() 
    {
        if (actionAsset != null) 
        {
            actionAsset.Enable(); 
        } 
    } 
    
    void Update()
    {
        if (controllerRTrigger.action.WasPressedThisFrame())
        {
            Shoot();
        }
    }
    
    private void Shoot()
    {
        GameObject newBullet = Instantiate(bullet, bulletSpawner.transform.position, transform.rotation);
        //newBullet.transform.position = transform.position;
        //newBullet.transform.rotation = transform.rotation;

        newBullet.GetComponent<Rigidbody>().velocity = newBullet.transform.forward * bulletSpeed; //* Time.deltaTime;
    }
}
