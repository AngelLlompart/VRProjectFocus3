using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public AudioSource music;
    private TextMeshProUGUI txtScore;
    private List<GameObject> _bottles;
    private List<GameObject> _cans;
    private int _score = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        txtScore = GameObject.Find("ScoreText").GetComponent<TextMeshProUGUI>();
        _bottles = new List<GameObject>(GameObject.FindGameObjectsWithTag("Bottle"));
        _cans = new List<GameObject>(GameObject.FindGameObjectsWithTag("Can"));
        music.Play();
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
            txtScore.text = "Score: " + _score;
        }
        else if (_cans.Contains(go))
        {
            _score += 20;
            _cans.Remove(go);
            txtScore.text = "Score: " + _score;
        }
    }
}
