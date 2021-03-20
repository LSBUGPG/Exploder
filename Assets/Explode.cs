using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    ParticleSystem particle;

    void Start()
    {
        particle = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        if (!particle.isPlaying)
        {
            Destroy(gameObject);
        }
    }
}
