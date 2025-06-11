using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletavel : MonoBehaviour
{

    private int pontos = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("O jogo começou, você tem " + pontos + " pontos");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("1 Frame se passou");
    }
}
