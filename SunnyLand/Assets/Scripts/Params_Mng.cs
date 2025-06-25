using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.UI;

public class Coletavel : MonoBehaviour
{
    //DECLARAÇÕES
    public int HP = 5;
    public int pontos = 0;
    public bool dead = false;

    public SpriteRenderer sprite;
    public float tempo = 0.17f;

    public TMP_Text Health;
    public TMP_Text Coins;

    // MÉTODOS

    public void AddPoints(int quantidade) {
        Health.text = HP.ToString();
        Coins.text = pontos.ToString();
    }
    public void RemoveLife()
    {
        if (HP <= 0) {
            HP = 0;
            return;
        }
        HP--;
        Health.text = HP.ToString();
        StartCoroutine(piscar());
    }

    public void Heal()
    {
        if(HP == 5) return;
        HP++;
        Health.text = HP.ToString();
    }
    public void UpdateHUD()
    {
        Health.text = HP.ToString();
        Coins.text = pontos.ToString();
    }

    public void setValue()
    {
        Health = Health.GetComponent<TMP_Text>();
        Coins = Coins.GetComponent<TMP_Text>();
        Health.text = HP.ToString();
        Coins.text = pontos.ToString();
    }

    public void GameOver()
    {
        if (HP <= 0)
        {
            dead = true;
            if (dead)
            {
                Debug.Log("GameOver");
            }
        }
    }
    IEnumerator piscar()
    {
        sprite.color = Color.red;
        yield return new WaitForSeconds(tempo);
        sprite.color = Color.white;
    }
    // Start is called before the first frame update
    void Start()
    {
        setValue();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateHUD();
        if (HP == 0) GameOver();
    }
}
