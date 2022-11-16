using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartHit : MonoBehaviour
{
    private GameController _gameController;

    private void Start()
    {
        _gameController = GameObject.FindObjectOfType<GameController>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        _gameController.TargetHit(collision.gameObject);    
    }
}
