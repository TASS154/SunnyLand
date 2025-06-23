using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Coletavel : MonoBehaviour
{
    //DECLARAÇÕES
    public int HP = 5;
    public int pontos = 0;

    public TMP_Text Health;
    public TMP_Text Coins;

    public Button Button;

    // MÉTODOS

    public void AddPoints(int quantidade) {
        Health.text = HP.ToString();
        Coins.text = pontos.ToString();
    }
    public void RemoveLife()
    {
        HP--;
        Health.text = HP.ToString();
    }
    public void Heal()
    {
        HP++;
        Health.text = HP.ToString();
    }
    public void UpdateHUD()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        Health = Health.GetComponent<TMP_Text>();
        Coins = Coins.GetComponent<TMP_Text>();
        Health.text = HP.ToString();
        Coins.text = pontos.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Health.text = HP.ToString();
        Coins.text = pontos.ToString();
    }
}
