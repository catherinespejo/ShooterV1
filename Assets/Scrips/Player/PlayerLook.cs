using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera cam;
    private float xRotation = 0f;

    public float xSensitivity = 30f;
    public float ySensitivity = 30f;

    public void ProcessLook(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;

        //Calcular la rotacion
        xRotation -= (mouseY * Time.deltaTime) * ySensitivity;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);
        //se aplica a la camara
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        //se aplaca al player
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSensitivity); 
    }
}
