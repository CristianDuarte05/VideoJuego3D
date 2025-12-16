using UnityEngine;

public class CamaraController : MonoBehaviour
{
    public Transform jugador;
    private Vector3 offset;

    void Start()
    {
        // Distancia entre cámara y jugador
        offset = transform.position - jugador.position;
    }

    void LateUpdate()
    {
        // La cámara sigue al jugador manteniendo la distancia
        transform.position = jugador.position + offset;
    }
}
