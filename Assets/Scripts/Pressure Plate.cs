using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PressurePlate : MonoBehaviour
{
    public UnityEvent OnActivate;
    public UnityEvent OnDeactivate;

    int numbersInContact;

    public void OnTriggerEnter2D(Collider2D other)
    {
        numbersInContact++;
        if (numbersInContact == 1 && OnActivate != null) OnActivate.Invoke();
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        numbersInContact--;
        if (numbersInContact == 0 && OnDeactivate != null) OnDeactivate.Invoke();
    }
}
