using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instancia;

    public AudioSource musica;
    public AudioSource efectos;

    public AudioClip sonidoMoneda;
    public AudioClip musicaFinal;

    void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ReproducirMoneda()
    {
        efectos.PlayOneShot(sonidoMoneda);
    }

    public void CambiarMusicaFinal()
    {
        musica.clip = musicaFinal;
        musica.Play();
    }
}
