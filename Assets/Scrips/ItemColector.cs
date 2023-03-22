using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemColector : MonoBehaviour
{
    private int cherries = 0;

    [SerializeField] private Text cherriesText;
    [SerializeField] private AudioSource colectionSoundEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Cherry"))
        {
            colectionSoundEffect.Play();
            Destroy(collision.gameObject);
            cherries++;
            cherriesText.text = "Cherries: " + cherries;           
        }
    }
}
