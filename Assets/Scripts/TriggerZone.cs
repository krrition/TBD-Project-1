using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    public bool check;

    private AudioSource AS;

    private void Start()
    {
        AS = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("X") || other.gameObject.CompareTag("Y")) 
        {
            check = true;
            AS.Play();
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("X") || other.gameObject.CompareTag("Y"))
        {
            check = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("X") || other.gameObject.CompareTag("Y"))
        {
            check = false;
        }
    }
}
