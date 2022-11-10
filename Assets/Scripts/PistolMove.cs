using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PistolMove : MonoBehaviour
{
    [SerializeField] private InputActionAsset actionAsset;
    [SerializeField] private InputActionReference controllerRPosition;
    [SerializeField] private InputActionReference controllerRRotation;
    [SerializeField] private Transform cameraPosition;
    
    private void OnEnable() 
    {
        if (actionAsset != null) 
        {
            actionAsset.Enable(); 
        } 
    } 
    
    void Update()
    {
        Vector3 controllerPosition = controllerRPosition.action.ReadValue<Vector3>();
        transform.position = new Vector3(cameraPosition.position.x + controllerPosition.x, controllerPosition.y + 0.5f, cameraPosition.position.z + controllerPosition.z);
        
        Quaternion rotate = controllerRRotation.action.ReadValue<Quaternion>();
        transform.rotation = rotate;
    }
}
