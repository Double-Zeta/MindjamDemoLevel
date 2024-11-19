using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScore : MonoBehaviour
{
    KeyCounter keycount;

    // Start is called before the first frame update
    void Start()
    {
        keycount = GameObject.FindGameObjectsWithTag("Key")[0].GetComponent<KeyCounter>();
        keycount.Keycount++;
    }
    void Update()
    {
        Wincon();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Destroy(gameObject);
            keycount.Keycount--;
            //Debug.Log(keycount.Keycount);
        }
    }

    void Wincon()
    {
        if (keycount.Keycount == 1)
        {
            Debug.Log("Congrats you've found all the keys and escaped!!");
        }
    }
}
