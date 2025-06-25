using System.Collections;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public Coletavel ColetavelReference;
    private bool coletado = false;
    public ParticleSystem particle;
    public PlayerMovement playerMovement;



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !coletado)
        {
            coletado = true;

            if (gameObject.CompareTag("Coin"))
            {
                ColetavelReference.pontos++;
                Instantiate(particle, transform.position, Quaternion.identity);
                Destroy(gameObject);

            }
            else if (gameObject.CompareTag("Heal"))
            {
                ColetavelReference.Heal();
                Instantiate(particle, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
            else if (gameObject.CompareTag("Thorn"))
            {
                ColetavelReference.RemoveLife();
                Instantiate(particle, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
            else if (gameObject.CompareTag("Power"))
            {
                playerMovement.runSpeed = 60f;
                Destroy(gameObject);
            }
        }
    }
}