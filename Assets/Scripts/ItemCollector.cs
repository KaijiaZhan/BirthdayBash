using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int cakes = 0;

    [SerializeField] private Text cakeText;

    [SerializeField] private AudioSource collectionSoundEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cake"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            cakes++;
            cakeText.text = "Cakes: " + cakes;
        }
    }
}
