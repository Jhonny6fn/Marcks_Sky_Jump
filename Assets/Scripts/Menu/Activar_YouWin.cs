using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activar_YouWin : MonoBehaviour
{
    public GameObject YouWin;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Cursor.lockState = CursorLockMode.None;
            YouWin.SetActive(true);
            Time.timeScale = 0;
        }
    }
}