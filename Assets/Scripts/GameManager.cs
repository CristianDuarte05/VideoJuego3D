using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instancia;

    [Header("Niveles")]
    public GameObject nivel1;
    public GameObject nivel2;
    public GameObject nivel3;

    [Header("Spawns")]
    public Transform spawnNivel1;
    public Transform spawnNivel2;
    public Transform spawnNivel3;

    [Header("Jugador")]
    public GameObject jugador;

    [Header("Datos de juego")]
    public int monedas = 0;
    public int nivelActual = 1;

    [Header("UI")]
    public TextMeshProUGUI textoMonedas;
    public TextMeshProUGUI textoNivel;
    public TextMeshProUGUI textoFinal;   // 👈 TEXTO FINAL

    void Awake()
    {
        instancia = this;
    }

    void Start()
    {
        if (textoFinal != null)
            textoFinal.gameObject.SetActive(false); // oculto al inicio

        ActualizarUI();
        ActivarNivel(1);
    }

    // 🔥 ESTE MÉTODO SE LLAMA DESDE LA MONEDA
    public void SumarMoneda()
    {
        monedas++;
        ActualizarUI();

        if (nivelActual == 1 && monedas >= 5)
        {
            ActivarNivel(2);
        }
        else if (nivelActual == 2 && monedas >= 10)
        {
            ActivarNivel(3);
        }
        else if (nivelActual == 3 && monedas >= 15)
        {
            FinalJuego();
        }
    }

    void ActivarNivel(int nuevoNivel)
    {
        // Apagar todos los niveles
        nivel1.SetActive(false);
        nivel2.SetActive(false);
        nivel3.SetActive(false);

        // Activar nivel correspondiente y mover jugador
        if (nuevoNivel == 1)
        {
            nivel1.SetActive(true);
            jugador.transform.position = spawnNivel1.position;
        }
        else if (nuevoNivel == 2)
        {
            nivel2.SetActive(true);
            jugador.transform.position = spawnNivel2.position;
        }
        else if (nuevoNivel == 3)
        {
            nivel3.SetActive(true);
            jugador.transform.position = spawnNivel3.position;
        }

        nivelActual = nuevoNivel;
        ActualizarUI();
    }

    void ActualizarUI()
    {
        if (textoMonedas != null)
            textoMonedas.text = "Monedas: " + monedas;

        if (textoNivel != null)
            textoNivel.text = "Nivel: " + nivelActual;
    }

    void FinalJuego()
    {
        if (textoFinal != null)
        {
            textoFinal.text = "¡JUEGO FINALIZADO!\nMonedas: " + monedas;
            textoFinal.gameObject.SetActive(true);
        }

        Debug.Log("Juego finalizado");
        Time.timeScale = 0f;
    }
}
