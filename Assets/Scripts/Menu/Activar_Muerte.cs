using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activar_Muerte : MonoBehaviour
{
    public GameObject Muerte;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Muerte.SetActive(true);
        }
    }
}