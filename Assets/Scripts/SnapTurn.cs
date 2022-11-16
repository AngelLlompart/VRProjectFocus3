using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SnapTurn : MonoBehaviour
{
    [SerializeField] private InputActionAsset actionAsset;
    
    [SerializeField] private InputActionReference joystitckR;
    [SerializeField] private InputActionReference headRotation;
    [SerializeField] private Camera mainCamera;
    private void OnEnable() 
    {
        if (actionAsset != null) 
        {
            actionAsset.Enable(); 
        } 
    } 
    
    void Update()
    {
        Vector2 move = joystitckR.action.ReadValue<Vector2>();
        if (move.x >= 0.9)
        {
            transform.rotation *= Quaternion.Euler(0, 90, 0);
            mainCamera.transform.rotation *= Quaternion.Euler(0, 90, 0);
           
        }
        else if(move.x <= -0.9)
        {
            transform.rotation *= Quaternion.Euler(0, -90, 0);
            mainCamera.transform.rotation *= Quaternion.Euler(0, -90, 0);
        }
    }
}
