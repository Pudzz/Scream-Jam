using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeyItems : MonoBehaviour
{
    [SerializeField] float raycastRange = 100.0f;

    public bool doorKeyPickedUp = false;
    public bool foodPickedUp = false;

    public Camera fpsCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            if (Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hit, raycastRange))
            {
                if(hit.rigidbody.CompareTag("Key1"))
                {
                    Debug.Log("HIT something");
                    //doorKeyPickedUp = true;
                }
            }
        }
    }
}
