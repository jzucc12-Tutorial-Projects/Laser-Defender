using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    GameSession myGameSession;
    Text scoreDisplay;

    // Start is called before the first frame update
    void Start()
    {
        myGameSession = FindObjectOfType<GameSession>();
        scoreDisplay = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreDisplay.text = myGameSession.GetScore().ToString();
    }
}
