using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpiritDialogue : MonoBehaviour
{

    public List<string> speech;

    public Text dialogueBox;
    public GameObject pressE;
    public int index = 0;
    bool inZone = false;
    private int num;
    //bool isStarted = false;
    void Update()
    {
        num = speech.Count;
        if (Input.GetKeyDown(KeyCode.E))
        {
            index += 1;
            if (index >= num)
            {
                index = 0;
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            inZone = true;
            pressE.SetActive(true);
            displayText();

            /*if (isStarted == false)
            {
                StartCoroutine(ActionWait());

            }*/
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            inZone = false;
            pressE.SetActive(false);
            clearText();
            //StopCoroutine(ActionWait());
        }
    }

    /*IEnumerator ActionWait()
    {
        isStarted = true;
        while (inZone)
        {
            displayText();
            yield return new WaitForSeconds(4);
            clearText();
            yield return new WaitForSeconds(3);
        }


    }*/

    void displayText()
    {
        dialogueBox.text = speech[index];
    }
    void clearText()
    {
        dialogueBox.text = "";
    }
}
