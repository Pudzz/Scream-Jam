using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    PlayerController playercontroller;

    [SerializeField] float health;
    [SerializeField] float stamina;
    [SerializeField] float food;
    [SerializeField] float drink;

    public bool cantRun = false;

    // Start is called before the first frame update
    void Start()
    {
        playercontroller = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playercontroller.isRunning)
        {
            if ((stamina - 0.1f) < 0.0f)
            {
                stamina = 0.0f;
                if (!cantRun)
                    cantRun = true;
            }
            else
            {
                stamina -= 0.1f;
                if (cantRun)
                    cantRun = false;
            }
        }
        else
        {
            if(stamina < 100.0f)
            {
                if ((stamina + 0.025f) > 100.0f)
                {
                    stamina = 100.0f;
                    if (cantRun)
                        cantRun = false;
                }
                else
                {
                    stamina += 0.025f;
                    if (cantRun)
                        cantRun = false;
                }
            }
        }

        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 1000))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (hit.rigidbody.CompareTag("Health"))
                {
                    if(health+10.0f > 100.0f)
                    {
                        health = 100.0f;
                    }
                    else
                    {
                        health += 10.0f;
                    }
                }
            }
        }

    }
}
