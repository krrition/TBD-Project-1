using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RNG : MonoBehaviour
{
    public int x, y, b;
    public GameObject X, Y;

    public Sprite[] numsprites;

    // Start is called before the first frame update
    void Start()
    {
        x = Random.Range(1, 9);
        y = Random.Range(1, 9);
        b = x + y;
        Debug.Log(x +"+"+ y + "=" + b);
        X.GetComponent<SpriteRenderer>().sprite = numsprites[x];
        Y.GetComponent<SpriteRenderer>().sprite = numsprites[y];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
