using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class Counter : MonoBehaviour
{
    // Inicializa tu contador
    public int counter = 10;

    // Referencia al objeto de texto TextMeshPro
    public TextMeshProUGUI counterText;  // Asegúrate de asignar este valor en el Inspector


    public AudioSource clickSound;
    // Start se llama antes del primer frame
    void Start()
    {
        // Inicializa el texto del contador
        counterText.text = "Munición: " + counter.ToString();
    }

    // Update se llama una vez por frame
    void Update()
    {
        // Comprueba si el botón izquierdo del mouse se ha pulsado
        if (Input.GetMouseButtonDown(0))
        {
            // Si se ha pulsado, disminuye el contador
            counter--;
            // Actualiza el texto del contador
            counterText.text = "Contador: " + counter.ToString();

            clickSound.Play();

            // Si el contador llega a cero, termina el juego
            if (counter <= 0)
            {
                Debug.Log("El juego ha terminado"); // Imprime un mensaje en la consola de Unity

                // Cierra la aplicación
                // Nota: Esto no hará nada en el editor de Unity, pero cerrará el juego cuando esté construido
                Application.Quit();
            }
        }
    }
}
