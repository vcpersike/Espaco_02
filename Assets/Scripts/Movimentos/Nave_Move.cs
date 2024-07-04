using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave_Move : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidade de movimento da nave
    public NaveAcceleration naveAcceleration;

    void Start()
    {
        naveAcceleration = GetComponent<NaveAcceleration>();
    }

    // Update is called once per frame
    void Update()
    {
        // Obter a entrada do teclado
        float moveX = Input.GetAxis("Horizontal"); // Setas esquerda e direita
        float moveY = Input.GetAxis("Vertical");   // Setas para cima e para baixo

        // Calcular o movimento
        float currentSpeed = moveSpeed;
        if (naveAcceleration != null)
        {
            currentSpeed = naveAcceleration.ApplyBoost(currentSpeed);
        }

        Vector2 movement = new Vector2(moveX, moveY) * currentSpeed * Time.deltaTime;

        // Aplicar o movimento
        transform.Translate(movement);
    }
}
