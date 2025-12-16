using UnityEngine;
using TMPro;

public class Temporizador : MonoBehaviour
{
    public TextMeshProUGUI textoTiempo;
    private float tiempo;

    void Update()
    {
        tiempo += Time.deltaTime;
        textoTiempo.text = "Tiempo: " + tiempo.ToString("F1");
    }
}
