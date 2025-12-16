using UnityEngine;

public class RotarMoneda : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(
            90f * Time.deltaTime,   // X
            120f * Time.deltaTime,  // Y
            60f * Time.deltaTime    // Z
        );
    }
}
