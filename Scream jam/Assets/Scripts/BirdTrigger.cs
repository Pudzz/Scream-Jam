using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdTrigger : MonoBehaviour
{
    public ParticleSystem birdsParticle;
    private AudioSource birdSound = null;
    private bool playedOnce = false;

    // Start is called before the first frame update
    void Start()
    {
        birdSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (!playedOnce)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                birdsParticle.Play();
                birdSound.Play();
                playedOnce = true;
            }
        }
    }
}
