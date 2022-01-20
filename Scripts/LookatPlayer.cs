using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookatPlayer : MonoBehaviour
{
    public GameObject player;
    public float distance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < distance) //if player distance is less that 'aggroRange' and health is more than 0
        {
            transform.LookAt(player.transform.position); //enemy looks at player
        }
    }
}
