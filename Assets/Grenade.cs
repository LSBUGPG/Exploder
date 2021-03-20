using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    public float fuse = 1.0f;
    public Transform explosionPrefab;

    void Start()
    {
        Invoke("Explode", fuse);
    }

    void Explode()
    {
        Transform explosion = Instantiate(explosionPrefab);
        explosion.position = transform.position;
        Destroy(gameObject);
    }
}
