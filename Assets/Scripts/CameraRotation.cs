using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraRotation : MonoBehaviour
{
    [SerializeField] private InputActionAsset actionAsset;
    [SerializeField] private InputActionReference headRotation;
    [SerializeField] private GameObject player;
    private void OnEnable() 
    {
        if (actionAsset != null) 
        {
            actionAsset.Enable(); 
        } 
    } 
    
    void Update()
    {
        Quaternion rotate = headRotation.action.ReadValue<Quaternion>();
        transform.rotation = rotate;
        rotate.z = 0;
        rotate.x = 0;
        player.transform.rotation = rotate;
        //player.transform.localEulerAngles = new Vector3(0.0f, rotate.y, 0.0f);
    }
}
