using UnityEngine;

public class Collect : MonoBehaviour
{
    public Coletavel ColetavelReference;
    private bool coletado = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !coletado)
        {
            coletado = true;

            if (gameObject.CompareTag("Coin"))
            {
                ColetavelReference.pontos++;
                Destroy(gameObject);
            }
            else if (gameObject.CompareTag("Heal"))
            {
                ColetavelReference.Heal();
                Destroy(gameObject);
            }
            else if (gameObject.CompareTag("Thorn"))
            {
                ColetavelReference.RemoveLife();
                Destroy(gameObject);
            }
        }
    }
}