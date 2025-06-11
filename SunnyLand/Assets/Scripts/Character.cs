using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    private bool Alive = true;
    public int health = 0;
    private string name = "Cleitin da manga";
    private float speed = 25.7f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(name + ", " + Alive + ", " + health + ", " + speed);
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = -0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
