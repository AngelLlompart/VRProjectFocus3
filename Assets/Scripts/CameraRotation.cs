using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraRotation : MonoBehaviour
{
    [SerializeField] private InputActionAsset actionAsset;
    [SerializeField] private InputActionReference headRotation;
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
    }
}
