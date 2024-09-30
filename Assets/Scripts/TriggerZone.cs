using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    public bool check;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("X") || other.gameObject.CompareTag("Y"))
        {
            Debug.Log("Object has entered the trigger");
            check = true;
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("X") || other.gameObject.CompareTag("Y"))
        {
            Debug.Log("Object is in the trigger");
            check = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("X") || other.gameObject.CompareTag("Y"))
        {
            Debug.Log("Object has exited the trigger");
            check = false;
        }
    }
}
