using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_Damage : MonoBehaviour
{
    public float vidaJugador = 100;
    
    public Image barradeVida;

    void Update()
    {
        vidaJugador = Mathf.Clamp(vidaJugador, 0, 100);

        barradeVida.fillAmount = vidaJugador / 100;

    }
}
