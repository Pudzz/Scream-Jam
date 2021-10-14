using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KeyGetPast : MonoBehaviour
{
    public string keyName; 
    PlayerKeyItems playerItems = null;
    public PlayerKeyItems playerkeys;

    void Start()
    {
     
    }

    void Update()
    {
        
        if(Input.GetKey(KeyCode.R))
        {
            for(int i = 0; i < playerItems.keyNames.Count; i++)
            {
                if(keyName == playerItems.keyNames[i])
                {
                    Debug.Log("YAY");
                }
            }
        }
    }
}
