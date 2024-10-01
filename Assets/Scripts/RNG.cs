using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class RNG : MonoBehaviour
{
    public int x, y, z, b;
    public GameObject X, Y, Z, B;

    public Sprite[] numsprites;
    public GameObject plate1, plate2, key;

    // Start is called before the first frame update
    void Start()
    {
        x = Random.Range(1, 9);
        y = Random.Range(1, 9);
        z = Random.Range(1, 9);
        b = x + y;
        Debug.Log(x +"+"+ y + "=" + b);
        X.GetComponent<SpriteRenderer>().sprite = numsprites[x];
        Y.GetComponent<SpriteRenderer>().sprite = numsprites[y];
        Z.GetComponent<SpriteRenderer>().sprite = numsprites[z];
        B.GetComponent<TextMeshPro>().text = b.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (plate1.GetComponent<TriggerZone>().check == true && plate2.GetComponent<TriggerZone>().check == true)
        {
            Debug.Log("Complete");
            key.gameObject.SetActive(true);
            
        }
    }
}
