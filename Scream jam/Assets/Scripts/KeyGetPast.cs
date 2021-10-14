using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KeyGetPast : MonoBehaviour
{
    public string keyName; 
    PlayerKeyItems playerItems = null;

    void Start()
    {
        playerItems = GameObject.Find("Player").GetComponent<PlayerKeyItems>();
    }

    void Update()
    {
        
        if(Input.GetKey(KeyCode.R))
        {
            if (keyName == "Key1")
            {
                if (playerItems.doorKeyPickedUp)
                    Debug.Log("YAY");
                else
                    Debug.Log("NAY");
            }
        }
    }
}
