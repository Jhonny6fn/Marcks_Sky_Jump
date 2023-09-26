using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    [SerializeField]
    Transform Player;
    private GameObject Jugador;

    public GameObject La_Moneda;
    int Prob_Moneda;

    public float direccion;
    public float limiteder;
    public float limiteizq;
    public float speed;
    private float mypositioninitialx;
    public bool Moverse;
    public bool RotarPlataforma;
    public bool Romperse;
    private Animator myAnim;

    void Start()
    {
        Player = GameObject.Find("Player").transform;
        Jugador = GameObject.Find("Player");
        myAnim = GetComponent<Animator>();
        mypositioninitialx = transform.position.x;
        direccion = 1f;
        Prob_Moneda = Random.Range(1, 4);
        if (Prob_Moneda == 3)
        {
            La_Moneda.SetActive(true);
        }
    }

    void Update()
    {
        if (Moverse == true)
        {
            transform.Translate(new Vector3(direccion, 0, 0) * Time.deltaTime * speed, Space.World);

            if (transform.position.x > limiteder)
            {
                direccion = -1f;
                if (RotarPlataforma == true)
                {
                    transform.eulerAngles = new Vector3(0, 180, 0);
                }
            }

            if (transform.position.x < limiteizq)
            {
                direccion = 1f;
                if (RotarPlataforma == true)
                {
                    transform.eulerAngles = new Vector3(0, 0, 0);
                }
            }
        }

        if (Player.transform.position.y > transform.position.y + 8f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && Jugador.GetComponent<Rigidbody2D>().velocity.y == 0 && Romperse == true)
        {
            myAnim.SetTrigger("Destruir");
        }
    }

    public void Destruccion()
    {
        Destroy(gameObject);
    }
}