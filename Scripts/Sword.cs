using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    private float timer; //creates public float "timer2"
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 10) //if timer is over 10sec
        {
            Destroy(gameObject); //destroys gameobject
        }
    }
}
