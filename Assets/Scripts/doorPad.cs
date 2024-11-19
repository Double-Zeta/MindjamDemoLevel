using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class doorPad : MonoBehaviour
{
    public GameObject player;
    public GameObject keypadOBJ;
    public GameObject Door;

    public TMP_Text textOBJ;
    public string answer = "12345";
    // Start is called before the first frame update
    void Start()
    {
        keypadOBJ.SetActive(false);
    }

    public void Number(int number)
    {
        textOBJ.text += number.ToString();
    }

    public void Execute()
    {
        if(textOBJ.text == answer)
        {
            textOBJ.text = "Right";
        }
        else
        {
            textOBJ.text = "Wrong";
        }
    }

    public void Clear()
    {
        textOBJ.text = "";

    }
    
    public void Exit()
    {
        keypadOBJ.SetActive(false);
        player.GetComponent<FirstPersonController>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(textOBJ.text == "Right")
        {
            Door.transform.position += new Vector3(0, 4, 0);
            
        }

        if(keypadOBJ.activeInHierarchy)
        {
            player.GetComponent<FirstPersonController>().enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
