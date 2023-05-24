using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    [SerializeField] private float healthValue;

    private void OnTriggerEnter2D(Collider2D collision){
        collision.GetComponent<Health>().AddHealth(healthValue);
        gameObject.SetActive(false);
    }

}
