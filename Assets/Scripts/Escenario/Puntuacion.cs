using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour
{
    [SerializeField]
    Transform Player;
    [SerializeField] Text Punt;
    private float myPositionY;
    public float Distancia;
    public float Intersecciones;

    void Start()
    {
        Player = GameObject.Find("Player").transform;
        myPositionY = transform.position.y;
    }

    void Update()
    {
        Distancia = (myPositionY + Player.position.y - 2) / Intersecciones;
        Punt.text = Distancia.ToString("0");
    }
}