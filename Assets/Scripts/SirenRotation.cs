using UnityEngine;

// Hace girar el pivote de las sirenas; las luces hijas (roja y azul) giran con él.
public class SirenRotation : MonoBehaviour
{
    // Velocidad de giro en grados por segundo, ajustable desde el Inspector
    public float rotationSpeed = 270f;

    void Update()
    {
        // Time.deltaTime hace que el giro sea igual sin importar los FPS
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}
