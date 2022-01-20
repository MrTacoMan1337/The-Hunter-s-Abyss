using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int health = 100; //creates health variable for player and sets health to 100
    public Slider healthBar;// creates slider variable "healthBar"
    private bool hasKey;
    public AudioSource collectKey;

    public GameObject playerBody;

    public GameObject bloodSplat;
    public AudioSource hitSound;

    private bool doorOpen;
    public GameObject door;
    public AudioSource lockedDoor;
    public AudioSource OpenedDoor;

    public GameObject wallTorh;
    public GameObject handTorch;
    public AudioSource fire;



    //public GameObject sword;


    // Start is called before the first frame update
    void Start()
    {
        handTorch.SetActive(false);
        health = 100;
        hasKey = false;
        doorOpen = false;
        //bloodSplat.GetComponent<Animator>().SetInteger("Hit", 0);
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = health;

        if (health == 60)
        {
            playerBody.GetComponent<Rigidbody>().mass = 15;
            bloodSplat.SetActive(true);
            bloodSplat.GetComponent<Animator>().SetInteger("Hit", 1);
            
        }

        

        if (health == 20)
        {
            playerBody.GetComponent<Rigidbody>().mass = 30;
            bloodSplat.GetComponent<Animator>().SetInteger("Hit", 2);
            
        }

        if (health <= 0)
        {
            SceneManager.LoadScene(1); //Restart the level
        }

        /*if (Input.GetMouseButtonDown(0))
        {
            sword.GetComponent<Animator>().SetBool("Swing", true);
            
        }
        if (Input.GetMouseButtonUp(0))
        {
            sword.GetComponent<Animator>().SetBool("Swing", false);
        }*/

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Sword") // if player touches sword, play hitSound, deduct 40 helath, and destroy sword
        {
            hitSound.Play();
            health -= 40;
            Destroy(other.gameObject);
        }

        if (other.tag == "Door") // if player touches door
        {
            if (hasKey)
            {
                OpenedDoor.Play();
                door.GetComponent<Animator>().SetTrigger("OpenDoor"); //do trigger animation on door called "OpenDoor"
                hasKey = false;
                doorOpen = true;
            }

            else if (doorOpen == false)
            {
                lockedDoor.Play();
            }
            
        }

        if (other.tag == "Key") // if player touches key
        {
            
            Destroy(other.gameObject);
            collectKey.Play();
            hasKey = true;
        }

        if (other.tag == "WallTorch")
        {
            fire.Play();
            handTorch.SetActive(true);
            Destroy(other.gameObject);
        }
    }

    

    
}
