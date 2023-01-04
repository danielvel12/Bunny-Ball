using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public string gameInstructions = "Move the player using the WASD keys";



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameInstructions); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

