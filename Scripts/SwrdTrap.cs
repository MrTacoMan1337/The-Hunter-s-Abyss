using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwrdTrap : MonoBehaviour
{
    public GameObject shootSword; //creates public GameObject called shootSword
    public GameObject shootingPoint; //creates public GameObject called shootingPoint
    public AudioSource shootSound; //creates public AudioSource called shootSound

    public float rangeTimer; //creates float variable 'rangeTimer'
    public float coolDown; //creates float variable 'coolDown   
    private bool startTimer;

    public int speed;


    // Start is called before the first frame update
    void Start()
    {
        rangeTimer = 0.1f;
        startTimer = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (startTimer == true)
        {
            rangeTimer -= Time.deltaTime; //couuntdown 

            if (rangeTimer <= 0)// when countDown reaches0 sec
            {
                rangeTimer = coolDown;//coolDown reloads back to rangeTimer
                shootSound.Play(); //play shootSound
                GameObject projectile = Instantiate(Resources.Load("Sword"), shootingPoint.transform.position, transform.rotation) as GameObject; //enemy launches projectile 'Sword' from resources folder
                projectile.GetComponent<Rigidbody>().AddForce(transform.right * speed * 10); //projectile has a forward froce of 50
            }
        }
    }

    private void OnTriggerEnter(Collider other) //creates OnTriggerEnter funcion
    {
        if (other.tag == "Player") // if player is on pressure plate
        {
            startTimer = true;

            transform.position = transform.position + new Vector3(0, -0.05f, 0); //transform postion to y = -0.5

            


        }

    }

    private void OnTriggerExit(Collider other) //creats OnTriggerExit function
    {
        if (other.tag == "Player") //if Player exits the pressure plate
        {
            transform.position = transform.position + new Vector3(0, 0.05f, 0); //transform position back to y = 0.05
            rangeTimer = 0.1f;
            startTimer = false;

        }
    }

}
