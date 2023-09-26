using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limite : MonoBehaviour
{
    public GameObject Player;
    public float Limite_Salida;
    float Ypos;

    private void Update()
    {
        Ypos = Player.transform.position.y;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Player.transform.position = new Vector2(Limite_Salida, Ypos);
        }
    }
}