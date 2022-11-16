using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private List<GameObject> _bottles;
    private List<GameObject> _cans;
    private int _score = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        _bottles = new List<GameObject>(GameObject.FindGameObjectsWithTag("Bottle"));
        _cans = new List<GameObject>(GameObject.FindGameObjectsWithTag("Can"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TargetHit(GameObject go)
    {
        if (_bottles.Contains(go))
        {
            _score += 10;
            _bottles.Remove(go);
            Debug.Log(_score);
        }
        else if (_cans.Contains(go))
        {
            _score += 20;
            _cans.Remove(go);
            Debug.Log(_score);
        }
    }
}
