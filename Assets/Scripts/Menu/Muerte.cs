using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muerte : MonoBehaviour
{
    public GameObject GameOver;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Cursor.lockState = CursorLockMode.None;
            GameOver.SetActive(true);
            Time.timeScale = 0;
        }
    }
}