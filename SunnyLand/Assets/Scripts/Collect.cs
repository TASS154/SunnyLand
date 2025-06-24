using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    Coletavel ColetavelReference;
    private void Trigger(Collider2D other) {
        if (other.CompareTag("Player"))
        {
            if (other.gameObject.CompareTag("Coin"))
            {
                ColetavelReference.pontos++;
            }
            else if (other.gameObject.CompareTag("Heal")){
                ColetavelReference.HP++;
            }
            else if (other.gameObject.CompareTag("Thorn")) 
                {
                    ColetavelReference.HP--;
                }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Trigger(collision);
    }
}
