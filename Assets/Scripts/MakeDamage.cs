using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeDamage : MonoBehaviour
{
    public int da�o = 1;
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag =="Player")
        {
            Player.GetComponent<Health_Damage>().vidaJugador -= da�o;
        }

    }
}
