using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitPoints : MonoBehaviour
{
    public Slider slider;
    public int maxHitPoints;
    int hitPoints;

    void Start()
    {
        hitPoints = maxHitPoints;
    }

    void Update()
    {
        slider.maxValue = maxHitPoints;
        slider.value = hitPoints;
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Damage"))
        {
            hitPoints -= 1;
        }
    }
}
