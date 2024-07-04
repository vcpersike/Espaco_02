using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveAcceleration : MonoBehaviour
{
    public float boostMultiplier = 2f; // Multiplicador de velocidade para a acelera��o

    public float ApplyBoost(float currentSpeed)
    {
        // Verificar se a tecla espa�o est� pressionada
        if (Input.GetKey(KeyCode.Space))
        {
            return currentSpeed * boostMultiplier;
        }
        return currentSpeed;
    }
}
