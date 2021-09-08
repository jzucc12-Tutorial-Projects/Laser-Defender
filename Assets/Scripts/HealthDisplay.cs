using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    Player myPlayer;
    Text healthDisplay;

    // Start is called before the first frame update
    void Start()
    {
        myPlayer = FindObjectOfType<Player>();
        healthDisplay = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        healthDisplay.text = myPlayer.GetHealth().ToString();
    }
}
