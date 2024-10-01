using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public bool locked;
    public bool keyPickedUp;

    private Animator anim;

    [SerializeField] GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        locked = true;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(player.transform.position, transform.position);

        if (!locked && distance < 0.5f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex * 1);
        }

        if (locked)
        {
            anim.SetTrigger("Idle");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Key") && keyPickedUp)
        {
            anim.SetTrigger("Open");
            locked = false;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Key") && keyPickedUp)
        {
            anim.SetTrigger("Close");
            locked = true;
        }
    }
}
