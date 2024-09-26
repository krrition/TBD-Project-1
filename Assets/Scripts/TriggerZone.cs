using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    //Spublic float hoverForce;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Object has entered the trigger");
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("Object is in the trigger");
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Object has exited the trigger");
    }
}
