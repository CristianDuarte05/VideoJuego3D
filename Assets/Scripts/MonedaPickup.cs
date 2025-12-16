using UnityEngine;

public class MonedaPickup : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Jugador"))
        {
            AudioManager.instancia.ReproducirMoneda();
            GameManager.instancia.SumarMoneda();
            Destroy(gameObject);
        }
    }
}
