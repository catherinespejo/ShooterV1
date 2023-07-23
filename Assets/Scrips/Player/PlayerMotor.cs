using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    public float speed = 5f;
    public bool isGrouded;
    public float gravity = -9.8f;
    public float jumpHeight = 3f;
    public int counter = 10;


    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrouded = controller.isGrounded;

        if (Input.GetMouseButtonDown(0))
        {
            // Si se ha pulsado, disminuye el contador
            counter--;
            Debug.Log("Contador: " + counter); // Muestra el valor del contador en la consola de Unity

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

    public void ProcessMove(Vector2 input)
    { 
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        controller.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);
        playerVelocity.y += gravity * Time.deltaTime;
        if (isGrouded && playerVelocity.y < 0)
            playerVelocity.y = -2f; 
        controller.Move(playerVelocity * Time.deltaTime);
        Debug.Log(playerVelocity.y); 
    }

    public void Jump()
    {
        if (isGrouded)
        {
            playerVelocity.y = Mathf.Sqrt(jumpHeight * -3.0f * gravity);
        }
    }
}
