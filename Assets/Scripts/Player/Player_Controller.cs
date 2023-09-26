using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Player_Controller : MonoBehaviour
{
    private Rigidbody2D myRigi;
    public float speed;
    private Animator myAnim;
    public float Monedas = 0;
    [SerializeField] Text Num_Monedas;

    private static bool sonidoPlat_B;
    private static bool sonidoPlat_S;
    private static bool sonidoPlat_P;
    private static bool sonidoMoneda;
    private bool OnnOff;
    private AudioSource music;
    public AudioClip Plataforma_Basica;
    public AudioClip Plataforma_Super;
    public AudioClip Plataforma_Parag;
    public AudioClip Moneda;

    public GameObject GO_Paraguas;
    public ParticleSystem Particulas;

    public GameObject Particulas_Moneda;

    private void Awake()
    {
        music = GetComponent<AudioSource>();
        sonidoPlat_B = false;
        sonidoPlat_S = false;
        sonidoPlat_P = false;
        sonidoMoneda = false;
    }

    void Start()
    {
        myRigi = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();
        OnnOff = true;
    }

    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") == 0)
        {
            myRigi.velocity = (new Vector2(0, myRigi.velocity.y));
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            myRigi.velocity += (new Vector2(1 * speed, 0));
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            myRigi.velocity += (new Vector2(-1 * speed, 0));
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        if (myRigi.velocity.y < 0)
        {
            myAnim.SetBool("Abajo", true);
            myAnim.SetBool("Arriba", false);
        }

        if (myRigi.velocity.y > 0)
        {
            myAnim.SetBool("Abajo", false);
            myAnim.SetBool("Arriba", true);
        }

        Num_Monedas.text = Monedas.ToString("0");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Suelo" && myRigi.velocity.y == 0 || collision.gameObject.tag == "Plataforma" && myRigi.velocity.y == 0 || collision.gameObject.tag == "Plataforma" && myRigi.velocity.y <= 0)
        {
            myRigi.AddForce(new Vector2(0, 400));
            Particulas.Play();
            AudioSource.PlayClipAtPoint(Plataforma_Basica, transform.position, 0.1f);
            sonidoPlat_B = false;
        }

        if (collision.gameObject.tag == "Plataforma_SuperSalto" && myRigi.velocity.y == 0 || collision.gameObject.tag == "Plataforma_SuperSalto" && myRigi.velocity.y <= 0)
        {
            myRigi.AddForce(new Vector2(0, 600));
            AudioSource.PlayClipAtPoint(Plataforma_Super, transform.position, 1f);
            sonidoPlat_S = false;
            Particulas.Play();
        }
        
        if (collision.gameObject.tag == "Plataforma_Paraguas" && myRigi.velocity.y == 0 || collision.gameObject.tag == "Plataforma_Paraguas" && myRigi.velocity.y <= 0)
        {
            myRigi.AddForce(new Vector2(0, 400));
            AudioSource.PlayClipAtPoint(Plataforma_Parag, transform.position, 0.15f);
            sonidoPlat_P = false;
            Particulas.Play();
            StartCoroutine("Paraguas");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Moneda")
        {
            Monedas += 1;
            Instantiate(Particulas_Moneda, collision.transform.position, Quaternion.identity);
            AudioSource.PlayClipAtPoint(Moneda, transform.position, 0.35f);
            sonidoMoneda = false;
            Destroy(collision.gameObject);
        }
    }

    public IEnumerator Paraguas()
    {
        myRigi.gravityScale = 0.45f;
        GO_Paraguas.SetActive(true);
        yield return new WaitForSeconds(5f);
        myRigi.gravityScale = 1;
        GO_Paraguas.SetActive(false);
    }
}