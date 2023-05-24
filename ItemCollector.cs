using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int crystals = 0;
    [SerializeField] private AudioSource collectionSoundEffect;

    [SerializeField] private Text crystalText;

    private void OnTriggerEnter2D(Collider2D collison)
    {
        if(collison.gameObject.CompareTag("crystal"))
        {
            collectionSoundEffect.Play();
            Destroy(collison.gameObject);
            crystals++;
            crystalText.text = "Crystals: " + crystals;
            
            Debug.Log(crystals);
        }

    }
    
}
