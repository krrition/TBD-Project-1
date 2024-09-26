using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RNG : MonoBehaviour
{
    public int x, y, b;
    public GameObject X, Y;

    // Start is called before the first frame update
    void Start()
    {
        x = Random.Range(1, 9);
        y = Random.Range(1, 9);
        b = x + y;
        Debug.Log(x +"+"+ y + "=" + b);       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
