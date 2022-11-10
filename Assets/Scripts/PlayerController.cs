using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private InputActionAsset actionAsset;
    [SerializeField] private InputActionReference joystitckL;
    
    private void OnEnable() 
    {
        if (actionAsset != null) 
        {
            actionAsset.Enable(); 
        } 
    } 
    
    void Update()
    {
        Vector2 move = joystitckL.action.ReadValue<Vector2>();
        transform.Translate(new Vector3(move.x, 0, move.y) * Time.deltaTime);
    }
}
