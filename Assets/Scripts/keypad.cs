using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keypad : MonoBehaviour
{
    public GameObject keycode, numtext, incorrecttext, correcttext;
    public GameObject door;
    public Text numTex;
    public string codeString, correctCode;
    public int stringCharacters = 0;
    public bool interactable, codeDone, doorActive;
    public Button but1, but2, but3, but4, but5, but6, but7, but8, but9, but0;
    int token = 0;
    public Rigidbody playerRigid;

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("MainCamera"))
        {
            if(codeDone == false) 
            { 
                interactable = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("MainCamera"))
        {
            interactable= false;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                keycode.SetActive(true);
                playerRigid.constraints = RigidbodyConstraints.FreezeAll;
                doorActive = true;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                interactable = false;
            }
        }
        if(doorActive == true)
        {
            if(Input.GetKeyDown(KeyCode.Q))
            {
                numtext.SetActive(true);
                correcttext.SetActive(false);
                incorrecttext.SetActive(false);
                stringCharacters = 0;
                codeString = "";
                but1.interactable = true; 
                but2.interactable = true;
                but3.interactable = true;
                but4.interactable = true;
                doorActive=false;
                but5.interactable = true;
                but6.interactable = true;
                but7.interactable = true;
                token = 0;
                but8.interactable = true;
                but9.interactable = true;
                but0.interactable = true;
                keycode.SetActive(false);
                playerRigid.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationX;
                interactable = false;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
            numTex.text = codeString;
            if(stringCharacters == 4) 
            {
                if(codeString == correctCode)
                {
                    numtext.SetActive(false);
                    correcttext.SetActive(false);
                    but1.interactable = false;
                    but2.interactable = false;
                    but3.interactable = false;
                    but4.interactable = false;
                    but5.interactable = false;
                    but6.interactable = false;
                    but7.interactable = false;
                    but8.interactable = false;
                    but9.interactable = false;
                    but0.interactable = false;
                    codeDone = true;
                    if(token == 0)
                    {
                        door.transform.position += new Vector3(0, 4, 0);
                        token = 1;
                    }
                }
            }
        }
    }
    IEnumerator endSesh()
    {
        yield return new WaitForSeconds(2.5f);
        numtext.SetActive(true);
        correcttext.SetActive(false);
        incorrecttext.SetActive(false);
        stringCharacters = 0;
        codeString = "";
        but1.interactable = true;
        but2.interactable = true;
        but3.interactable = true;
        but4.interactable = true;
        doorActive = false;
        but5.interactable = true;
        but6.interactable = true;
        but7.interactable = true;
        token = 0;
        but8.interactable = true;
        but9.interactable = true;
        but0.interactable = true;
        keycode.SetActive(false);
    }
}
