using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnear_Plataformas : MonoBehaviour
{
    public GameObject P1_M, P1_Q;
    public GameObject P2_M, P2_Q, P2_M_SS, P2_Q_SS;
    public GameObject P3_M, P3_Q, P3_M_SS, P3_Q_SS;
    public GameObject P4_M, P4_Q, P4_M_SS, P4_Q_SS;
    public GameObject P5_M, P5_Q, P5_M_SS, P5_Q_SS;
    public GameObject P6_M, P6_Q, P6_M_SS, P6_Q_SS, P6_M_P, P6_Q_P;
    public GameObject P7_M, P7_Q, P7_M_SS, P7_Q_SS, P7_M_P, P7_Q_P;
    public GameObject P8_M, P8_Q, P8_M_SS, P8_Q_SS, P8_M_P, P8_Q_P;
    public GameObject P9_M, P9_Q, P9_M_SS, P9_Q_SS, P9_M_P, P9_Q_P;

    private float myPosY;
    public float Intersecciones;

    void Start()
    {
        myPosY = transform.position.y;
        #region Nivel1
        float PosX1 = Random.Range(-2.6f, 2.6f);
        Instantiate(P1_Q, new Vector2(PosX1, myPosY + Intersecciones * 1), transform.rotation);
        float PosX2 = Random.Range(-2.6f, 2.6f);
        Instantiate(P1_Q, new Vector2(PosX2, myPosY + Intersecciones * 2), transform.rotation);
        int ValorP3 = Random.Range(0, 3);
        float PosX3 = Random.Range(-2.6f, 2.6f);
        if (ValorP3 == 0 || ValorP3 == 2)
        {
            Instantiate(P1_Q, new Vector2(PosX3, myPosY + Intersecciones * 3), transform.rotation);
        }
        if (ValorP3 == 1)
        {
            Instantiate(P1_M, new Vector2(PosX3, myPosY + Intersecciones * 3), transform.rotation);
        }
        int ValorP4 = Random.Range(0, 2);
        float PosX4 = Random.Range(-2.6f, 2.6f);
        if (ValorP4 == 0)
        {
            Instantiate(P1_Q, new Vector2(PosX4, myPosY + Intersecciones * 4), transform.rotation);
        }
        if (ValorP4 == 1)
        {
            Instantiate(P1_M, new Vector2(PosX4, myPosY + Intersecciones * 4), transform.rotation);
        }
        int ValorP5 = Random.Range(0, 2);
        float PosX5 = Random.Range(-2.6f, 2.6f);
        if (ValorP5 == 0)
        {
            Instantiate(P1_Q, new Vector2(PosX5, myPosY + Intersecciones * 5), transform.rotation);
        }
        if (ValorP5 == 1)
        {
            Instantiate(P1_M, new Vector2(PosX5, myPosY + Intersecciones * 5), transform.rotation);
        }
        int ValorP6 = Random.Range(0, 2);
        float PosX6 = Random.Range(-2.6f, 2.6f);
        if (ValorP6 == 0)
        {
            Instantiate(P1_Q, new Vector2(PosX6, myPosY + Intersecciones * 6), transform.rotation);
        }
        if (ValorP6 == 1)
        {
            Instantiate(P1_M, new Vector2(PosX6, myPosY + Intersecciones * 6), transform.rotation);
        }
        int ValorP7 = Random.Range(0, 2);
        float PosX7 = Random.Range(-2.6f, 2.6f);
        if (ValorP7 == 0)
        {
            Instantiate(P1_Q, new Vector2(PosX7, myPosY + Intersecciones * 7), transform.rotation);
        }
        if (ValorP7 == 1)
        {
            Instantiate(P1_M, new Vector2(PosX7, myPosY + Intersecciones * 7), transform.rotation);
        }
        int ValorP8 = Random.Range(0, 2);
        float PosX8 = Random.Range(-2.6f, 2.6f);
        if (ValorP8 == 0)
        {
            Instantiate(P1_Q, new Vector2(PosX8, myPosY + Intersecciones * 8), transform.rotation);
        }
        if (ValorP8 == 1)
        {
            Instantiate(P1_M, new Vector2(PosX8, myPosY + Intersecciones * 8), transform.rotation);
        }
        int ValorP9 = Random.Range(0, 2);
        float PosX9 = Random.Range(-2.6f, 2.6f);
        if (ValorP9 == 0)
        {
            Instantiate(P1_Q, new Vector2(PosX9, myPosY + Intersecciones * 9), transform.rotation);
        }
        if (ValorP9 == 1)
        {
            Instantiate(P1_M, new Vector2(PosX9, myPosY + Intersecciones * 9), transform.rotation);
        }
        int ValorP10 = Random.Range(0, 2);
        float PosX10 = Random.Range(-2.6f, 2.6f);
        if (ValorP10 == 0)
        {
            Instantiate(P1_Q, new Vector2(PosX10, myPosY + Intersecciones * 10), transform.rotation);
        }
        if (ValorP10 == 1)
        {
            Instantiate(P1_M, new Vector2(PosX10, myPosY + Intersecciones * 10), transform.rotation);
        }
        int ValorP11 = Random.Range(0, 2);
        float PosX11 = Random.Range(-2.6f, 2.6f);
        if (ValorP11 == 0)
        {
            Instantiate(P1_Q, new Vector2(PosX11, myPosY + Intersecciones * 11), transform.rotation);
        }
        if (ValorP11 == 1)
        {
            Instantiate(P1_M, new Vector2(PosX11, myPosY + Intersecciones * 11), transform.rotation);
        }
        int ValorP12 = Random.Range(0, 2);
        float PosX12 = Random.Range(-2.6f, 2.6f);
        if (ValorP12 == 0)
        {
            Instantiate(P1_Q, new Vector2(PosX12, myPosY + Intersecciones * 12), transform.rotation);
        }
        if (ValorP12 == 1)
        {
            Instantiate(P1_M, new Vector2(PosX12, myPosY + Intersecciones * 12), transform.rotation);
        }
        int ValorP13 = Random.Range(0, 4);
        float PosX13 = Random.Range(-2.6f, 2.6f);
        if (ValorP13 == 0)
        {
            Instantiate(P1_Q, new Vector2(PosX13, myPosY + Intersecciones * 13), transform.rotation);
        }
        if (ValorP13 == 1)
        {
            Instantiate(P2_Q, new Vector2(PosX13, myPosY + Intersecciones * 13), transform.rotation);
        }
        if (ValorP13 == 2)
        {
            Instantiate(P1_M, new Vector2(PosX13, myPosY + Intersecciones * 13), transform.rotation);
        }
        if (ValorP13 == 3)
        {
            Instantiate(P2_M, new Vector2(PosX13, myPosY + Intersecciones * 13), transform.rotation);
        }
        int ValorP14 = Random.Range(0, 4);
        float PosX14 = Random.Range(-2.6f, 2.6f);
        if (ValorP14 == 0)
        {
            Instantiate(P1_Q, new Vector2(PosX14, myPosY + Intersecciones * 14), transform.rotation);
        }
        if (ValorP14 == 1)
        {
            Instantiate(P2_Q, new Vector2(PosX14, myPosY + Intersecciones * 14), transform.rotation);
        }
        if (ValorP14 == 2)
        {
            Instantiate(P1_M, new Vector2(PosX14, myPosY + Intersecciones * 14), transform.rotation);
        }
        if (ValorP14 == 3)
        {
            Instantiate(P2_M, new Vector2(PosX14, myPosY + Intersecciones * 14), transform.rotation);
        }
        int ValorP15 = Random.Range(0, 6);
        float PosX15 = Random.Range(-2.6f, 2.6f);
        if (ValorP15 == 0)
        {
            Instantiate(P1_Q, new Vector2(PosX15, myPosY + Intersecciones * 15), transform.rotation);
        }
        if (ValorP15 == 1 || ValorP15 == 5)
        {
            Instantiate(P2_Q, new Vector2(PosX15, myPosY + Intersecciones * 15), transform.rotation);
        }
        if (ValorP15 == 2)
        {
            Instantiate(P1_M, new Vector2(PosX15, myPosY + Intersecciones * 15), transform.rotation);
        }
        if (ValorP15 == 3 || ValorP15 == 4)
        {
            Instantiate(P2_M, new Vector2(PosX15, myPosY + Intersecciones * 15), transform.rotation);
        }
        int ValorP16 = Random.Range(0, 6);
        float PosX16 = Random.Range(-2.6f, 2.6f);
        if (ValorP16 == 0)
        {
            Instantiate(P1_Q, new Vector2(PosX16, myPosY + Intersecciones * 16), transform.rotation);
        }
        if (ValorP16 == 1 || ValorP16 == 5)
        {
            Instantiate(P2_Q, new Vector2(PosX16, myPosY + Intersecciones * 16), transform.rotation);
        }
        if (ValorP16 == 2)
        {
            Instantiate(P1_M, new Vector2(PosX16, myPosY + Intersecciones * 16), transform.rotation);
        }
        if (ValorP16 == 3 || ValorP16 == 4)
        {
            Instantiate(P2_M, new Vector2(PosX16, myPosY + Intersecciones * 16), transform.rotation);
        }
        int ValorP17 = Random.Range(0, 6);
        float PosX17 = Random.Range(-2.6f, 2.6f);
        if (ValorP17 == 0)
        {
            Instantiate(P1_Q, new Vector2(PosX17, myPosY + Intersecciones * 17), transform.rotation);
        }
        if (ValorP17 == 1 || ValorP17 == 5)
        {
            Instantiate(P2_Q, new Vector2(PosX17, myPosY + Intersecciones * 17), transform.rotation);
        }
        if (ValorP17 == 2)
        {
            Instantiate(P1_M, new Vector2(PosX17, myPosY + Intersecciones * 17), transform.rotation);
        }
        if (ValorP17 == 3 || ValorP17 == 4)
        {
            Instantiate(P2_M, new Vector2(PosX17, myPosY + Intersecciones * 17), transform.rotation);
        }
        int ValorP18 = Random.Range(0, 6);
        float PosX18 = Random.Range(-2.6f, 2.6f);
        if (ValorP18 == 0)
        {
            Instantiate(P1_Q, new Vector2(PosX18, myPosY + Intersecciones * 18), transform.rotation);
        }
        if (ValorP18 == 1 || ValorP18 == 5)
        {
            Instantiate(P2_Q, new Vector2(PosX18, myPosY + Intersecciones * 18), transform.rotation);
        }
        if (ValorP18 == 2)
        {
            Instantiate(P1_M, new Vector2(PosX18, myPosY + Intersecciones * 18), transform.rotation);
        }
        if (ValorP18 == 3 || ValorP18 == 4)
        {
            Instantiate(P2_M, new Vector2(PosX18, myPosY + Intersecciones * 18), transform.rotation);
        }
        int ValorP19 = Random.Range(0, 6);
        float PosX19 = Random.Range(-2.6f, 2.6f);
        if (ValorP19 == 0)
        {
            Instantiate(P1_Q, new Vector2(PosX19, myPosY + Intersecciones * 19), transform.rotation);
        }
        if (ValorP19 == 1 || ValorP19 == 5)
        {
            Instantiate(P2_Q, new Vector2(PosX19, myPosY + Intersecciones * 19), transform.rotation);
        }
        if (ValorP19 == 2)
        {
            Instantiate(P1_M, new Vector2(PosX19, myPosY + Intersecciones * 19), transform.rotation);
        }
        if (ValorP19 == 3 || ValorP19 == 4)
        {
            Instantiate(P2_M, new Vector2(PosX19, myPosY + Intersecciones * 19), transform.rotation);
        }
        int ValorP20 = Random.Range(0, 6);
        float PosX20 = Random.Range(-2.6f, 2.6f);
        if (ValorP20 == 0)
        {
            Instantiate(P1_Q, new Vector2(PosX20, myPosY + Intersecciones * 20), transform.rotation);
        }
        if (ValorP20 == 1 || ValorP20 == 5)
        {
            Instantiate(P2_Q, new Vector2(PosX20, myPosY + Intersecciones * 20), transform.rotation);
        }
        if (ValorP20 == 2)
        {
            Instantiate(P1_M, new Vector2(PosX20, myPosY + Intersecciones * 20), transform.rotation);
        }
        if (ValorP20 == 3 || ValorP20 == 4)
        {
            Instantiate(P2_M, new Vector2(PosX20, myPosY + Intersecciones * 20), transform.rotation);
        }
        int ValorP21 = Random.Range(0, 6);
        float PosX21 = Random.Range(-2.6f, 2.6f);
        if (ValorP21 == 0)
        {
            Instantiate(P1_Q, new Vector2(PosX21, myPosY + Intersecciones * 21), transform.rotation);
        }
        if (ValorP21 == 1 || ValorP21 == 5)
        {
            Instantiate(P2_Q, new Vector2(PosX21, myPosY + Intersecciones * 21), transform.rotation);
        }
        if (ValorP21 == 2)
        {
            Instantiate(P1_M, new Vector2(PosX21, myPosY + Intersecciones * 21), transform.rotation);
        }
        if (ValorP21 == 3 || ValorP21 == 4)
        {
            Instantiate(P2_M, new Vector2(PosX21, myPosY + Intersecciones * 21), transform.rotation);
        }
        #endregion
        #region Nivel2
        int ValorP22 = Random.Range(0, 2);
        float PosX22 = Random.Range(-2.6f, 2.6f);
        if (ValorP22 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX22, myPosY + Intersecciones * 22), transform.rotation);
        }
        if (ValorP22 == 1)
        {
            Instantiate(P2_M, new Vector2(PosX22, myPosY + Intersecciones * 22), transform.rotation);
        }
        int ValorP23 = Random.Range(0, 4);
        float PosX23 = Random.Range(-2.6f, 2.6f);
        if (ValorP23 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX23, myPosY + Intersecciones * 23), transform.rotation);
        }
        if (ValorP23 == 1)
        {
            Instantiate(P2_Q_SS, new Vector2(PosX23, myPosY + Intersecciones * 23), transform.rotation);
        }
        if (ValorP23 == 2)
        {
            Instantiate(P2_M, new Vector2(PosX23, myPosY + Intersecciones * 23), transform.rotation);
        }
        if (ValorP23 == 3)
        {
            Instantiate(P2_M_SS, new Vector2(PosX23, myPosY + Intersecciones * 23), transform.rotation);
        }
        int ValorP24 = Random.Range(0, 4);
        float PosX24 = Random.Range(-2.6f, 2.6f);
        if (ValorP24 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX24, myPosY + Intersecciones * 24), transform.rotation);
        }
        if (ValorP24 == 1)
        {
            Instantiate(P2_Q_SS, new Vector2(PosX24, myPosY + Intersecciones * 24), transform.rotation);
        }
        if (ValorP24 == 2)
        {
            Instantiate(P2_M, new Vector2(PosX24, myPosY + Intersecciones * 24), transform.rotation);
        }
        if (ValorP24 == 3)
        {
            Instantiate(P2_M_SS, new Vector2(PosX24, myPosY + Intersecciones * 24), transform.rotation);
        }
        int ValorP25 = Random.Range(0, 4);
        float PosX25 = Random.Range(-2.6f, 2.6f);
        if (ValorP25 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX25, myPosY + Intersecciones * 25), transform.rotation);
        }
        if (ValorP25 == 1)
        {
            Instantiate(P2_Q_SS, new Vector2(PosX25, myPosY + Intersecciones * 25), transform.rotation);
        }
        if (ValorP25 == 2)
        {
            Instantiate(P2_M, new Vector2(PosX25, myPosY + Intersecciones * 25), transform.rotation);
        }
        if (ValorP25 == 3)
        {
            Instantiate(P2_M_SS, new Vector2(PosX25, myPosY + Intersecciones * 25), transform.rotation);
        }
        int ValorP26 = Random.Range(0, 4);
        float PosX26 = Random.Range(-2.6f, 2.6f);
        if (ValorP26 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX26, myPosY + Intersecciones * 26), transform.rotation);
        }
        if (ValorP26 == 1)
        {
            Instantiate(P2_Q_SS, new Vector2(PosX26, myPosY + Intersecciones * 26), transform.rotation);
        }
        if (ValorP26 == 2)
        {
            Instantiate(P2_M, new Vector2(PosX26, myPosY + Intersecciones * 26), transform.rotation);
        }
        if (ValorP26 == 3)
        {
            Instantiate(P2_M_SS, new Vector2(PosX26, myPosY + Intersecciones * 26), transform.rotation);
        }
        int ValorP27 = Random.Range(0, 4);
        float PosX27 = Random.Range(-2.6f, 2.6f);
        if (ValorP27 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX27, myPosY + Intersecciones * 27), transform.rotation);
        }
        if (ValorP27 == 1)
        {
            Instantiate(P2_Q_SS, new Vector2(PosX27, myPosY + Intersecciones * 27), transform.rotation);
        }
        if (ValorP27 == 2)
        {
            Instantiate(P2_M, new Vector2(PosX27, myPosY + Intersecciones * 27), transform.rotation);
        }
        if (ValorP27 == 3)
        {
            Instantiate(P2_M_SS, new Vector2(PosX27, myPosY + Intersecciones * 27), transform.rotation);
        }
        int ValorP28 = Random.Range(0, 4);
        float PosX28 = Random.Range(-2.6f, 2.6f);
        if (ValorP28 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX28, myPosY + Intersecciones * 28), transform.rotation);
        }
        if (ValorP28 == 1)
        {
            Instantiate(P2_Q_SS, new Vector2(PosX28, myPosY + Intersecciones * 28), transform.rotation);
        }
        if (ValorP28 == 2)
        {
            Instantiate(P2_M, new Vector2(PosX28, myPosY + Intersecciones * 28), transform.rotation);
        }
        if (ValorP28 == 3)
        {
            Instantiate(P2_M_SS, new Vector2(PosX28, myPosY + Intersecciones * 28), transform.rotation);
        }
        int ValorP29 = Random.Range(0, 4);
        float PosX29 = Random.Range(-2.6f, 2.6f);
        if (ValorP29 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX29, myPosY + Intersecciones * 29), transform.rotation);
        }
        if (ValorP29 == 1)
        {
            Instantiate(P2_Q_SS, new Vector2(PosX29, myPosY + Intersecciones * 29), transform.rotation);
        }
        if (ValorP29 == 2)
        {
            Instantiate(P2_M, new Vector2(PosX29, myPosY + Intersecciones * 29), transform.rotation);
        }
        if (ValorP29 == 3)
        {
            Instantiate(P2_M_SS, new Vector2(PosX29, myPosY + Intersecciones * 29), transform.rotation);
        }
        int ValorP30 = Random.Range(0, 4);
        float PosX30 = Random.Range(-2.6f, 2.6f);
        if (ValorP30 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX30, myPosY + Intersecciones * 30), transform.rotation);
        }
        if (ValorP30 == 1)
        {
            Instantiate(P2_Q_SS, new Vector2(PosX30, myPosY + Intersecciones * 30), transform.rotation);
        }
        if (ValorP30 == 2)
        {
            Instantiate(P2_M, new Vector2(PosX30, myPosY + Intersecciones * 30), transform.rotation);
        }
        if (ValorP30 == 3)
        {
            Instantiate(P2_M_SS, new Vector2(PosX30, myPosY + Intersecciones * 30), transform.rotation);
        }
        int ValorP31 = Random.Range(0, 4);
        float PosX31 = Random.Range(-2.6f, 2.6f);
        if (ValorP31 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX31, myPosY + Intersecciones * 31), transform.rotation);
        }
        if (ValorP31 == 1)
        {
            Instantiate(P2_Q_SS, new Vector2(PosX31, myPosY + Intersecciones * 31), transform.rotation);
        }
        if (ValorP31 == 2)
        {
            Instantiate(P2_M, new Vector2(PosX31, myPosY + Intersecciones * 31), transform.rotation);
        }
        if (ValorP31 == 3)
        {
            Instantiate(P2_M_SS, new Vector2(PosX31, myPosY + Intersecciones * 31), transform.rotation);
        }
        int ValorP32 = Random.Range(0, 4);
        float PosX32 = Random.Range(-2.6f, 2.6f);
        if (ValorP32 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX32, myPosY + Intersecciones * 32), transform.rotation);
        }
        if (ValorP32 == 1)
        {
            Instantiate(P2_Q_SS, new Vector2(PosX32, myPosY + Intersecciones * 32), transform.rotation);
        }
        if (ValorP32 == 2)
        {
            Instantiate(P2_M, new Vector2(PosX32, myPosY + Intersecciones * 32), transform.rotation);
        }
        if (ValorP32 == 3)
        {
            Instantiate(P2_M_SS, new Vector2(PosX32, myPosY + Intersecciones * 32), transform.rotation);
        }
        int ValorP33 = Random.Range(0, 4);
        float PosX33 = Random.Range(-2.6f, 2.6f);
        if (ValorP33 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX33, myPosY + Intersecciones * 33), transform.rotation);
        }
        if (ValorP33 == 1)
        {
            Instantiate(P2_Q_SS, new Vector2(PosX33, myPosY + Intersecciones * 33), transform.rotation);
        }
        if (ValorP33 == 2)
        {
            Instantiate(P2_M, new Vector2(PosX33, myPosY + Intersecciones * 33), transform.rotation);
        }
        if (ValorP33 == 3)
        {
            Instantiate(P2_M_SS, new Vector2(PosX33, myPosY + Intersecciones * 33), transform.rotation);
        }
        int ValorP34 = Random.Range(0, 4);
        float PosX34 = Random.Range(-2.6f, 2.6f);
        if (ValorP34 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX34, myPosY + Intersecciones * 34), transform.rotation);
        }
        if (ValorP34 == 1)
        {
            Instantiate(P2_Q_SS, new Vector2(PosX34, myPosY + Intersecciones * 34), transform.rotation);
        }
        if (ValorP34 == 2)
        {
            Instantiate(P2_M, new Vector2(PosX34, myPosY + Intersecciones * 34), transform.rotation);
        }
        if (ValorP34 == 3)
        {
            Instantiate(P2_M_SS, new Vector2(PosX34, myPosY + Intersecciones * 34), transform.rotation);
        }
        int ValorP35 = Random.Range(0, 4);
        float PosX35 = Random.Range(-2.6f, 2.6f);
        if (ValorP35 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX35, myPosY + Intersecciones * 35), transform.rotation);
        }
        if (ValorP35 == 1)
        {
            Instantiate(P2_Q_SS, new Vector2(PosX35, myPosY + Intersecciones * 35), transform.rotation);
        }
        if (ValorP35 == 2)
        {
            Instantiate(P2_M, new Vector2(PosX35, myPosY + Intersecciones * 35), transform.rotation);
        }
        if (ValorP35 == 3)
        {
            Instantiate(P2_M_SS, new Vector2(PosX35, myPosY + Intersecciones * 35), transform.rotation);
        }
        int ValorP36 = Random.Range(0, 5);
        float PosX36 = Random.Range(-2.6f, 2.6f);
        if (ValorP36 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX36, myPosY + Intersecciones * 36), transform.rotation);
        }
        if (ValorP36 == 1)
        {
            Instantiate(P2_Q_SS, new Vector2(PosX36, myPosY + Intersecciones * 36), transform.rotation);
        }
        if (ValorP36 == 2 || ValorP36 == 4)
        {
            Instantiate(P2_M, new Vector2(PosX36, myPosY + Intersecciones * 36), transform.rotation);
        }
        if (ValorP36 == 3)
        {
            Instantiate(P2_M_SS, new Vector2(PosX36, myPosY + Intersecciones * 36), transform.rotation);
        }
        int ValorP37 = Random.Range(0, 5);
        float PosX37 = Random.Range(-2.6f, 2.6f);
        if (ValorP37 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX37, myPosY + Intersecciones * 37), transform.rotation);
        }
        if (ValorP37 == 1)
        {
            Instantiate(P2_Q_SS, new Vector2(PosX37, myPosY + Intersecciones * 37), transform.rotation);
        }
        if (ValorP37 == 2 || ValorP37 == 4)
        {
            Instantiate(P2_M, new Vector2(PosX37, myPosY + Intersecciones * 37), transform.rotation);
        }
        if (ValorP37 == 3)
        {
            Instantiate(P2_M_SS, new Vector2(PosX37, myPosY + Intersecciones * 37), transform.rotation);
        }
        int ValorP38 = Random.Range(0, 5);
        float PosX38 = Random.Range(-2.6f, 2.6f);
        if (ValorP38 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX38, myPosY + Intersecciones * 38), transform.rotation);
        }
        if (ValorP38 == 1)
        {
            Instantiate(P2_Q_SS, new Vector2(PosX38, myPosY + Intersecciones * 38), transform.rotation);
        }
        if (ValorP38 == 2 || ValorP38 == 4)
        {
            Instantiate(P2_M, new Vector2(PosX38, myPosY + Intersecciones * 38), transform.rotation);
        }
        if (ValorP38 == 3)
        {
            Instantiate(P2_M_SS, new Vector2(PosX38, myPosY + Intersecciones * 38), transform.rotation);
        }
        int ValorP39 = Random.Range(0, 5);
        float PosX39 = Random.Range(-2.6f, 2.6f);
        if (ValorP39 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX39, myPosY + Intersecciones * 39), transform.rotation);
        }
        if (ValorP39 == 1)
        {
            Instantiate(P2_Q_SS, new Vector2(PosX39, myPosY + Intersecciones * 39), transform.rotation);
        }
        if (ValorP39 == 2 || ValorP39 == 4)
        {
            Instantiate(P2_M, new Vector2(PosX39, myPosY + Intersecciones * 39), transform.rotation);
        }
        if (ValorP39 == 3)
        {
            Instantiate(P2_M_SS, new Vector2(PosX39, myPosY + Intersecciones * 39), transform.rotation);
        }
        int ValorP40 = Random.Range(0, 5);
        float PosX40 = Random.Range(-2.6f, 2.6f);
        if (ValorP40 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX40, myPosY + Intersecciones * 40), transform.rotation);
        }
        if (ValorP40 == 1)
        {
            Instantiate(P2_Q_SS, new Vector2(PosX40, myPosY + Intersecciones * 40), transform.rotation);
        }
        if (ValorP40 == 2 || ValorP40 == 4)
        {
            Instantiate(P2_M, new Vector2(PosX40, myPosY + Intersecciones * 40), transform.rotation);
        }
        if (ValorP40 == 3)
        {
            Instantiate(P2_M_SS, new Vector2(PosX40, myPosY + Intersecciones * 40), transform.rotation);
        }
        int ValorP41 = Random.Range(0, 5);
        float PosX41 = Random.Range(-2.6f, 2.6f);
        if (ValorP41 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX41, myPosY + Intersecciones * 41), transform.rotation);
        }
        if (ValorP41 == 1)
        {
            Instantiate(P2_Q_SS, new Vector2(PosX41, myPosY + Intersecciones * 41), transform.rotation);
        }
        if (ValorP41 == 2 || ValorP41 == 4)
        {
            Instantiate(P2_M, new Vector2(PosX41, myPosY + Intersecciones * 41), transform.rotation);
        }
        if (ValorP41 == 3)
        {
            Instantiate(P2_M_SS, new Vector2(PosX41, myPosY + Intersecciones * 41), transform.rotation);
        }
        int ValorP42 = Random.Range(0, 5);
        float PosX42 = Random.Range(-2.6f, 2.6f);
        if (ValorP42 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX42, myPosY + Intersecciones * 42), transform.rotation);
        }
        if (ValorP42 == 1)
        {
            Instantiate(P2_Q_SS, new Vector2(PosX42, myPosY + Intersecciones * 42), transform.rotation);
        }
        if (ValorP42 == 2 || ValorP42 == 4)
        {
            Instantiate(P2_M, new Vector2(PosX42, myPosY + Intersecciones * 42), transform.rotation);
        }
        if (ValorP42 == 3)
        {
            Instantiate(P2_M_SS, new Vector2(PosX42, myPosY + Intersecciones * 42), transform.rotation);
        }
        int ValorP43 = Random.Range(0, 5);
        float PosX43 = Random.Range(-2.6f, 2.6f);
        if (ValorP43 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX43, myPosY + Intersecciones * 43), transform.rotation);
        }
        if (ValorP43 == 1)
        {
            Instantiate(P2_Q_SS, new Vector2(PosX43, myPosY + Intersecciones * 43), transform.rotation);
        }
        if (ValorP43 == 2 || ValorP43 == 4)
        {
            Instantiate(P2_M, new Vector2(PosX43, myPosY + Intersecciones * 43), transform.rotation);
        }
        if (ValorP43 == 3)
        {
            Instantiate(P2_M_SS, new Vector2(PosX43, myPosY + Intersecciones * 43), transform.rotation);
        }
        int ValorP44 = Random.Range(0, 5);
        float PosX44 = Random.Range(-2.6f, 2.6f);
        if (ValorP44 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX44, myPosY + Intersecciones * 44), transform.rotation);
        }
        if (ValorP44 == 1)
        {
            Instantiate(P2_Q_SS, new Vector2(PosX44, myPosY + Intersecciones * 44), transform.rotation);
        }
        if (ValorP44 == 2 || ValorP44 == 4)
        {
            Instantiate(P2_M, new Vector2(PosX44, myPosY + Intersecciones * 44), transform.rotation);
        }
        if (ValorP44 == 3)
        {
            Instantiate(P2_M_SS, new Vector2(PosX44, myPosY + Intersecciones * 44), transform.rotation);
        }
        int ValorP45 = Random.Range(0, 7);
        float PosX45 = Random.Range(-2.6f, 2.6f);
        if (ValorP45 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX45, myPosY + Intersecciones * 45), transform.rotation);
        }
        if (ValorP45 == 1)
        {
            Instantiate(P2_Q_SS, new Vector2(PosX45, myPosY + Intersecciones * 45), transform.rotation);
        }
        if (ValorP45 == 2 || ValorP45 == 6)
        {
            Instantiate(P2_M, new Vector2(PosX45, myPosY + Intersecciones * 45), transform.rotation);
        }
        if (ValorP45 == 3)
        {
            Instantiate(P3_Q, new Vector2(PosX45, myPosY + Intersecciones * 45), transform.rotation);
        }
        if (ValorP45 == 4)
        {
            Instantiate(P2_M_SS, new Vector2(PosX45, myPosY + Intersecciones * 45), transform.rotation);
        }
        if (ValorP45 == 5)
        {
            Instantiate(P3_M, new Vector2(PosX45, myPosY + Intersecciones * 45), transform.rotation);
        }
        int ValorP46 = Random.Range(0, 7);
        float PosX46 = Random.Range(-2.6f, 2.6f);
        if (ValorP46 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX46, myPosY + Intersecciones * 46), transform.rotation);
        }
        if (ValorP46 == 1)
        {
            Instantiate(P2_Q_SS, new Vector2(PosX46, myPosY + Intersecciones * 46), transform.rotation);
        }
        if (ValorP46 == 2 || ValorP46 == 6)
        {
            Instantiate(P2_M, new Vector2(PosX46, myPosY + Intersecciones * 46), transform.rotation);
        }
        if (ValorP46 == 3)
        {
            Instantiate(P3_Q, new Vector2(PosX46, myPosY + Intersecciones * 46), transform.rotation);
        }
        if (ValorP46 == 4)
        {
            Instantiate(P2_M_SS, new Vector2(PosX46, myPosY + Intersecciones * 46), transform.rotation);
        }
        if (ValorP46 == 5)
        {
            Instantiate(P3_M, new Vector2(PosX46, myPosY + Intersecciones * 46), transform.rotation);
        }
        int ValorP47 = Random.Range(0, 7);
        float PosX47 = Random.Range(-2.6f, 2.6f);
        if (ValorP47 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX47, myPosY + Intersecciones * 47), transform.rotation);
        }
        if (ValorP47 == 1)
        {
            Instantiate(P2_Q_SS, new Vector2(PosX47, myPosY + Intersecciones * 47), transform.rotation);
        }
        if (ValorP47 == 2 || ValorP47 == 6)
        {
            Instantiate(P2_M, new Vector2(PosX47, myPosY + Intersecciones * 47), transform.rotation);
        }
        if (ValorP47 == 3)
        {
            Instantiate(P3_Q, new Vector2(PosX47, myPosY + Intersecciones * 47), transform.rotation);
        }
        if (ValorP47 == 4)
        {
            Instantiate(P2_M_SS, new Vector2(PosX47, myPosY + Intersecciones * 47), transform.rotation);
        }
        if (ValorP47 == 5)
        {
            Instantiate(P3_M, new Vector2(PosX47, myPosY + Intersecciones * 47), transform.rotation);
        }
        int ValorP48 = Random.Range(0, 7);
        float PosX48 = Random.Range(-2.6f, 2.6f);
        if (ValorP48 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX48, myPosY + Intersecciones * 48), transform.rotation);
        }
        if (ValorP48 == 1)
        {
            Instantiate(P2_Q_SS, new Vector2(PosX48, myPosY + Intersecciones * 48), transform.rotation);
        }
        if (ValorP48 == 2 || ValorP48 == 6)
        {
            Instantiate(P2_M, new Vector2(PosX48, myPosY + Intersecciones * 48), transform.rotation);
        }
        if (ValorP48 == 3)
        {
            Instantiate(P3_Q, new Vector2(PosX48, myPosY + Intersecciones * 48), transform.rotation);
        }
        if (ValorP48 == 4)
        {
            Instantiate(P2_M_SS, new Vector2(PosX48, myPosY + Intersecciones * 48), transform.rotation);
        }
        if (ValorP48 == 5)
        {
            Instantiate(P3_M, new Vector2(PosX48, myPosY + Intersecciones * 48), transform.rotation);
        }
        int ValorP49 = Random.Range(0, 7);
        float PosX49 = Random.Range(-2.6f, 2.6f);
        if (ValorP49 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX49, myPosY + Intersecciones * 49), transform.rotation);
        }
        if (ValorP49 == 1)
        {
            Instantiate(P2_Q_SS, new Vector2(PosX49, myPosY + Intersecciones * 49), transform.rotation);
        }
        if (ValorP49 == 2 || ValorP49 == 6)
        {
            Instantiate(P2_M, new Vector2(PosX49, myPosY + Intersecciones * 49), transform.rotation);
        }
        if (ValorP49 == 3)
        {
            Instantiate(P3_Q, new Vector2(PosX49, myPosY + Intersecciones * 49), transform.rotation);
        }
        if (ValorP49 == 4)
        {
            Instantiate(P2_M_SS, new Vector2(PosX49, myPosY + Intersecciones * 49), transform.rotation);
        }
        if (ValorP49 == 5)
        {
            Instantiate(P3_M, new Vector2(PosX49, myPosY + Intersecciones * 49), transform.rotation);
        }
        int ValorP50 = Random.Range(0, 7);
        float PosX50 = Random.Range(-2.6f, 2.6f);
        if (ValorP50 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX50, myPosY + Intersecciones * 50), transform.rotation);
        }
        if (ValorP50 == 1)
        {
            Instantiate(P2_Q_SS, new Vector2(PosX50, myPosY + Intersecciones * 50), transform.rotation);
        }
        if (ValorP50 == 2 || ValorP50 == 6)
        {
            Instantiate(P2_M, new Vector2(PosX50, myPosY + Intersecciones * 50), transform.rotation);
        }
        if (ValorP50 == 3)
        {
            Instantiate(P3_Q, new Vector2(PosX50, myPosY + Intersecciones * 50), transform.rotation);
        }
        if (ValorP50 == 4)
        {
            Instantiate(P2_M_SS, new Vector2(PosX50, myPosY + Intersecciones * 50), transform.rotation);
        }
        if (ValorP50 == 5)
        {
            Instantiate(P3_M, new Vector2(PosX50, myPosY + Intersecciones * 50), transform.rotation);
        }
        int ValorP51 = Random.Range(0, 6);
        float PosX51 = Random.Range(-2.6f, 2.6f);
        if (ValorP51 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX51, myPosY + Intersecciones * 51), transform.rotation);
        }
        if (ValorP51 == 1)
        {
            Instantiate(P2_Q_SS, new Vector2(PosX51, myPosY + Intersecciones * 51), transform.rotation);
        }
        if (ValorP51 == 2)
        {
            Instantiate(P2_M, new Vector2(PosX51, myPosY + Intersecciones * 51), transform.rotation);
        }
        if (ValorP51 == 3)
        {
            Instantiate(P3_Q, new Vector2(PosX51, myPosY + Intersecciones * 51), transform.rotation);
        }
        if (ValorP51 == 4)
        {
            Instantiate(P2_M_SS, new Vector2(PosX51, myPosY + Intersecciones * 51), transform.rotation);
        }
        if (ValorP51 == 5)
        {
            Instantiate(P3_M, new Vector2(PosX51, myPosY + Intersecciones * 51), transform.rotation);
        }
        int ValorP52 = Random.Range(0, 6);
        float PosX52 = Random.Range(-2.6f, 2.6f);
        if (ValorP52 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX52, myPosY + Intersecciones * 52), transform.rotation);
        }
        if (ValorP52 == 1)
        {
            Instantiate(P2_Q_SS, new Vector2(PosX52, myPosY + Intersecciones * 52), transform.rotation);
        }
        if (ValorP52 == 2)
        {
            Instantiate(P2_M, new Vector2(PosX52, myPosY + Intersecciones * 52), transform.rotation);
        }
        if (ValorP52 == 3)
        {
            Instantiate(P3_Q, new Vector2(PosX52, myPosY + Intersecciones * 52), transform.rotation);
        }
        if (ValorP52 == 4)
        {
            Instantiate(P2_M_SS, new Vector2(PosX52, myPosY + Intersecciones * 52), transform.rotation);
        }
        if (ValorP52 == 5)
        {
            Instantiate(P3_M, new Vector2(PosX52, myPosY + Intersecciones * 52), transform.rotation);
        }
        int ValorP53 = Random.Range(0, 4);
        float PosX53 = Random.Range(-2.6f, 2.6f);
        if (ValorP53 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX53, myPosY + Intersecciones * 53), transform.rotation);
        }
        if (ValorP53 == 2)
        {
            Instantiate(P2_M, new Vector2(PosX53, myPosY + Intersecciones * 53), transform.rotation);
        }
        if (ValorP53 == 1)
        {
            Instantiate(P3_Q, new Vector2(PosX53, myPosY + Intersecciones * 53), transform.rotation);
        }
        if (ValorP53 == 3)
        {
            Instantiate(P3_M, new Vector2(PosX53, myPosY + Intersecciones * 53), transform.rotation);
        }
        #endregion
        #region Nivel3
        int ValorP54 = Random.Range(0, 4);
        float PosX54 = Random.Range(-2.6f, 2.6f);
        if (ValorP54 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX54, myPosY + Intersecciones * 54), transform.rotation);
        }
        if (ValorP54 == 2)
        {
            Instantiate(P2_M, new Vector2(PosX54, myPosY + Intersecciones * 54), transform.rotation);
        }
        if (ValorP54 == 1)
        {
            Instantiate(P3_Q, new Vector2(PosX54, myPosY + Intersecciones * 54), transform.rotation);
        }
        if (ValorP54 == 3)
        {
            Instantiate(P3_M, new Vector2(PosX54, myPosY + Intersecciones * 54), transform.rotation);
        }
        int ValorP55 = Random.Range(0, 4);
        float PosX55 = Random.Range(-2.6f, 2.6f);
        if (ValorP55 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX55, myPosY + Intersecciones * 55), transform.rotation);
        }
        if (ValorP55 == 2)
        {
            Instantiate(P2_M, new Vector2(PosX55, myPosY + Intersecciones * 55), transform.rotation);
        }
        if (ValorP55 == 1)
        {
            Instantiate(P3_Q, new Vector2(PosX55, myPosY + Intersecciones * 55), transform.rotation);
        }
        if (ValorP55 == 3)
        {
            Instantiate(P3_M, new Vector2(PosX55, myPosY + Intersecciones * 55), transform.rotation);
        }
        int ValorP56 = Random.Range(0, 6);
        float PosX56 = Random.Range(-2.6f, 2.6f);
        if (ValorP56 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX56, myPosY + Intersecciones * 56), transform.rotation);
        }
        if (ValorP56 == 2)
        {
            Instantiate(P2_M, new Vector2(PosX56, myPosY + Intersecciones * 56), transform.rotation);
        }
        if (ValorP56 == 1 || ValorP56 == 5)
        {
            Instantiate(P3_Q, new Vector2(PosX56, myPosY + Intersecciones * 56), transform.rotation);
        }
        if (ValorP56 == 3 || ValorP56 == 4)
        {
            Instantiate(P3_M, new Vector2(PosX56, myPosY + Intersecciones * 56), transform.rotation);
        }
        int ValorP57 = Random.Range(0, 6);
        float PosX57 = Random.Range(-2.6f, 2.6f);
        if (ValorP57 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX57, myPosY + Intersecciones * 57), transform.rotation);
        }
        if (ValorP57 == 2)
        {
            Instantiate(P2_M, new Vector2(PosX57, myPosY + Intersecciones * 57), transform.rotation);
        }
        if (ValorP57 == 1 || ValorP57 == 5)
        {
            Instantiate(P3_Q, new Vector2(PosX57, myPosY + Intersecciones * 57), transform.rotation);
        }
        if (ValorP57 == 3 || ValorP57 == 4)
        {
            Instantiate(P3_M, new Vector2(PosX57, myPosY + Intersecciones * 57), transform.rotation);
        }
        int ValorP58 = Random.Range(0, 8);
        float PosX58 = Random.Range(-2.6f, 2.6f);
        if (ValorP58 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX58, myPosY + Intersecciones * 58), transform.rotation);
        }
        if (ValorP58 == 2)
        {
            Instantiate(P2_M, new Vector2(PosX58, myPosY + Intersecciones * 58), transform.rotation);
        }
        if (ValorP58 == 1 || ValorP58 == 7)
        {
            Instantiate(P3_Q, new Vector2(PosX58, myPosY + Intersecciones * 58), transform.rotation);
        }
        if (ValorP58 == 3 || ValorP58 == 6)
        {
            Instantiate(P3_M, new Vector2(PosX58, myPosY + Intersecciones * 58), transform.rotation);
        }
        if (ValorP58 == 4)
        {
            Instantiate(P3_M_SS, new Vector2(PosX58, myPosY + Intersecciones * 58), transform.rotation);
        }
        if (ValorP58 == 5)
        {
            Instantiate(P3_Q_SS, new Vector2(PosX58, myPosY + Intersecciones * 58), transform.rotation);
        }
        int ValorP59 = Random.Range(0, 8);
        float PosX59 = Random.Range(-2.6f, 2.6f);
        if (ValorP59 == 0)
        {
            Instantiate(P2_Q, new Vector2(PosX59, myPosY + Intersecciones * 59), transform.rotation);
        }
        if (ValorP59 == 2)
        {
            Instantiate(P2_M, new Vector2(PosX59, myPosY + Intersecciones * 59), transform.rotation);
        }
        if (ValorP59 == 1 || ValorP59 == 7)
        {
            Instantiate(P3_Q, new Vector2(PosX59, myPosY + Intersecciones * 59), transform.rotation);
        }
        if (ValorP59 == 3 || ValorP59 == 6)
        {
            Instantiate(P3_M, new Vector2(PosX59, myPosY + Intersecciones * 59), transform.rotation);
        }
        if (ValorP59 == 4)
        {
            Instantiate(P3_M_SS, new Vector2(PosX59, myPosY + Intersecciones * 59), transform.rotation);
        }
        if (ValorP59 == 5)
        {
            Instantiate(P3_Q_SS, new Vector2(PosX59, myPosY + Intersecciones * 59), transform.rotation);
        }
        int ValorP60 = Random.Range(0, 6);
        float PosX60 = Random.Range(-2.6f, 2.6f);
        if (ValorP60 == 0 || ValorP60 == 4)
        {
            Instantiate(P3_Q, new Vector2(PosX60, myPosY + Intersecciones * 60), transform.rotation);
        }
        if (ValorP60 == 1 || ValorP60 == 5)
        {
            Instantiate(P3_M, new Vector2(PosX60, myPosY + Intersecciones * 60), transform.rotation);
        }
        if (ValorP60 == 2)
        {
            Instantiate(P3_M_SS, new Vector2(PosX60, myPosY + Intersecciones * 60), transform.rotation);
        }
        if (ValorP60 == 3)
        {
            Instantiate(P3_Q_SS, new Vector2(PosX60, myPosY + Intersecciones * 60), transform.rotation);
        }
        int ValorP61 = Random.Range(0, 6);
        float PosX61 = Random.Range(-2.6f, 2.6f);
        if (ValorP61 == 0 || ValorP61 == 4)
        {
            Instantiate(P3_Q, new Vector2(PosX61, myPosY + Intersecciones * 61), transform.rotation);
        }
        if (ValorP61 == 1 || ValorP61 == 5)
        {
            Instantiate(P3_M, new Vector2(PosX61, myPosY + Intersecciones * 61), transform.rotation);
        }
        if (ValorP61 == 2)
        {
            Instantiate(P3_M_SS, new Vector2(PosX61, myPosY + Intersecciones * 61), transform.rotation);
        }
        if (ValorP61 == 3)
        {
            Instantiate(P3_Q_SS, new Vector2(PosX61, myPosY + Intersecciones * 61), transform.rotation);
        }
        int ValorP62 = Random.Range(0, 6);
        float PosX62 = Random.Range(-2.6f, 2.6f);
        if (ValorP62 == 0 || ValorP62 == 4)
        {
            Instantiate(P3_Q, new Vector2(PosX62, myPosY + Intersecciones * 62), transform.rotation);
        }
        if (ValorP62 == 1 || ValorP62 == 5)
        {
            Instantiate(P3_M, new Vector2(PosX62, myPosY + Intersecciones * 62), transform.rotation);
        }
        if (ValorP62 == 2)
        {
            Instantiate(P3_M_SS, new Vector2(PosX62, myPosY + Intersecciones * 62), transform.rotation);
        }
        if (ValorP62 == 3)
        {
            Instantiate(P3_Q_SS, new Vector2(PosX62, myPosY + Intersecciones * 62), transform.rotation);
        }
        int ValorP63 = Random.Range(0, 4);
        float PosX63 = Random.Range(-2.6f, 2.6f);
        if (ValorP63 == 0)
        {
            Instantiate(P3_Q, new Vector2(PosX63, myPosY + Intersecciones * 63), transform.rotation);
        }
        if (ValorP63 == 1)
        {
            Instantiate(P3_M, new Vector2(PosX63, myPosY + Intersecciones * 63), transform.rotation);
        }
        if (ValorP63 == 2)
        {
            Instantiate(P3_M_SS, new Vector2(PosX63, myPosY + Intersecciones * 63), transform.rotation);
        }
        if (ValorP63 == 3)
        {
            Instantiate(P3_Q_SS, new Vector2(PosX63, myPosY + Intersecciones * 63), transform.rotation);
        }
        int ValorP64 = Random.Range(0, 4);
        float PosX64 = Random.Range(-2.6f, 2.6f);
        if (ValorP64 == 0)
        {
            Instantiate(P3_Q, new Vector2(PosX64, myPosY + Intersecciones * 64), transform.rotation);
        }
        if (ValorP64 == 1)
        {
            Instantiate(P3_M, new Vector2(PosX64, myPosY + Intersecciones * 64), transform.rotation);
        }
        if (ValorP64 == 2)
        {
            Instantiate(P3_M_SS, new Vector2(PosX64, myPosY + Intersecciones * 64), transform.rotation);
        }
        if (ValorP64 == 3)
        {
            Instantiate(P3_Q_SS, new Vector2(PosX64, myPosY + Intersecciones * 64), transform.rotation);
        }
        int ValorP65 = Random.Range(0, 4);
        float PosX65 = Random.Range(-2.6f, 2.6f);
        if (ValorP65 == 0)
        {
            Instantiate(P3_Q, new Vector2(PosX65, myPosY + Intersecciones * 65), transform.rotation);
        }
        if (ValorP65 == 1)
        {
            Instantiate(P3_M, new Vector2(PosX65, myPosY + Intersecciones * 65), transform.rotation);
        }
        if (ValorP65 == 2)
        {
            Instantiate(P3_M_SS, new Vector2(PosX65, myPosY + Intersecciones * 65), transform.rotation);
        }
        if (ValorP65 == 3)
        {
            Instantiate(P3_Q_SS, new Vector2(PosX65, myPosY + Intersecciones * 65), transform.rotation);
        }
        int ValorP66 = Random.Range(0, 4);
        float PosX66 = Random.Range(-2.6f, 2.6f);
        if (ValorP66 == 0)
        {
            Instantiate(P3_Q, new Vector2(PosX66, myPosY + Intersecciones * 66), transform.rotation);
        }
        if (ValorP66 == 1)
        {
            Instantiate(P3_M, new Vector2(PosX66, myPosY + Intersecciones * 66), transform.rotation);
        }
        if (ValorP66 == 2)
        {
            Instantiate(P3_M_SS, new Vector2(PosX66, myPosY + Intersecciones * 66), transform.rotation);
        }
        if (ValorP66 == 3)
        {
            Instantiate(P3_Q_SS, new Vector2(PosX66, myPosY + Intersecciones * 66), transform.rotation);
        }
        int ValorP67 = Random.Range(0, 4);
        float PosX67 = Random.Range(-2.6f, 2.6f);
        if (ValorP67 == 0)
        {
            Instantiate(P3_Q, new Vector2(PosX67, myPosY + Intersecciones * 67), transform.rotation);
        }
        if (ValorP67 == 1)
        {
            Instantiate(P3_M, new Vector2(PosX67, myPosY + Intersecciones * 67), transform.rotation);
        }
        if (ValorP67 == 2)
        {
            Instantiate(P3_M_SS, new Vector2(PosX67, myPosY + Intersecciones * 67), transform.rotation);
        }
        if (ValorP67 == 3)
        {
            Instantiate(P3_Q_SS, new Vector2(PosX67, myPosY + Intersecciones * 67), transform.rotation);
        }
        int ValorP68 = Random.Range(0, 5);
        float PosX68 = Random.Range(-2.6f, 2.6f);
        if (ValorP68 == 0)
        {
            Instantiate(P3_Q, new Vector2(PosX68, myPosY + Intersecciones * 68), transform.rotation);
        }
        if (ValorP68 == 1 || ValorP68 == 4)
        {
            Instantiate(P3_M, new Vector2(PosX68, myPosY + Intersecciones * 68), transform.rotation);
        }
        if (ValorP68 == 2)
        {
            Instantiate(P3_M_SS, new Vector2(PosX68, myPosY + Intersecciones * 68), transform.rotation);
        }
        if (ValorP68 == 3)
        {
            Instantiate(P3_Q_SS, new Vector2(PosX68, myPosY + Intersecciones * 68), transform.rotation);
        }
        int ValorP69 = Random.Range(0, 5);
        float PosX69 = Random.Range(-2.6f, 2.6f);
        if (ValorP69 == 0)
        {
            Instantiate(P3_Q, new Vector2(PosX69, myPosY + Intersecciones * 69), transform.rotation);
        }
        if (ValorP69 == 1 || ValorP69 == 4)
        {
            Instantiate(P3_M, new Vector2(PosX69, myPosY + Intersecciones * 69), transform.rotation);
        }
        if (ValorP69 == 2)
        {
            Instantiate(P3_M_SS, new Vector2(PosX69, myPosY + Intersecciones * 69), transform.rotation);
        }
        if (ValorP69 == 3)
        {
            Instantiate(P3_Q_SS, new Vector2(PosX69, myPosY + Intersecciones * 69), transform.rotation);
        }
        int ValorP70 = Random.Range(0, 5);
        float PosX70 = Random.Range(-2.6f, 2.6f);
        if (ValorP70 == 0)
        {
            Instantiate(P3_Q, new Vector2(PosX70, myPosY + Intersecciones * 70), transform.rotation);
        }
        if (ValorP70 == 1 || ValorP70 == 4)
        {
            Instantiate(P3_M, new Vector2(PosX70, myPosY + Intersecciones * 70), transform.rotation);
        }
        if (ValorP70 == 2)
        {
            Instantiate(P3_M_SS, new Vector2(PosX70, myPosY + Intersecciones * 70), transform.rotation);
        }
        if (ValorP70 == 3)
        {
            Instantiate(P3_Q_SS, new Vector2(PosX70, myPosY + Intersecciones * 70), transform.rotation);
        }
        int ValorP71 = Random.Range(0, 5);
        float PosX71 = Random.Range(-2.6f, 2.6f);
        if (ValorP71 == 0)
        {
            Instantiate(P3_Q, new Vector2(PosX71, myPosY + Intersecciones * 71), transform.rotation);
        }
        if (ValorP71 == 1 || ValorP71 == 4)
        {
            Instantiate(P3_M, new Vector2(PosX71, myPosY + Intersecciones * 71), transform.rotation);
        }
        if (ValorP71 == 2)
        {
            Instantiate(P3_M_SS, new Vector2(PosX71, myPosY + Intersecciones * 71), transform.rotation);
        }
        if (ValorP71 == 3)
        {
            Instantiate(P3_Q_SS, new Vector2(PosX71, myPosY + Intersecciones * 71), transform.rotation);
        }
        int ValorP72 = Random.Range(0, 5);
        float PosX72 = Random.Range(-2.6f, 2.6f);
        if (ValorP72 == 0)
        {
            Instantiate(P3_Q, new Vector2(PosX72, myPosY + Intersecciones * 72), transform.rotation);
        }
        if (ValorP72 == 1 || ValorP72 == 4)
        {
            Instantiate(P3_M, new Vector2(PosX72, myPosY + Intersecciones * 72), transform.rotation);
        }
        if (ValorP72 == 2)
        {
            Instantiate(P3_M_SS, new Vector2(PosX72, myPosY + Intersecciones * 72), transform.rotation);
        }
        if (ValorP72 == 3)
        {
            Instantiate(P3_Q_SS, new Vector2(PosX72, myPosY + Intersecciones * 72), transform.rotation);
        }
        int ValorP73 = Random.Range(0, 5);
        float PosX73 = Random.Range(-2.6f, 2.6f);
        if (ValorP73 == 0)
        {
            Instantiate(P3_Q, new Vector2(PosX73, myPosY + Intersecciones * 73), transform.rotation);
        }
        if (ValorP73 == 1 || ValorP73 == 4)
        {
            Instantiate(P3_M, new Vector2(PosX73, myPosY + Intersecciones * 73), transform.rotation);
        }
        if (ValorP73 == 2)
        {
            Instantiate(P3_M_SS, new Vector2(PosX73, myPosY + Intersecciones * 73), transform.rotation);
        }
        if (ValorP73 == 3)
        {
            Instantiate(P3_Q_SS, new Vector2(PosX73, myPosY + Intersecciones * 73), transform.rotation);
        }
        int ValorP74 = Random.Range(0, 5);
        float PosX74 = Random.Range(-2.6f, 2.6f);
        if (ValorP74 == 0)
        {
            Instantiate(P3_Q, new Vector2(PosX74, myPosY + Intersecciones * 74), transform.rotation);
        }
        if (ValorP74 == 1 || ValorP74 == 4)
        {
            Instantiate(P3_M, new Vector2(PosX74, myPosY + Intersecciones * 74), transform.rotation);
        }
        if (ValorP74 == 2)
        {
            Instantiate(P3_M_SS, new Vector2(PosX74, myPosY + Intersecciones * 74), transform.rotation);
        }
        if (ValorP74 == 3)
        {
            Instantiate(P3_Q_SS, new Vector2(PosX74, myPosY + Intersecciones * 74), transform.rotation);
        }
        int ValorP75 = Random.Range(0, 5);
        float PosX75 = Random.Range(-2.6f, 2.6f);
        if (ValorP75 == 0)
        {
            Instantiate(P3_Q, new Vector2(PosX75, myPosY + Intersecciones * 75), transform.rotation);
        }
        if (ValorP75 == 1 || ValorP75 == 4)
        {
            Instantiate(P3_M, new Vector2(PosX75, myPosY + Intersecciones * 75), transform.rotation);
        }
        if (ValorP75 == 2)
        {
            Instantiate(P3_M_SS, new Vector2(PosX75, myPosY + Intersecciones * 75), transform.rotation);
        }
        if (ValorP75 == 3)
        {
            Instantiate(P3_Q_SS, new Vector2(PosX75, myPosY + Intersecciones * 75), transform.rotation);
        }
        int ValorP76 = Random.Range(0, 5);
        float PosX76 = Random.Range(-2.6f, 2.6f);
        if (ValorP76 == 0)
        {
            Instantiate(P3_Q, new Vector2(PosX76, myPosY + Intersecciones * 76), transform.rotation);
        }
        if (ValorP76 == 1 || ValorP76 == 4)
        {
            Instantiate(P3_M, new Vector2(PosX76, myPosY + Intersecciones * 76), transform.rotation);
        }
        if (ValorP76 == 2)
        {
            Instantiate(P3_M_SS, new Vector2(PosX76, myPosY + Intersecciones * 76), transform.rotation);
        }
        if (ValorP76 == 3)
        {
            Instantiate(P3_Q_SS, new Vector2(PosX76, myPosY + Intersecciones * 76), transform.rotation);
        }
        int ValorP77 = Random.Range(0, 5);
        float PosX77 = Random.Range(-2.6f, 2.6f);
        if (ValorP77 == 0)
        {
            Instantiate(P3_Q, new Vector2(PosX77, myPosY + Intersecciones * 77), transform.rotation);
        }
        if (ValorP77 == 1 || ValorP77 == 4)
        {
            Instantiate(P3_M, new Vector2(PosX77, myPosY + Intersecciones * 77), transform.rotation);
        }
        if (ValorP77 == 2)
        {
            Instantiate(P3_M_SS, new Vector2(PosX77, myPosY + Intersecciones * 77), transform.rotation);
        }
        if (ValorP77 == 3)
        {
            Instantiate(P3_Q_SS, new Vector2(PosX77, myPosY + Intersecciones * 77), transform.rotation);
        }
        int ValorP78 = Random.Range(0, 6);
        float PosX78 = Random.Range(-2.6f, 2.6f);
        if (ValorP78 == 0)
        {
            Instantiate(P3_Q, new Vector2(PosX78, myPosY + Intersecciones * 78), transform.rotation);
        }
        if (ValorP78 == 1)
        {
            Instantiate(P3_M, new Vector2(PosX78, myPosY + Intersecciones * 78), transform.rotation);
        }
        if (ValorP78 == 2)
        {
            Instantiate(P3_M_SS, new Vector2(PosX78, myPosY + Intersecciones * 78), transform.rotation);
        }
        if (ValorP78 == 3)
        {
            Instantiate(P3_Q_SS, new Vector2(PosX78, myPosY + Intersecciones * 78), transform.rotation);
        }
        if (ValorP78 == 6)
        {
            Instantiate(P4_M, new Vector2(PosX78, myPosY + Intersecciones * 78), transform.rotation);
        }
        if (ValorP78 == 5)
        {
            Instantiate(P4_Q, new Vector2(PosX78, myPosY + Intersecciones * 78), transform.rotation);
        }
        int ValorP79 = Random.Range(0, 6);
        float PosX79 = Random.Range(-2.6f, 2.6f);
        if (ValorP79 == 0)
        {
            Instantiate(P3_Q, new Vector2(PosX79, myPosY + Intersecciones * 79), transform.rotation);
        }
        if (ValorP79 == 1)
        {
            Instantiate(P3_M, new Vector2(PosX79, myPosY + Intersecciones * 79), transform.rotation);
        }
        if (ValorP79 == 2)
        {
            Instantiate(P3_M_SS, new Vector2(PosX79, myPosY + Intersecciones * 79), transform.rotation);
        }
        if (ValorP79 == 3)
        {
            Instantiate(P3_Q_SS, new Vector2(PosX79, myPosY + Intersecciones * 79), transform.rotation);
        }
        if (ValorP79 == 4)
        {
            Instantiate(P4_M, new Vector2(PosX79, myPosY + Intersecciones * 79), transform.rotation);
        }
        if (ValorP79 == 5)
        {
            Instantiate(P4_Q, new Vector2(PosX79, myPosY + Intersecciones * 79), transform.rotation);
        }
        int ValorP80 = Random.Range(0, 6);
        float PosX80 = Random.Range(-2.6f, 2.6f);
        if (ValorP80 == 0)
        {
            Instantiate(P3_Q, new Vector2(PosX80, myPosY + Intersecciones * 80), transform.rotation);
        }
        if (ValorP80 == 1)
        {
            Instantiate(P3_M, new Vector2(PosX80, myPosY + Intersecciones * 80), transform.rotation);
        }
        if (ValorP80 == 2)
        {
            Instantiate(P3_M_SS, new Vector2(PosX80, myPosY + Intersecciones * 80), transform.rotation);
        }
        if (ValorP80 == 3)
        {
            Instantiate(P3_Q_SS, new Vector2(PosX80, myPosY + Intersecciones * 80), transform.rotation);
        }
        if (ValorP80 == 4)
        {
            Instantiate(P4_M, new Vector2(PosX80, myPosY + Intersecciones * 80), transform.rotation);
        }
        if (ValorP80 == 5)
        {
            Instantiate(P4_Q, new Vector2(PosX80, myPosY + Intersecciones * 80), transform.rotation);
        }
        int ValorP81 = Random.Range(0, 6);
        float PosX81 = Random.Range(-2.6f, 2.6f);
        if (ValorP81 == 0)
        {
            Instantiate(P3_Q, new Vector2(PosX81, myPosY + Intersecciones * 81), transform.rotation);
        }
        if (ValorP81 == 1)
        {
            Instantiate(P3_M, new Vector2(PosX81, myPosY + Intersecciones * 81), transform.rotation);
        }
        if (ValorP81 == 2)
        {
            Instantiate(P3_M_SS, new Vector2(PosX81, myPosY + Intersecciones * 81), transform.rotation);
        }
        if (ValorP81 == 3)
        {
            Instantiate(P3_Q_SS, new Vector2(PosX81, myPosY + Intersecciones * 81), transform.rotation);
        }
        if (ValorP81 == 4)
        {
            Instantiate(P4_M, new Vector2(PosX81, myPosY + Intersecciones * 81), transform.rotation);
        }
        if (ValorP81 == 5)
        {
            Instantiate(P4_Q, new Vector2(PosX81, myPosY + Intersecciones * 81), transform.rotation);
        }
        int ValorP82 = Random.Range(0, 6);
        float PosX82 = Random.Range(-2.6f, 2.6f);
        if (ValorP82 == 0)
        {
            Instantiate(P3_Q, new Vector2(PosX82, myPosY + Intersecciones * 82), transform.rotation);
        }
        if (ValorP82 == 1)
        {
            Instantiate(P3_M, new Vector2(PosX82, myPosY + Intersecciones * 82), transform.rotation);
        }
        if (ValorP82 == 2)
        {
            Instantiate(P3_M_SS, new Vector2(PosX82, myPosY + Intersecciones * 82), transform.rotation);
        }
        if (ValorP82 == 3)
        {
            Instantiate(P3_Q_SS, new Vector2(PosX82, myPosY + Intersecciones * 82), transform.rotation);
        }
        if (ValorP82 == 4)
        {
            Instantiate(P4_M, new Vector2(PosX82, myPosY + Intersecciones * 82), transform.rotation);
        }
        if (ValorP82 == 5)
        {
            Instantiate(P4_Q, new Vector2(PosX82, myPosY + Intersecciones * 82), transform.rotation);
        }
        #endregion
        #region Nivel4
        int ValorP83 = Random.Range(0, 4);
        float PosX83 = Random.Range(-2.6f, 2.6f);
        if (ValorP83 == 0)
        {
            Instantiate(P3_Q, new Vector2(PosX83, myPosY + Intersecciones * 83), transform.rotation);
        }
        if (ValorP83 == 1)
        {
            Instantiate(P3_M, new Vector2(PosX83, myPosY + Intersecciones * 83), transform.rotation);
        }
        if (ValorP83 == 2)
        {
            Instantiate(P4_M, new Vector2(PosX83, myPosY + Intersecciones * 83), transform.rotation);
        }
        if (ValorP83 == 3)
        {
            Instantiate(P4_Q, new Vector2(PosX83, myPosY + Intersecciones * 83), transform.rotation);
        }
        int ValorP84 = Random.Range(0, 4);
        float PosX84 = Random.Range(-2.6f, 2.6f);
        if (ValorP84 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX84, myPosY + Intersecciones * 84), transform.rotation);
        }
        if (ValorP84 == 1)
        {
            Instantiate(P4_Q, new Vector2(PosX84, myPosY + Intersecciones * 84), transform.rotation);
        }
        if (ValorP84 == 2)
        {
            Instantiate(P4_M_SS, new Vector2(PosX84, myPosY + Intersecciones * 84), transform.rotation);
        }
        if (ValorP84 == 3)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX84, myPosY + Intersecciones * 84), transform.rotation);
        }
        int ValorP85 = Random.Range(0, 4);
        float PosX85 = Random.Range(-2.6f, 2.6f);
        if (ValorP85 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX85, myPosY + Intersecciones * 85), transform.rotation);
        }
        if (ValorP85 == 1)
        {
            Instantiate(P4_Q, new Vector2(PosX85, myPosY + Intersecciones * 85), transform.rotation);
        }
        if (ValorP85 == 2)
        {
            Instantiate(P4_M_SS, new Vector2(PosX85, myPosY + Intersecciones * 85), transform.rotation);
        }
        if (ValorP85 == 3)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX85, myPosY + Intersecciones * 85), transform.rotation);
        }
        int ValorP86 = Random.Range(0, 4);
        float PosX86 = Random.Range(-2.6f, 2.6f);
        if (ValorP86 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX86, myPosY + Intersecciones * 86), transform.rotation);
        }
        if (ValorP86 == 1)
        {
            Instantiate(P4_Q, new Vector2(PosX86, myPosY + Intersecciones * 86), transform.rotation);
        }
        if (ValorP86 == 2)
        {
            Instantiate(P4_M_SS, new Vector2(PosX86, myPosY + Intersecciones * 86), transform.rotation);
        }
        if (ValorP86 == 3)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX86, myPosY + Intersecciones * 86), transform.rotation);
        }
        int ValorP87 = Random.Range(0, 4);
        float PosX87 = Random.Range(-2.6f, 2.6f);
        if (ValorP87 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX87, myPosY + Intersecciones * 87), transform.rotation);
        }
        if (ValorP87 == 1)
        {
            Instantiate(P4_Q, new Vector2(PosX87, myPosY + Intersecciones * 87), transform.rotation);
        }
        if (ValorP87 == 2)
        {
            Instantiate(P4_M_SS, new Vector2(PosX87, myPosY + Intersecciones * 87), transform.rotation);
        }
        if (ValorP87 == 3)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX87, myPosY + Intersecciones * 87), transform.rotation);
        }
        int ValorP88 = Random.Range(0, 4);
        float PosX88 = Random.Range(-2.6f, 2.6f);
        if (ValorP88 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX88, myPosY + Intersecciones * 88), transform.rotation);
        }
        if (ValorP88 == 1)
        {
            Instantiate(P4_Q, new Vector2(PosX88, myPosY + Intersecciones * 88), transform.rotation);
        }
        if (ValorP88 == 2)
        {
            Instantiate(P4_M_SS, new Vector2(PosX88, myPosY + Intersecciones * 88), transform.rotation);
        }
        if (ValorP88 == 3)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX88, myPosY + Intersecciones * 88), transform.rotation);
        }
        int ValorP89 = Random.Range(0, 4);
        float PosX89 = Random.Range(-2.6f, 2.6f);
        if (ValorP89 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX89, myPosY + Intersecciones * 89), transform.rotation);
        }
        if (ValorP89 == 1)
        {
            Instantiate(P4_Q, new Vector2(PosX89, myPosY + Intersecciones * 89), transform.rotation);
        }
        if (ValorP89 == 2)
        {
            Instantiate(P4_M_SS, new Vector2(PosX89, myPosY + Intersecciones * 89), transform.rotation);
        }
        if (ValorP89 == 3)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX89, myPosY + Intersecciones * 89), transform.rotation);
        }
        int ValorP90 = Random.Range(0, 4);
        float PosX90 = Random.Range(-2.6f, 2.6f);
        if (ValorP90 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX90, myPosY + Intersecciones * 90), transform.rotation);
        }
        if (ValorP90 == 1)
        {
            Instantiate(P4_Q, new Vector2(PosX90, myPosY + Intersecciones * 90), transform.rotation);
        }
        if (ValorP90 == 2)
        {
            Instantiate(P4_M_SS, new Vector2(PosX90, myPosY + Intersecciones * 90), transform.rotation);
        }
        if (ValorP90 == 3)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX90, myPosY + Intersecciones * 90), transform.rotation);
        }
        int ValorP91 = Random.Range(0, 4);
        float PosX91 = Random.Range(-2.6f, 2.6f);
        if (ValorP91 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX91, myPosY + Intersecciones * 91), transform.rotation);
        }
        if (ValorP91 == 1)
        {
            Instantiate(P4_Q, new Vector2(PosX91, myPosY + Intersecciones * 91), transform.rotation);
        }
        if (ValorP91 == 2)
        {
            Instantiate(P4_M_SS, new Vector2(PosX91, myPosY + Intersecciones * 91), transform.rotation);
        }
        if (ValorP91 == 3)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX91, myPosY + Intersecciones * 91), transform.rotation);
        }
        int ValorP92 = Random.Range(0, 4);
        float PosX92 = Random.Range(-2.6f, 2.6f);
        if (ValorP92 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX92, myPosY + Intersecciones * 92), transform.rotation);
        }
        if (ValorP92 == 1)
        {
            Instantiate(P4_Q, new Vector2(PosX92, myPosY + Intersecciones * 92), transform.rotation);
        }
        if (ValorP92 == 2)
        {
            Instantiate(P4_M_SS, new Vector2(PosX92, myPosY + Intersecciones * 92), transform.rotation);
        }
        if (ValorP92 == 3)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX92, myPosY + Intersecciones * 92), transform.rotation);
        }
        int ValorP93 = Random.Range(0, 4);
        float PosX93 = Random.Range(-2.6f, 2.6f);
        if (ValorP93 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX93, myPosY + Intersecciones * 93), transform.rotation);
        }
        if (ValorP93 == 1)
        {
            Instantiate(P4_Q, new Vector2(PosX93, myPosY + Intersecciones * 93), transform.rotation);
        }
        if (ValorP93 == 2)
        {
            Instantiate(P4_M_SS, new Vector2(PosX93, myPosY + Intersecciones * 93), transform.rotation);
        }
        if (ValorP93 == 3)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX93, myPosY + Intersecciones * 93), transform.rotation);
        }
        int ValorP94 = Random.Range(0, 4);
        float PosX94 = Random.Range(-2.6f, 2.6f);
        if (ValorP94 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX94, myPosY + Intersecciones * 94), transform.rotation);
        }
        if (ValorP94 == 1)
        {
            Instantiate(P4_Q, new Vector2(PosX94, myPosY + Intersecciones * 94), transform.rotation);
        }
        if (ValorP94 == 2)
        {
            Instantiate(P4_M_SS, new Vector2(PosX94, myPosY + Intersecciones * 94), transform.rotation);
        }
        if (ValorP94 == 3)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX94, myPosY + Intersecciones * 94), transform.rotation);
        }
        int ValorP95 = Random.Range(0, 4);
        float PosX95 = Random.Range(-2.6f, 2.6f);
        if (ValorP95 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX95, myPosY + Intersecciones * 95), transform.rotation);
        }
        if (ValorP95 == 1)
        {
            Instantiate(P4_Q, new Vector2(PosX95, myPosY + Intersecciones * 95), transform.rotation);
        }
        if (ValorP95 == 2)
        {
            Instantiate(P4_M_SS, new Vector2(PosX95, myPosY + Intersecciones * 95), transform.rotation);
        }
        if (ValorP95 == 3)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX95, myPosY + Intersecciones * 95), transform.rotation);
        }
        int ValorP96 = Random.Range(0, 4);
        float PosX96 = Random.Range(-2.6f, 2.6f);
        if (ValorP96 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX96, myPosY + Intersecciones * 96), transform.rotation);
        }
        if (ValorP96 == 1)
        {
            Instantiate(P4_Q, new Vector2(PosX96, myPosY + Intersecciones * 96), transform.rotation);
        }
        if (ValorP96 == 2)
        {
            Instantiate(P4_M_SS, new Vector2(PosX96, myPosY + Intersecciones * 96), transform.rotation);
        }
        if (ValorP96 == 3)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX96, myPosY + Intersecciones * 96), transform.rotation);
        }
        int ValorP97 = Random.Range(0, 4);
        float PosX97 = Random.Range(-2.6f, 2.6f);
        if (ValorP97 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX97, myPosY + Intersecciones * 97), transform.rotation);
        }
        if (ValorP97 == 1)
        {
            Instantiate(P4_Q, new Vector2(PosX97, myPosY + Intersecciones * 97), transform.rotation);
        }
        if (ValorP97 == 2)
        {
            Instantiate(P4_M_SS, new Vector2(PosX97, myPosY + Intersecciones * 97), transform.rotation);
        }
        if (ValorP97 == 3)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX97, myPosY + Intersecciones * 97), transform.rotation);
        }
        int ValorP98 = Random.Range(0, 4);
        float PosX98 = Random.Range(-2.6f, 2.6f);
        if (ValorP98 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX98, myPosY + Intersecciones * 98), transform.rotation);
        }
        if (ValorP98 == 1)
        {
            Instantiate(P4_Q, new Vector2(PosX98, myPosY + Intersecciones * 98), transform.rotation);
        }
        if (ValorP98 == 2)
        {
            Instantiate(P4_M_SS, new Vector2(PosX98, myPosY + Intersecciones * 98), transform.rotation);
        }
        if (ValorP98 == 3)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX98, myPosY + Intersecciones * 98), transform.rotation);
        }
        int ValorP99 = Random.Range(0, 4);
        float PosX99 = Random.Range(-2.6f, 2.6f);
        if (ValorP99 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX99, myPosY + Intersecciones * 99), transform.rotation);
        }
        if (ValorP99 == 1)
        {
            Instantiate(P4_Q, new Vector2(PosX99, myPosY + Intersecciones * 99), transform.rotation);
        }
        if (ValorP99 == 2)
        {
            Instantiate(P4_M_SS, new Vector2(PosX99, myPosY + Intersecciones * 99), transform.rotation);
        }
        if (ValorP99 == 3)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX99, myPosY + Intersecciones * 99), transform.rotation);
        }
        int ValorP100 = Random.Range(0, 4);
        float PosX100 = Random.Range(-2.6f, 2.6f);
        if (ValorP100 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX100, myPosY + Intersecciones * 100), transform.rotation);
        }
        if (ValorP100 == 1)
        {
            Instantiate(P4_Q, new Vector2(PosX100, myPosY + Intersecciones * 100), transform.rotation);
        }
        if (ValorP100 == 2)
        {
            Instantiate(P4_M_SS, new Vector2(PosX100, myPosY + Intersecciones * 100), transform.rotation);
        }
        if (ValorP100 == 3)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX100, myPosY + Intersecciones * 100), transform.rotation);
        }
        int ValorP101 = Random.Range(0, 4);
        float PosX101 = Random.Range(-2.6f, 2.6f);
        if (ValorP101 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX101, myPosY + Intersecciones * 101), transform.rotation);
        }
        if (ValorP101 == 1)
        {
            Instantiate(P4_Q, new Vector2(PosX101, myPosY + Intersecciones * 101), transform.rotation);
        }
        if (ValorP101 == 2)
        {
            Instantiate(P4_M_SS, new Vector2(PosX101, myPosY + Intersecciones * 101), transform.rotation);
        }
        if (ValorP101 == 3)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX101, myPosY + Intersecciones * 101), transform.rotation);
        }
        int ValorP102 = Random.Range(0, 4);
        float PosX102 = Random.Range(-2.6f, 2.6f);
        if (ValorP102 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX102, myPosY + Intersecciones * 102), transform.rotation);
        }
        if (ValorP102 == 1)
        {
            Instantiate(P4_Q, new Vector2(PosX102, myPosY + Intersecciones * 102), transform.rotation);
        }
        if (ValorP102 == 2)
        {
            Instantiate(P4_M_SS, new Vector2(PosX102, myPosY + Intersecciones * 102), transform.rotation);
        }
        if (ValorP102 == 3)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX102, myPosY + Intersecciones * 102), transform.rotation);
        }
        int ValorP103 = Random.Range(0, 4);
        float PosX103 = Random.Range(-2.6f, 2.6f);
        if (ValorP103 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX103, myPosY + Intersecciones * 103), transform.rotation);
        }
        if (ValorP103 == 1)
        {
            Instantiate(P4_Q, new Vector2(PosX103, myPosY + Intersecciones * 103), transform.rotation);
        }
        if (ValorP103 == 2)
        {
            Instantiate(P4_M_SS, new Vector2(PosX103, myPosY + Intersecciones * 103), transform.rotation);
        }
        if (ValorP103 == 3)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX103, myPosY + Intersecciones * 103), transform.rotation);
        }
        int ValorP104 = Random.Range(0, 4);
        float PosX104 = Random.Range(-2.6f, 2.6f);
        if (ValorP104 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX104, myPosY + Intersecciones * 104), transform.rotation);
        }
        if (ValorP104 == 1)
        {
            Instantiate(P4_Q, new Vector2(PosX104, myPosY + Intersecciones * 104), transform.rotation);
        }
        if (ValorP104 == 2)
        {
            Instantiate(P4_M_SS, new Vector2(PosX104, myPosY + Intersecciones * 104), transform.rotation);
        }
        if (ValorP104 == 3)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX104, myPosY + Intersecciones * 104), transform.rotation);
        }
        int ValorP105 = Random.Range(0, 4);
        float PosX105 = Random.Range(-2.6f, 2.6f);
        if (ValorP105 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX105, myPosY + Intersecciones * 105), transform.rotation);
        }
        if (ValorP105 == 1)
        {
            Instantiate(P4_Q, new Vector2(PosX105, myPosY + Intersecciones * 105), transform.rotation);
        }
        if (ValorP105 == 2)
        {
            Instantiate(P4_M_SS, new Vector2(PosX105, myPosY + Intersecciones * 105), transform.rotation);
        }
        if (ValorP105 == 3)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX105, myPosY + Intersecciones * 105), transform.rotation);
        }
        int ValorP106 = Random.Range(0, 4);
        float PosX106 = Random.Range(-2.6f, 2.6f);
        if (ValorP106 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX106, myPosY + Intersecciones * 106), transform.rotation);
        }
        if (ValorP106 == 1)
        {
            Instantiate(P4_Q, new Vector2(PosX106, myPosY + Intersecciones * 106), transform.rotation);
        }
        if (ValorP106 == 2)
        {
            Instantiate(P4_M_SS, new Vector2(PosX106, myPosY + Intersecciones * 106), transform.rotation);
        }
        if (ValorP106 == 3)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX106, myPosY + Intersecciones * 106), transform.rotation);
        }
        int ValorP107 = Random.Range(0, 4);
        float PosX107 = Random.Range(-2.6f, 2.6f);
        if (ValorP107 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX107, myPosY + Intersecciones * 107), transform.rotation);
        }
        if (ValorP107 == 1)
        {
            Instantiate(P4_Q, new Vector2(PosX107, myPosY + Intersecciones * 107), transform.rotation);
        }
        if (ValorP107 == 2)
        {
            Instantiate(P4_M_SS, new Vector2(PosX107, myPosY + Intersecciones * 107), transform.rotation);
        }
        if (ValorP107 == 3)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX107, myPosY + Intersecciones * 107), transform.rotation);
        }
        int ValorP108 = Random.Range(0, 4);
        float PosX108 = Random.Range(-2.6f, 2.6f);
        if (ValorP108 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX108, myPosY + Intersecciones * 108), transform.rotation);
        }
        if (ValorP108 == 1)
        {
            Instantiate(P4_Q, new Vector2(PosX108, myPosY + Intersecciones * 108), transform.rotation);
        }
        if (ValorP108 == 2)
        {
            Instantiate(P4_M_SS, new Vector2(PosX108, myPosY + Intersecciones * 108), transform.rotation);
        }
        if (ValorP108 == 3)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX108, myPosY + Intersecciones * 108), transform.rotation);
        }
        int ValorP109 = Random.Range(0, 8);
        float PosX109 = Random.Range(-2.6f, 2.6f);
        if (ValorP109 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX109, myPosY + Intersecciones * 109), transform.rotation);
        }
        if (ValorP109 == 2)
        {
            Instantiate(P4_Q, new Vector2(PosX109, myPosY + Intersecciones * 109), transform.rotation);
        }
        if (ValorP109 == 4)
        {
            Instantiate(P4_M_SS, new Vector2(PosX109, myPosY + Intersecciones * 109), transform.rotation);
        }
        if (ValorP109 == 6)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX109, myPosY + Intersecciones * 109), transform.rotation);
        }
        if (ValorP109 == 1)
        {
            Instantiate(P5_M, new Vector2(PosX109, myPosY + Intersecciones * 109), transform.rotation);
        }
        if (ValorP109 == 3)
        {
            Instantiate(P5_Q, new Vector2(PosX109, myPosY + Intersecciones * 109), transform.rotation);
        }
        if (ValorP109 == 5)
        {
            Instantiate(P5_M_SS, new Vector2(PosX109, myPosY + Intersecciones * 109), transform.rotation);
        }
        if (ValorP109 == 7)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX109, myPosY + Intersecciones * 109), transform.rotation);
        }
        int ValorP110 = Random.Range(0, 8);
        float PosX110 = Random.Range(-2.6f, 2.6f);
        if (ValorP110 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX110, myPosY + Intersecciones * 110), transform.rotation);
        }
        if (ValorP110 == 2)
        {
            Instantiate(P4_Q, new Vector2(PosX110, myPosY + Intersecciones * 110), transform.rotation);
        }
        if (ValorP110 == 4)
        {
            Instantiate(P4_M_SS, new Vector2(PosX110, myPosY + Intersecciones * 110), transform.rotation);
        }
        if (ValorP110 == 6)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX110, myPosY + Intersecciones * 110), transform.rotation);
        }
        if (ValorP110 == 1)
        {
            Instantiate(P5_M, new Vector2(PosX110, myPosY + Intersecciones * 110), transform.rotation);
        }
        if (ValorP110 == 3)
        {
            Instantiate(P5_Q, new Vector2(PosX110, myPosY + Intersecciones * 110), transform.rotation);
        }
        if (ValorP110 == 5)
        {
            Instantiate(P5_M_SS, new Vector2(PosX110, myPosY + Intersecciones * 110), transform.rotation);
        }
        if (ValorP110 == 7)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX110, myPosY + Intersecciones * 110), transform.rotation);
        }
        int ValorP111 = Random.Range(0, 8);
        float PosX111 = Random.Range(-2.6f, 2.6f);
        if (ValorP111 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX111, myPosY + Intersecciones * 111), transform.rotation);
        }
        if (ValorP111 == 2)
        {
            Instantiate(P4_Q, new Vector2(PosX111, myPosY + Intersecciones * 111), transform.rotation);
        }
        if (ValorP111 == 4)
        {
            Instantiate(P4_M_SS, new Vector2(PosX111, myPosY + Intersecciones * 111), transform.rotation);
        }
        if (ValorP111 == 6)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX111, myPosY + Intersecciones * 111), transform.rotation);
        }
        if (ValorP111 == 1)
        {
            Instantiate(P5_M, new Vector2(PosX111, myPosY + Intersecciones * 111), transform.rotation);
        }
        if (ValorP111 == 3)
        {
            Instantiate(P5_Q, new Vector2(PosX111, myPosY + Intersecciones * 111), transform.rotation);
        }
        if (ValorP111 == 5)
        {
            Instantiate(P5_M_SS, new Vector2(PosX111, myPosY + Intersecciones * 111), transform.rotation);
        }
        if (ValorP111 == 7)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX111, myPosY + Intersecciones * 111), transform.rotation);
        }
        int ValorP112 = Random.Range(0, 8);
        float PosX112 = Random.Range(-2.6f, 2.6f);
        if (ValorP112 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX112, myPosY + Intersecciones * 112), transform.rotation);
        }
        if (ValorP112 == 2)
        {
            Instantiate(P4_Q, new Vector2(PosX112, myPosY + Intersecciones * 112), transform.rotation);
        }
        if (ValorP112 == 4)
        {
            Instantiate(P4_M_SS, new Vector2(PosX112, myPosY + Intersecciones * 112), transform.rotation);
        }
        if (ValorP112 == 6)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX112, myPosY + Intersecciones * 112), transform.rotation);
        }
        if (ValorP112 == 1)
        {
            Instantiate(P5_M, new Vector2(PosX112, myPosY + Intersecciones * 112), transform.rotation);
        }
        if (ValorP112 == 3)
        {
            Instantiate(P5_Q, new Vector2(PosX112, myPosY + Intersecciones * 112), transform.rotation);
        }
        if (ValorP112 == 5)
        {
            Instantiate(P5_M_SS, new Vector2(PosX112, myPosY + Intersecciones * 112), transform.rotation);
        }
        if (ValorP112 == 7)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX112, myPosY + Intersecciones * 112), transform.rotation);
        }
        int ValorP113 = Random.Range(0, 8);
        float PosX113 = Random.Range(-2.6f, 2.6f);
        if (ValorP113 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX113, myPosY + Intersecciones * 113), transform.rotation);
        }
        if (ValorP113 == 2)
        {
            Instantiate(P4_Q, new Vector2(PosX113, myPosY + Intersecciones * 113), transform.rotation);
        }
        if (ValorP113 == 4)
        {
            Instantiate(P4_M_SS, new Vector2(PosX113, myPosY + Intersecciones * 113), transform.rotation);
        }
        if (ValorP113 == 6)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX113, myPosY + Intersecciones * 113), transform.rotation);
        }
        if (ValorP113 == 1)
        {
            Instantiate(P5_M, new Vector2(PosX113, myPosY + Intersecciones * 113), transform.rotation);
        }
        if (ValorP113 == 3)
        {
            Instantiate(P5_Q, new Vector2(PosX113, myPosY + Intersecciones * 113), transform.rotation);
        }
        if (ValorP113 == 5)
        {
            Instantiate(P5_M_SS, new Vector2(PosX113, myPosY + Intersecciones * 113), transform.rotation);
        }
        if (ValorP113 == 7)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX113, myPosY + Intersecciones * 113), transform.rotation);
        }
        int ValorP114 = Random.Range(0, 8);
        float PosX114 = Random.Range(-2.6f, 2.6f);
        if (ValorP114 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX114, myPosY + Intersecciones * 114), transform.rotation);
        }
        if (ValorP114 == 2)
        {
            Instantiate(P4_Q, new Vector2(PosX114, myPosY + Intersecciones * 114), transform.rotation);
        }
        if (ValorP114 == 4)
        {
            Instantiate(P4_M_SS, new Vector2(PosX114, myPosY + Intersecciones * 114), transform.rotation);
        }
        if (ValorP114 == 6)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX114, myPosY + Intersecciones * 114), transform.rotation);
        }
        if (ValorP114 == 1)
        {
            Instantiate(P5_M, new Vector2(PosX114, myPosY + Intersecciones * 114), transform.rotation);
        }
        if (ValorP114 == 3)
        {
            Instantiate(P5_Q, new Vector2(PosX114, myPosY + Intersecciones * 114), transform.rotation);
        }
        if (ValorP114 == 5)
        {
            Instantiate(P5_M_SS, new Vector2(PosX114, myPosY + Intersecciones * 114), transform.rotation);
        }
        if (ValorP114 == 7)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX114, myPosY + Intersecciones * 114), transform.rotation);
        }
        #endregion
        #region Nivel5
        int ValorP115 = Random.Range(0, 8);
        float PosX115 = Random.Range(-2.6f, 2.6f);
        if (ValorP115 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX115, myPosY + Intersecciones * 115), transform.rotation);
        }
        if (ValorP115 == 2)
        {
            Instantiate(P4_Q, new Vector2(PosX115, myPosY + Intersecciones * 115), transform.rotation);
        }
        if (ValorP115 == 4)
        {
            Instantiate(P4_M_SS, new Vector2(PosX115, myPosY + Intersecciones * 115), transform.rotation);
        }
        if (ValorP115 == 6)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX115, myPosY + Intersecciones * 115), transform.rotation);
        }
        if (ValorP115 == 1)
        {
            Instantiate(P5_M, new Vector2(PosX115, myPosY + Intersecciones * 115), transform.rotation);
        }
        if (ValorP115 == 3)
        {
            Instantiate(P5_Q, new Vector2(PosX115, myPosY + Intersecciones * 115), transform.rotation);
        }
        if (ValorP115 == 5)
        {
            Instantiate(P5_M_SS, new Vector2(PosX115, myPosY + Intersecciones * 115), transform.rotation);
        }
        if (ValorP115 == 7)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX115, myPosY + Intersecciones * 115), transform.rotation);
        }
        int ValorP116 = Random.Range(0, 8);
        float PosX116 = Random.Range(-2.6f, 2.6f);
        if (ValorP116 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX116, myPosY + Intersecciones * 116), transform.rotation);
        }
        if (ValorP116 == 2)
        {
            Instantiate(P4_Q, new Vector2(PosX116, myPosY + Intersecciones * 116), transform.rotation);
        }
        if (ValorP116 == 4)
        {
            Instantiate(P4_M_SS, new Vector2(PosX116, myPosY + Intersecciones * 116), transform.rotation);
        }
        if (ValorP116 == 6)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX116, myPosY + Intersecciones * 116), transform.rotation);
        }
        if (ValorP116 == 1)
        {
            Instantiate(P5_M, new Vector2(PosX116, myPosY + Intersecciones * 116), transform.rotation);
        }
        if (ValorP116 == 3)
        {
            Instantiate(P5_Q, new Vector2(PosX116, myPosY + Intersecciones * 116), transform.rotation);
        }
        if (ValorP116 == 5)
        {
            Instantiate(P5_M_SS, new Vector2(PosX116, myPosY + Intersecciones * 116), transform.rotation);
        }
        if (ValorP116 == 7)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX116, myPosY + Intersecciones * 116), transform.rotation);
        }
        int ValorP117 = Random.Range(0, 8);
        float PosX117 = Random.Range(-2.6f, 2.6f);
        if (ValorP117 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX117, myPosY + Intersecciones * 117), transform.rotation);
        }
        if (ValorP117 == 2)
        {
            Instantiate(P4_Q, new Vector2(PosX117, myPosY + Intersecciones * 117), transform.rotation);
        }
        if (ValorP117 == 4)
        {
            Instantiate(P4_M_SS, new Vector2(PosX117, myPosY + Intersecciones * 117), transform.rotation);
        }
        if (ValorP117 == 6)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX117, myPosY + Intersecciones * 117), transform.rotation);
        }
        if (ValorP117 == 1)
        {
            Instantiate(P5_M, new Vector2(PosX117, myPosY + Intersecciones * 117), transform.rotation);
        }
        if (ValorP117 == 3)
        {
            Instantiate(P5_Q, new Vector2(PosX117, myPosY + Intersecciones * 117), transform.rotation);
        }
        if (ValorP117 == 5)
        {
            Instantiate(P5_M_SS, new Vector2(PosX117, myPosY + Intersecciones * 117), transform.rotation);
        }
        if (ValorP117 == 7)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX117, myPosY + Intersecciones * 117), transform.rotation);
        }
        int ValorP118 = Random.Range(0, 8);
        float PosX118 = Random.Range(-2.6f, 2.6f);
        if (ValorP118 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX118, myPosY + Intersecciones * 118), transform.rotation);
        }
        if (ValorP118 == 2)
        {
            Instantiate(P4_Q, new Vector2(PosX118, myPosY + Intersecciones * 118), transform.rotation);
        }
        if (ValorP118 == 4)
        {
            Instantiate(P4_M_SS, new Vector2(PosX118, myPosY + Intersecciones * 118), transform.rotation);
        }
        if (ValorP118 == 6)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX118, myPosY + Intersecciones * 118), transform.rotation);
        }
        if (ValorP118 == 1)
        {
            Instantiate(P5_M, new Vector2(PosX118, myPosY + Intersecciones * 118), transform.rotation);
        }
        if (ValorP118 == 3)
        {
            Instantiate(P5_Q, new Vector2(PosX118, myPosY + Intersecciones * 118), transform.rotation);
        }
        if (ValorP118 == 5)
        {
            Instantiate(P5_M_SS, new Vector2(PosX118, myPosY + Intersecciones * 118), transform.rotation);
        }
        if (ValorP118 == 7)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX118, myPosY + Intersecciones * 118), transform.rotation);
        }
        int ValorP119 = Random.Range(0, 8);
        float PosX119 = Random.Range(-2.6f, 2.6f);
        if (ValorP119 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX119, myPosY + Intersecciones * 119), transform.rotation);
        }
        if (ValorP119 == 2)
        {
            Instantiate(P4_Q, new Vector2(PosX119, myPosY + Intersecciones * 119), transform.rotation);
        }
        if (ValorP119 == 4)
        {
            Instantiate(P4_M_SS, new Vector2(PosX119, myPosY + Intersecciones * 119), transform.rotation);
        }
        if (ValorP119 == 6)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX119, myPosY + Intersecciones * 119), transform.rotation);
        }
        if (ValorP119 == 1)
        {
            Instantiate(P5_M, new Vector2(PosX119, myPosY + Intersecciones * 119), transform.rotation);
        }
        if (ValorP119 == 3)
        {
            Instantiate(P5_Q, new Vector2(PosX119, myPosY + Intersecciones * 119), transform.rotation);
        }
        if (ValorP119 == 5)
        {
            Instantiate(P5_M_SS, new Vector2(PosX119, myPosY + Intersecciones * 119), transform.rotation);
        }
        if (ValorP119 == 7)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX119, myPosY + Intersecciones * 119), transform.rotation);
        }
        int ValorP120 = Random.Range(0, 8);
        float PosX120 = Random.Range(-2.6f, 2.6f);
        if (ValorP120 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX120, myPosY + Intersecciones * 120), transform.rotation);
        }
        if (ValorP120 == 2)
        {
            Instantiate(P4_Q, new Vector2(PosX120, myPosY + Intersecciones * 120), transform.rotation);
        }
        if (ValorP120 == 4)
        {
            Instantiate(P4_M_SS, new Vector2(PosX120, myPosY + Intersecciones * 120), transform.rotation);
        }
        if (ValorP120 == 6)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX120, myPosY + Intersecciones * 120), transform.rotation);
        }
        if (ValorP120 == 1)
        {
            Instantiate(P5_M, new Vector2(PosX120, myPosY + Intersecciones * 120), transform.rotation);
        }
        if (ValorP120 == 3)
        {
            Instantiate(P5_Q, new Vector2(PosX120, myPosY + Intersecciones * 120), transform.rotation);
        }
        if (ValorP120 == 5)
        {
            Instantiate(P5_M_SS, new Vector2(PosX120, myPosY + Intersecciones * 120), transform.rotation);
        }
        if (ValorP120 == 7)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX120, myPosY + Intersecciones * 120), transform.rotation);
        }
        int ValorP121 = Random.Range(0, 8);
        float PosX121 = Random.Range(-2.6f, 2.6f);
        if (ValorP121 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX121, myPosY + Intersecciones * 121), transform.rotation);
        }
        if (ValorP121 == 2)
        {
            Instantiate(P4_Q, new Vector2(PosX121, myPosY + Intersecciones * 121), transform.rotation);
        }
        if (ValorP121 == 4)
        {
            Instantiate(P4_M_SS, new Vector2(PosX121, myPosY + Intersecciones * 121), transform.rotation);
        }
        if (ValorP121 == 6)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX121, myPosY + Intersecciones * 121), transform.rotation);
        }
        if (ValorP121 == 1)
        {
            Instantiate(P5_M, new Vector2(PosX121, myPosY + Intersecciones * 121), transform.rotation);
        }
        if (ValorP121 == 3)
        {
            Instantiate(P5_Q, new Vector2(PosX121, myPosY + Intersecciones * 121), transform.rotation);
        }
        if (ValorP121 == 5)
        {
            Instantiate(P5_M_SS, new Vector2(PosX121, myPosY + Intersecciones * 121), transform.rotation);
        }
        if (ValorP121 == 7)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX121, myPosY + Intersecciones * 121), transform.rotation);
        }
        int ValorP122 = Random.Range(0, 8);
        float PosX122 = Random.Range(-2.6f, 2.6f);
        if (ValorP122 == 0)
        {
            Instantiate(P4_M, new Vector2(PosX122, myPosY + Intersecciones * 122), transform.rotation);
        }
        if (ValorP122 == 2)
        {
            Instantiate(P4_Q, new Vector2(PosX122, myPosY + Intersecciones * 122), transform.rotation);
        }
        if (ValorP122 == 4)
        {
            Instantiate(P4_M_SS, new Vector2(PosX122, myPosY + Intersecciones * 122), transform.rotation);
        }
        if (ValorP122 == 6)
        {
            Instantiate(P4_Q_SS, new Vector2(PosX122, myPosY + Intersecciones * 122), transform.rotation);
        }
        if (ValorP122 == 1)
        {
            Instantiate(P5_M, new Vector2(PosX122, myPosY + Intersecciones * 122), transform.rotation);
        }
        if (ValorP122 == 3)
        {
            Instantiate(P5_Q, new Vector2(PosX122, myPosY + Intersecciones * 122), transform.rotation);
        }
        if (ValorP122 == 5)
        {
            Instantiate(P5_M_SS, new Vector2(PosX122, myPosY + Intersecciones * 122), transform.rotation);
        }
        if (ValorP122 == 7)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX122, myPosY + Intersecciones * 122), transform.rotation);
        }
        int ValorP123 = Random.Range(0, 4);
        float PosX123 = Random.Range(-2.6f, 2.6f);
        if (ValorP123 == 0)
        {
            Instantiate(P5_M, new Vector2(PosX123, myPosY + Intersecciones * 123), transform.rotation);
        }
        if (ValorP123 == 1)
        {
            Instantiate(P5_Q, new Vector2(PosX123, myPosY + Intersecciones * 123), transform.rotation);
        }
        if (ValorP123 == 2)
        {
            Instantiate(P5_M_SS, new Vector2(PosX123, myPosY + Intersecciones * 123), transform.rotation);
        }
        if (ValorP123 == 3)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX123, myPosY + Intersecciones * 123), transform.rotation);
        }
        int ValorP124 = Random.Range(0, 4);
        float PosX124 = Random.Range(-2.6f, 2.6f);
        if (ValorP124 == 0)
        {
            Instantiate(P5_M, new Vector2(PosX124, myPosY + Intersecciones * 124), transform.rotation);
        }
        if (ValorP124 == 1)
        {
            Instantiate(P5_Q, new Vector2(PosX124, myPosY + Intersecciones * 124), transform.rotation);
        }
        if (ValorP124 == 2)
        {
            Instantiate(P5_M_SS, new Vector2(PosX124, myPosY + Intersecciones * 124), transform.rotation);
        }
        if (ValorP124 == 3)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX124, myPosY + Intersecciones * 124), transform.rotation);
        }
        int ValorP125 = Random.Range(0, 4);
        float PosX125 = Random.Range(-2.6f, 2.6f);
        if (ValorP125 == 0)
        {
            Instantiate(P5_M, new Vector2(PosX125, myPosY + Intersecciones * 125), transform.rotation);
        }
        if (ValorP125 == 1)
        {
            Instantiate(P5_Q, new Vector2(PosX125, myPosY + Intersecciones * 125), transform.rotation);
        }
        if (ValorP125 == 2)
        {
            Instantiate(P5_M_SS, new Vector2(PosX125, myPosY + Intersecciones * 125), transform.rotation);
        }
        if (ValorP125 == 3)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX125, myPosY + Intersecciones * 125), transform.rotation);
        }
        int ValorP126 = Random.Range(0, 4);
        float PosX126 = Random.Range(-2.6f, 2.6f);
        if (ValorP126 == 0)
        {
            Instantiate(P5_M, new Vector2(PosX126, myPosY + Intersecciones * 126), transform.rotation);
        }
        if (ValorP126 == 1)
        {
            Instantiate(P5_Q, new Vector2(PosX126, myPosY + Intersecciones * 126), transform.rotation);
        }
        if (ValorP126 == 2)
        {
            Instantiate(P5_M_SS, new Vector2(PosX126, myPosY + Intersecciones * 126), transform.rotation);
        }
        if (ValorP126 == 3)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX126, myPosY + Intersecciones * 126), transform.rotation);
        }
        int ValorP127 = Random.Range(0, 4);
        float PosX127 = Random.Range(-2.6f, 2.6f);
        if (ValorP127 == 0)
        {
            Instantiate(P5_M, new Vector2(PosX127, myPosY + Intersecciones * 127), transform.rotation);
        }
        if (ValorP127 == 1)
        {
            Instantiate(P5_Q, new Vector2(PosX127, myPosY + Intersecciones * 127), transform.rotation);
        }
        if (ValorP127 == 2)
        {
            Instantiate(P5_M_SS, new Vector2(PosX127, myPosY + Intersecciones * 127), transform.rotation);
        }
        if (ValorP127 == 3)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX127, myPosY + Intersecciones * 127), transform.rotation);
        }
        int ValorP128 = Random.Range(0, 4);
        float PosX128 = Random.Range(-2.6f, 2.6f);
        if (ValorP128 == 0)
        {
            Instantiate(P5_M, new Vector2(PosX128, myPosY + Intersecciones * 128), transform.rotation);
        }
        if (ValorP128 == 1)
        {
            Instantiate(P5_Q, new Vector2(PosX128, myPosY + Intersecciones * 128), transform.rotation);
        }
        if (ValorP128 == 2)
        {
            Instantiate(P5_M_SS, new Vector2(PosX128, myPosY + Intersecciones * 128), transform.rotation);
        }
        if (ValorP128 == 3)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX128, myPosY + Intersecciones * 128), transform.rotation);
        }
        int ValorP129 = Random.Range(0, 4);
        float PosX129 = Random.Range(-2.6f, 2.6f);
        if (ValorP129 == 0)
        {
            Instantiate(P5_M, new Vector2(PosX129, myPosY + Intersecciones * 129), transform.rotation);
        }
        if (ValorP129 == 1)
        {
            Instantiate(P5_Q, new Vector2(PosX129, myPosY + Intersecciones * 129), transform.rotation);
        }
        if (ValorP129 == 2)
        {
            Instantiate(P5_M_SS, new Vector2(PosX129, myPosY + Intersecciones * 129), transform.rotation);
        }
        if (ValorP129 == 3)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX129, myPosY + Intersecciones * 129), transform.rotation);
        }
        int ValorP130 = Random.Range(0, 4);
        float PosX130 = Random.Range(-2.6f, 2.6f);
        if (ValorP130 == 0)
        {
            Instantiate(P5_M, new Vector2(PosX130, myPosY + Intersecciones * 130), transform.rotation);
        }
        if (ValorP130 == 1)
        {
            Instantiate(P5_Q, new Vector2(PosX130, myPosY + Intersecciones * 130), transform.rotation);
        }
        if (ValorP130 == 2)
        {
            Instantiate(P5_M_SS, new Vector2(PosX130, myPosY + Intersecciones * 130), transform.rotation);
        }
        if (ValorP130 == 3)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX130, myPosY + Intersecciones * 130), transform.rotation);
        }
        int ValorP131 = Random.Range(0, 4);
        float PosX131 = Random.Range(-2.6f, 2.6f);
        if (ValorP131 == 0)
        {
            Instantiate(P5_M, new Vector2(PosX131, myPosY + Intersecciones * 131), transform.rotation);
        }
        if (ValorP131 == 1)
        {
            Instantiate(P5_Q, new Vector2(PosX131, myPosY + Intersecciones * 131), transform.rotation);
        }
        if (ValorP131 == 2)
        {
            Instantiate(P5_M_SS, new Vector2(PosX131, myPosY + Intersecciones * 131), transform.rotation);
        }
        if (ValorP131 == 3)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX131, myPosY + Intersecciones * 131), transform.rotation);
        }
        int ValorP132 = Random.Range(0, 4);
        float PosX132 = Random.Range(-2.6f, 2.6f);
        if (ValorP132 == 0)
        {
            Instantiate(P5_M, new Vector2(PosX132, myPosY + Intersecciones * 132), transform.rotation);
        }
        if (ValorP132 == 1)
        {
            Instantiate(P5_Q, new Vector2(PosX132, myPosY + Intersecciones * 132), transform.rotation);
        }
        if (ValorP132 == 2)
        {
            Instantiate(P5_M_SS, new Vector2(PosX132, myPosY + Intersecciones * 132), transform.rotation);
        }
        if (ValorP132 == 3)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX132, myPosY + Intersecciones * 132), transform.rotation);
        }
        int ValorP133 = Random.Range(0, 4);
        float PosX133 = Random.Range(-2.6f, 2.6f);
        if (ValorP133 == 0)
        {
            Instantiate(P5_M, new Vector2(PosX133, myPosY + Intersecciones * 133), transform.rotation);
        }
        if (ValorP133 == 1)
        {
            Instantiate(P5_Q, new Vector2(PosX133, myPosY + Intersecciones * 133), transform.rotation);
        }
        if (ValorP133 == 2)
        {
            Instantiate(P5_M_SS, new Vector2(PosX133, myPosY + Intersecciones * 133), transform.rotation);
        }
        if (ValorP133 == 3)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX133, myPosY + Intersecciones * 133), transform.rotation);
        }
        int ValorP134 = Random.Range(0, 4);
        float PosX134 = Random.Range(-2.6f, 2.6f);
        if (ValorP134 == 0)
        {
            Instantiate(P5_M, new Vector2(PosX134, myPosY + Intersecciones * 134), transform.rotation);
        }
        if (ValorP134 == 1)
        {
            Instantiate(P5_Q, new Vector2(PosX134, myPosY + Intersecciones * 134), transform.rotation);
        }
        if (ValorP134 == 2)
        {
            Instantiate(P5_M_SS, new Vector2(PosX134, myPosY + Intersecciones * 134), transform.rotation);
        }
        if (ValorP134 == 3)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX134, myPosY + Intersecciones * 134), transform.rotation);
        }
        int ValorP135 = Random.Range(0, 4);
        float PosX135 = Random.Range(-2.6f, 2.6f);
        if (ValorP135 == 0)
        {
            Instantiate(P5_M, new Vector2(PosX135, myPosY + Intersecciones * 135), transform.rotation);
        }
        if (ValorP135 == 1)
        {
            Instantiate(P5_Q, new Vector2(PosX135, myPosY + Intersecciones * 135), transform.rotation);
        }
        if (ValorP135 == 2)
        {
            Instantiate(P5_M_SS, new Vector2(PosX135, myPosY + Intersecciones * 135), transform.rotation);
        }
        if (ValorP135 == 3)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX135, myPosY + Intersecciones * 135), transform.rotation);
        }
        int ValorP136 = Random.Range(0, 4);
        float PosX136 = Random.Range(-2.6f, 2.6f);
        if (ValorP136 == 0)
        {
            Instantiate(P5_M, new Vector2(PosX136, myPosY + Intersecciones * 136), transform.rotation);
        }
        if (ValorP136 == 1)
        {
            Instantiate(P5_Q, new Vector2(PosX136, myPosY + Intersecciones * 136), transform.rotation);
        }
        if (ValorP136 == 2)
        {
            Instantiate(P5_M_SS, new Vector2(PosX136, myPosY + Intersecciones * 136), transform.rotation);
        }
        if (ValorP136 == 3)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX136, myPosY + Intersecciones * 136), transform.rotation);
        }
        int ValorP137 = Random.Range(0, 4);
        float PosX137 = Random.Range(-2.6f, 2.6f);
        if (ValorP137 == 0)
        {
            Instantiate(P5_M, new Vector2(PosX137, myPosY + Intersecciones * 137), transform.rotation);
        }
        if (ValorP137 == 1)
        {
            Instantiate(P5_Q, new Vector2(PosX137, myPosY + Intersecciones * 137), transform.rotation);
        }
        if (ValorP137 == 2)
        {
            Instantiate(P5_M_SS, new Vector2(PosX137, myPosY + Intersecciones * 137), transform.rotation);
        }
        if (ValorP137 == 3)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX137, myPosY + Intersecciones * 137), transform.rotation);
        }
        int ValorP138 = Random.Range(0, 4);
        float PosX138 = Random.Range(-2.6f, 2.6f);
        if (ValorP138 == 0)
        {
            Instantiate(P5_M, new Vector2(PosX138, myPosY + Intersecciones * 138), transform.rotation);
        }
        if (ValorP138 == 1)
        {
            Instantiate(P5_Q, new Vector2(PosX138, myPosY + Intersecciones * 138), transform.rotation);
        }
        if (ValorP138 == 2)
        {
            Instantiate(P5_M_SS, new Vector2(PosX138, myPosY + Intersecciones * 138), transform.rotation);
        }
        if (ValorP138 == 3)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX138, myPosY + Intersecciones * 138), transform.rotation);
        }
        int ValorP139 = Random.Range(0, 8);
        float PosX139 = Random.Range(-2.6f, 2.6f);
        if (ValorP139 == 0)
        {
            Instantiate(P5_M, new Vector2(PosX139, myPosY + Intersecciones * 139), transform.rotation);
        }
        if (ValorP139 == 2)
        {
            Instantiate(P5_Q, new Vector2(PosX139, myPosY + Intersecciones * 139), transform.rotation);
        }
        if (ValorP139 == 4)
        {
            Instantiate(P5_M_SS, new Vector2(PosX139, myPosY + Intersecciones * 139), transform.rotation);
        }
        if (ValorP139 == 6)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX139, myPosY + Intersecciones * 139), transform.rotation);
        }
        if (ValorP139 == 1)
        {
            Instantiate(P6_M, new Vector2(PosX139, myPosY + Intersecciones * 139), transform.rotation);
        }
        if (ValorP139 == 3)
        {
            Instantiate(P6_Q, new Vector2(PosX139, myPosY + Intersecciones * 139), transform.rotation);
        }
        if (ValorP139 == 5)
        {
            Instantiate(P6_M_SS, new Vector2(PosX139, myPosY + Intersecciones * 139), transform.rotation);
        }
        if (ValorP139 == 7)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX139, myPosY + Intersecciones * 139), transform.rotation);
        }
        int ValorP140 = Random.Range(0, 8);
        float PosX140 = Random.Range(-2.6f, 2.6f);
        if (ValorP140 == 0)
        {
            Instantiate(P5_M, new Vector2(PosX140, myPosY + Intersecciones * 140), transform.rotation);
        }
        if (ValorP140 == 2)
        {
            Instantiate(P5_Q, new Vector2(PosX140, myPosY + Intersecciones * 140), transform.rotation);
        }
        if (ValorP140 == 4)
        {
            Instantiate(P5_M_SS, new Vector2(PosX140, myPosY + Intersecciones * 140), transform.rotation);
        }
        if (ValorP140 == 6)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX140, myPosY + Intersecciones * 140), transform.rotation);
        }
        if (ValorP140 == 1)
        {
            Instantiate(P6_M, new Vector2(PosX140, myPosY + Intersecciones * 140), transform.rotation);
        }
        if (ValorP140 == 3)
        {
            Instantiate(P6_Q, new Vector2(PosX140, myPosY + Intersecciones * 140), transform.rotation);
        }
        if (ValorP140 == 5)
        {
            Instantiate(P6_M_SS, new Vector2(PosX140, myPosY + Intersecciones * 140), transform.rotation);
        }
        if (ValorP140 == 7)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX140, myPosY + Intersecciones * 140), transform.rotation);
        }
        int ValorP141 = Random.Range(0, 8);
        float PosX141 = Random.Range(-2.6f, 2.6f);
        if (ValorP141 == 0)
        {
            Instantiate(P5_M, new Vector2(PosX141, myPosY + Intersecciones * 141), transform.rotation);
        }
        if (ValorP141 == 2)
        {
            Instantiate(P5_Q, new Vector2(PosX141, myPosY + Intersecciones * 141), transform.rotation);
        }
        if (ValorP141 == 4)
        {
            Instantiate(P5_M_SS, new Vector2(PosX141, myPosY + Intersecciones * 141), transform.rotation);
        }
        if (ValorP141 == 6)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX141, myPosY + Intersecciones * 141), transform.rotation);
        }
        if (ValorP141 == 1)
        {
            Instantiate(P6_M, new Vector2(PosX141, myPosY + Intersecciones * 141), transform.rotation);
        }
        if (ValorP141 == 3)
        {
            Instantiate(P6_Q, new Vector2(PosX141, myPosY + Intersecciones * 141), transform.rotation);
        }
        if (ValorP141 == 5)
        {
            Instantiate(P6_M_SS, new Vector2(PosX141, myPosY + Intersecciones * 141), transform.rotation);
        }
        if (ValorP141 == 7)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX141, myPosY + Intersecciones * 141), transform.rotation);
        }
        int ValorP142 = Random.Range(0, 8);
        float PosX142 = Random.Range(-2.6f, 2.6f);
        if (ValorP142 == 0)
        {
            Instantiate(P5_M, new Vector2(PosX142, myPosY + Intersecciones * 142), transform.rotation);
        }
        if (ValorP142 == 2)
        {
            Instantiate(P5_Q, new Vector2(PosX142, myPosY + Intersecciones * 142), transform.rotation);
        }
        if (ValorP142 == 4)
        {
            Instantiate(P5_M_SS, new Vector2(PosX142, myPosY + Intersecciones * 142), transform.rotation);
        }
        if (ValorP142 == 6)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX142, myPosY + Intersecciones * 142), transform.rotation);
        }
        if (ValorP142 == 1)
        {
            Instantiate(P6_M, new Vector2(PosX142, myPosY + Intersecciones * 142), transform.rotation);
        }
        if (ValorP142 == 3)
        {
            Instantiate(P6_Q, new Vector2(PosX142, myPosY + Intersecciones * 142), transform.rotation);
        }
        if (ValorP142 == 5)
        {
            Instantiate(P6_M_SS, new Vector2(PosX142, myPosY + Intersecciones * 142), transform.rotation);
        }
        if (ValorP142 == 7)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX142, myPosY + Intersecciones * 142), transform.rotation);
        }
        int ValorP143 = Random.Range(0, 8);
        float PosX143 = Random.Range(-2.6f, 2.6f);
        if (ValorP143 == 0)
        {
            Instantiate(P5_M, new Vector2(PosX143, myPosY + Intersecciones * 143), transform.rotation);
        }
        if (ValorP143 == 2)
        {
            Instantiate(P5_Q, new Vector2(PosX143, myPosY + Intersecciones * 143), transform.rotation);
        }
        if (ValorP143 == 4)
        {
            Instantiate(P5_M_SS, new Vector2(PosX143, myPosY + Intersecciones * 143), transform.rotation);
        }
        if (ValorP143 == 6)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX143, myPosY + Intersecciones * 143), transform.rotation);
        }
        if (ValorP143 == 1)
        {
            Instantiate(P6_M, new Vector2(PosX143, myPosY + Intersecciones * 143), transform.rotation);
        }
        if (ValorP143 == 3)
        {
            Instantiate(P6_Q, new Vector2(PosX143, myPosY + Intersecciones * 143), transform.rotation);
        }
        if (ValorP143 == 5)
        {
            Instantiate(P6_M_SS, new Vector2(PosX143, myPosY + Intersecciones * 143), transform.rotation);
        }
        if (ValorP143 == 7)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX143, myPosY + Intersecciones * 143), transform.rotation);
        }
        int ValorP144 = Random.Range(0, 8);
        float PosX144 = Random.Range(-2.6f, 2.6f);
        if (ValorP144 == 0)
        {
            Instantiate(P5_M, new Vector2(PosX144, myPosY + Intersecciones * 144), transform.rotation);
        }
        if (ValorP144 == 2)
        {
            Instantiate(P5_Q, new Vector2(PosX144, myPosY + Intersecciones * 144), transform.rotation);
        }
        if (ValorP144 == 4)
        {
            Instantiate(P5_M_SS, new Vector2(PosX144, myPosY + Intersecciones * 144), transform.rotation);
        }
        if (ValorP144 == 6)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX144, myPosY + Intersecciones * 144), transform.rotation);
        }
        if (ValorP144 == 1)
        {
            Instantiate(P6_M, new Vector2(PosX144, myPosY + Intersecciones * 144), transform.rotation);
        }
        if (ValorP144 == 3)
        {
            Instantiate(P6_Q, new Vector2(PosX144, myPosY + Intersecciones * 144), transform.rotation);
        }
        if (ValorP144 == 5)
        {
            Instantiate(P6_M_SS, new Vector2(PosX144, myPosY + Intersecciones * 144), transform.rotation);
        }
        if (ValorP144 == 7)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX144, myPosY + Intersecciones * 144), transform.rotation);
        }
        #endregion
        #region Nivel6
        int ValorP145 = Random.Range(0, 8);
        float PosX145 = Random.Range(-2.6f, 2.6f);
        if (ValorP145 == 0)
        {
            Instantiate(P5_M, new Vector2(PosX145, myPosY + Intersecciones * 145), transform.rotation);
        }
        if (ValorP145 == 2)
        {
            Instantiate(P5_Q, new Vector2(PosX145, myPosY + Intersecciones * 145), transform.rotation);
        }
        if (ValorP145 == 4)
        {
            Instantiate(P5_M_SS, new Vector2(PosX145, myPosY + Intersecciones * 145), transform.rotation);
        }
        if (ValorP145 == 6)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX145, myPosY + Intersecciones * 145), transform.rotation);
        }
        if (ValorP145 == 1)
        {
            Instantiate(P6_M, new Vector2(PosX145, myPosY + Intersecciones * 145), transform.rotation);
        }
        if (ValorP145 == 3)
        {
            Instantiate(P6_Q, new Vector2(PosX145, myPosY + Intersecciones * 145), transform.rotation);
        }
        if (ValorP145 == 5)
        {
            Instantiate(P6_M_SS, new Vector2(PosX145, myPosY + Intersecciones * 145), transform.rotation);
        }
        if (ValorP145 == 7)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX145, myPosY + Intersecciones * 145), transform.rotation);
        }
        int ValorP146 = Random.Range(0, 8);
        float PosX146 = Random.Range(-2.6f, 2.6f);
        if (ValorP146 == 0)
        {
            Instantiate(P5_M, new Vector2(PosX146, myPosY + Intersecciones * 146), transform.rotation);
        }
        if (ValorP146 == 2)
        {
            Instantiate(P5_Q, new Vector2(PosX146, myPosY + Intersecciones * 146), transform.rotation);
        }
        if (ValorP146 == 4)
        {
            Instantiate(P5_M_SS, new Vector2(PosX146, myPosY + Intersecciones * 146), transform.rotation);
        }
        if (ValorP146 == 6)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX146, myPosY + Intersecciones * 146), transform.rotation);
        }
        if (ValorP146 == 1)
        {
            Instantiate(P6_M, new Vector2(PosX146, myPosY + Intersecciones * 146), transform.rotation);
        }
        if (ValorP146 == 3)
        {
            Instantiate(P6_Q, new Vector2(PosX146, myPosY + Intersecciones * 146), transform.rotation);
        }
        if (ValorP146 == 5)
        {
            Instantiate(P6_M_SS, new Vector2(PosX146, myPosY + Intersecciones * 146), transform.rotation);
        }
        if (ValorP146 == 7)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX146, myPosY + Intersecciones * 146), transform.rotation);
        }
        int ValorP147 = Random.Range(0, 8);
        float PosX147 = Random.Range(-2.6f, 2.6f);
        if (ValorP147 == 0)
        {
            Instantiate(P5_M, new Vector2(PosX147, myPosY + Intersecciones * 147), transform.rotation);
        }
        if (ValorP147 == 2)
        {
            Instantiate(P5_Q, new Vector2(PosX147, myPosY + Intersecciones * 147), transform.rotation);
        }
        if (ValorP147 == 4)
        {
            Instantiate(P5_M_SS, new Vector2(PosX147, myPosY + Intersecciones * 147), transform.rotation);
        }
        if (ValorP147 == 6)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX147, myPosY + Intersecciones * 147), transform.rotation);
        }
        if (ValorP147 == 1)
        {
            Instantiate(P6_M, new Vector2(PosX147, myPosY + Intersecciones * 147), transform.rotation);
        }
        if (ValorP147 == 3)
        {
            Instantiate(P6_Q, new Vector2(PosX147, myPosY + Intersecciones * 147), transform.rotation);
        }
        if (ValorP147 == 5)
        {
            Instantiate(P6_M_SS, new Vector2(PosX147, myPosY + Intersecciones * 147), transform.rotation);
        }
        if (ValorP147 == 7)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX147, myPosY + Intersecciones * 147), transform.rotation);
        }
        int ValorP148 = Random.Range(0, 8);
        float PosX148 = Random.Range(-2.6f, 2.6f);
        if (ValorP148 == 0)
        {
            Instantiate(P5_M, new Vector2(PosX148, myPosY + Intersecciones * 148), transform.rotation);
        }
        if (ValorP148 == 2)
        {
            Instantiate(P5_Q, new Vector2(PosX148, myPosY + Intersecciones * 148), transform.rotation);
        }
        if (ValorP148 == 4)
        {
            Instantiate(P5_M_SS, new Vector2(PosX148, myPosY + Intersecciones * 148), transform.rotation);
        }
        if (ValorP148 == 6)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX148, myPosY + Intersecciones * 148), transform.rotation);
        }
        if (ValorP148 == 1)
        {
            Instantiate(P6_M, new Vector2(PosX148, myPosY + Intersecciones * 148), transform.rotation);
        }
        if (ValorP148 == 3)
        {
            Instantiate(P6_Q, new Vector2(PosX148, myPosY + Intersecciones * 148), transform.rotation);
        }
        if (ValorP148 == 5)
        {
            Instantiate(P6_M_SS, new Vector2(PosX148, myPosY + Intersecciones * 148), transform.rotation);
        }
        if (ValorP148 == 7)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX148, myPosY + Intersecciones * 148), transform.rotation);
        }
        int ValorP149 = Random.Range(0, 8);
        float PosX149 = Random.Range(-2.6f, 2.6f);
        if (ValorP149 == 0)
        {
            Instantiate(P5_M, new Vector2(PosX149, myPosY + Intersecciones * 149), transform.rotation);
        }
        if (ValorP149 == 2)
        {
            Instantiate(P5_Q, new Vector2(PosX149, myPosY + Intersecciones * 149), transform.rotation);
        }
        if (ValorP149 == 4)
        {
            Instantiate(P5_M_SS, new Vector2(PosX149, myPosY + Intersecciones * 149), transform.rotation);
        }
        if (ValorP149 == 6)
        {
            Instantiate(P5_Q_SS, new Vector2(PosX149, myPosY + Intersecciones * 149), transform.rotation);
        }
        if (ValorP149 == 1)
        {
            Instantiate(P6_M, new Vector2(PosX149, myPosY + Intersecciones * 149), transform.rotation);
        }
        if (ValorP149 == 3)
        {
            Instantiate(P6_Q, new Vector2(PosX149, myPosY + Intersecciones * 149), transform.rotation);
        }
        if (ValorP149 == 5)
        {
            Instantiate(P6_M_SS, new Vector2(PosX149, myPosY + Intersecciones * 149), transform.rotation);
        }
        if (ValorP149 == 7)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX149, myPosY + Intersecciones * 149), transform.rotation);
        }
        int ValorP150 = Random.Range(0, 6);
        float PosX150 = Random.Range(-2.6f, 2.6f);
        if (ValorP150 == 0)
        {
            Instantiate(P6_M, new Vector2(PosX150, myPosY + Intersecciones * 150), transform.rotation);
        }
        if (ValorP150 == 1)
        {
            Instantiate(P6_Q, new Vector2(PosX150, myPosY + Intersecciones * 150), transform.rotation);
        }
        if (ValorP150 == 2)
        {
            Instantiate(P6_M_SS, new Vector2(PosX150, myPosY + Intersecciones * 150), transform.rotation);
        }
        if (ValorP150 == 3)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX150, myPosY + Intersecciones * 150), transform.rotation);
        }
        if (ValorP150 == 4)
        {
            Instantiate(P6_M_P, new Vector2(PosX150, myPosY + Intersecciones * 150), transform.rotation);
        }
        if (ValorP150 == 5)
        {
            Instantiate(P6_Q_P, new Vector2(PosX150, myPosY + Intersecciones * 150), transform.rotation);
        }
        int ValorP151 = Random.Range(0, 6);
        float PosX151 = Random.Range(-2.6f, 2.6f);
        if (ValorP151 == 0)
        {
            Instantiate(P6_M, new Vector2(PosX151, myPosY + Intersecciones * 151), transform.rotation);
        }
        if (ValorP151 == 1)
        {
            Instantiate(P6_Q, new Vector2(PosX151, myPosY + Intersecciones * 151), transform.rotation);
        }
        if (ValorP151 == 2)
        {
            Instantiate(P6_M_SS, new Vector2(PosX151, myPosY + Intersecciones * 151), transform.rotation);
        }
        if (ValorP151 == 3)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX151, myPosY + Intersecciones * 151), transform.rotation);
        }
        if (ValorP151 == 4)
        {
            Instantiate(P6_M_P, new Vector2(PosX151, myPosY + Intersecciones * 151), transform.rotation);
        }
        if (ValorP151 == 5)
        {
            Instantiate(P6_Q_P, new Vector2(PosX151, myPosY + Intersecciones * 151), transform.rotation);
        }
        int ValorP152 = Random.Range(0, 6);
        float PosX152 = Random.Range(-2.6f, 2.6f);
        if (ValorP152 == 0)
        {
            Instantiate(P6_M, new Vector2(PosX152, myPosY + Intersecciones * 152), transform.rotation);
        }
        if (ValorP152 == 1)
        {
            Instantiate(P6_Q, new Vector2(PosX152, myPosY + Intersecciones * 152), transform.rotation);
        }
        if (ValorP152 == 2)
        {
            Instantiate(P6_M_SS, new Vector2(PosX152, myPosY + Intersecciones * 152), transform.rotation);
        }
        if (ValorP152 == 3)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX152, myPosY + Intersecciones * 152), transform.rotation);
        }
        if (ValorP152 == 4)
        {
            Instantiate(P6_M_P, new Vector2(PosX152, myPosY + Intersecciones * 152), transform.rotation);
        }
        if (ValorP152 == 5)
        {
            Instantiate(P6_Q_P, new Vector2(PosX152, myPosY + Intersecciones * 152), transform.rotation);
        }
        int ValorP153 = Random.Range(0, 6);
        float PosX153 = Random.Range(-2.6f, 2.6f);
        if (ValorP153 == 0)
        {
            Instantiate(P6_M, new Vector2(PosX153, myPosY + Intersecciones * 153), transform.rotation);
        }
        if (ValorP153 == 1)
        {
            Instantiate(P6_Q, new Vector2(PosX153, myPosY + Intersecciones * 153), transform.rotation);
        }
        if (ValorP153 == 2)
        {
            Instantiate(P6_M_SS, new Vector2(PosX153, myPosY + Intersecciones * 153), transform.rotation);
        }
        if (ValorP153 == 3)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX153, myPosY + Intersecciones * 153), transform.rotation);
        }
        if (ValorP153 == 4)
        {
            Instantiate(P6_M_P, new Vector2(PosX153, myPosY + Intersecciones * 153), transform.rotation);
        }
        if (ValorP153 == 5)
        {
            Instantiate(P6_Q_P, new Vector2(PosX153, myPosY + Intersecciones * 153), transform.rotation);
        }
        int ValorP154 = Random.Range(0, 6);
        float PosX154 = Random.Range(-2.6f, 2.6f);
        if (ValorP154 == 0)
        {
            Instantiate(P6_M, new Vector2(PosX154, myPosY + Intersecciones * 154), transform.rotation);
        }
        if (ValorP154 == 1)
        {
            Instantiate(P6_Q, new Vector2(PosX154, myPosY + Intersecciones * 154), transform.rotation);
        }
        if (ValorP154 == 2)
        {
            Instantiate(P6_M_SS, new Vector2(PosX154, myPosY + Intersecciones * 154), transform.rotation);
        }
        if (ValorP154 == 3)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX154, myPosY + Intersecciones * 154), transform.rotation);
        }
        if (ValorP154 == 4)
        {
            Instantiate(P6_M_P, new Vector2(PosX154, myPosY + Intersecciones * 154), transform.rotation);
        }
        if (ValorP154 == 5)
        {
            Instantiate(P6_Q_P, new Vector2(PosX154, myPosY + Intersecciones * 154), transform.rotation);
        }
        int ValorP155 = Random.Range(0, 6);
        float PosX155 = Random.Range(-2.6f, 2.6f);
        if (ValorP155 == 0)
        {
            Instantiate(P6_M, new Vector2(PosX155, myPosY + Intersecciones * 155), transform.rotation);
        }
        if (ValorP155 == 1)
        {
            Instantiate(P6_Q, new Vector2(PosX155, myPosY + Intersecciones * 155), transform.rotation);
        }
        if (ValorP155 == 2)
        {
            Instantiate(P6_M_SS, new Vector2(PosX155, myPosY + Intersecciones * 155), transform.rotation);
        }
        if (ValorP155 == 3)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX155, myPosY + Intersecciones * 155), transform.rotation);
        }
        if (ValorP155 == 4)
        {
            Instantiate(P6_M_P, new Vector2(PosX155, myPosY + Intersecciones * 155), transform.rotation);
        }
        if (ValorP155 == 5)
        {
            Instantiate(P6_Q_P, new Vector2(PosX155, myPosY + Intersecciones * 155), transform.rotation);
        }
        int ValorP156 = Random.Range(0, 6);
        float PosX156 = Random.Range(-2.6f, 2.6f);
        if (ValorP156 == 0)
        {
            Instantiate(P6_M, new Vector2(PosX156, myPosY + Intersecciones * 156), transform.rotation);
        }
        if (ValorP156 == 1)
        {
            Instantiate(P6_Q, new Vector2(PosX156, myPosY + Intersecciones * 156), transform.rotation);
        }
        if (ValorP156 == 2)
        {
            Instantiate(P6_M_SS, new Vector2(PosX156, myPosY + Intersecciones * 156), transform.rotation);
        }
        if (ValorP156 == 3)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX156, myPosY + Intersecciones * 156), transform.rotation);
        }
        if (ValorP156 == 4)
        {
            Instantiate(P6_M_P, new Vector2(PosX156, myPosY + Intersecciones * 156), transform.rotation);
        }
        if (ValorP156 == 5)
        {
            Instantiate(P6_Q_P, new Vector2(PosX156, myPosY + Intersecciones * 156), transform.rotation);
        }
        int ValorP157 = Random.Range(0, 6);
        float PosX157 = Random.Range(-2.6f, 2.6f);
        if (ValorP157 == 0)
        {
            Instantiate(P6_M, new Vector2(PosX157, myPosY + Intersecciones * 157), transform.rotation);
        }
        if (ValorP157 == 1)
        {
            Instantiate(P6_Q, new Vector2(PosX157, myPosY + Intersecciones * 157), transform.rotation);
        }
        if (ValorP157 == 2)
        {
            Instantiate(P6_M_SS, new Vector2(PosX157, myPosY + Intersecciones * 157), transform.rotation);
        }
        if (ValorP157 == 3)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX157, myPosY + Intersecciones * 157), transform.rotation);
        }
        if (ValorP157 == 4)
        {
            Instantiate(P6_M_P, new Vector2(PosX157, myPosY + Intersecciones * 157), transform.rotation);
        }
        if (ValorP157 == 5)
        {
            Instantiate(P6_Q_P, new Vector2(PosX157, myPosY + Intersecciones * 157), transform.rotation);
        }
        int ValorP158 = Random.Range(0, 6);
        float PosX158 = Random.Range(-2.6f, 2.6f);
        if (ValorP158 == 0)
        {
            Instantiate(P6_M, new Vector2(PosX158, myPosY + Intersecciones * 158), transform.rotation);
        }
        if (ValorP158 == 1)
        {
            Instantiate(P6_Q, new Vector2(PosX158, myPosY + Intersecciones * 158), transform.rotation);
        }
        if (ValorP158 == 2)
        {
            Instantiate(P6_M_SS, new Vector2(PosX158, myPosY + Intersecciones * 158), transform.rotation);
        }
        if (ValorP158 == 3)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX158, myPosY + Intersecciones * 158), transform.rotation);
        }
        if (ValorP158 == 4)
        {
            Instantiate(P6_M_P, new Vector2(PosX158, myPosY + Intersecciones * 158), transform.rotation);
        }
        if (ValorP158 == 5)
        {
            Instantiate(P6_Q_P, new Vector2(PosX158, myPosY + Intersecciones * 158), transform.rotation);
        }
        int ValorP159 = Random.Range(0, 6);
        float PosX159 = Random.Range(-2.6f, 2.6f);
        if (ValorP159 == 0)
        {
            Instantiate(P6_M, new Vector2(PosX159, myPosY + Intersecciones * 159), transform.rotation);
        }
        if (ValorP159 == 1)
        {
            Instantiate(P6_Q, new Vector2(PosX159, myPosY + Intersecciones * 159), transform.rotation);
        }
        if (ValorP159 == 2)
        {
            Instantiate(P6_M_SS, new Vector2(PosX159, myPosY + Intersecciones * 159), transform.rotation);
        }
        if (ValorP159 == 3)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX159, myPosY + Intersecciones * 159), transform.rotation);
        }
        if (ValorP159 == 4)
        {
            Instantiate(P6_M_P, new Vector2(PosX159, myPosY + Intersecciones * 159), transform.rotation);
        }
        if (ValorP159 == 5)
        {
            Instantiate(P6_Q_P, new Vector2(PosX159, myPosY + Intersecciones * 159), transform.rotation);
        }
        int ValorP160 = Random.Range(0, 6);
        float PosX160 = Random.Range(-2.6f, 2.6f);
        if (ValorP160 == 0)
        {
            Instantiate(P6_M, new Vector2(PosX160, myPosY + Intersecciones * 160), transform.rotation);
        }
        if (ValorP160 == 1)
        {
            Instantiate(P6_Q, new Vector2(PosX160, myPosY + Intersecciones * 160), transform.rotation);
        }
        if (ValorP160 == 2)
        {
            Instantiate(P6_M_SS, new Vector2(PosX160, myPosY + Intersecciones * 160), transform.rotation);
        }
        if (ValorP160 == 3)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX160, myPosY + Intersecciones * 160), transform.rotation);
        }
        if (ValorP160 == 4)
        {
            Instantiate(P6_M_P, new Vector2(PosX160, myPosY + Intersecciones * 160), transform.rotation);
        }
        if (ValorP160 == 5)
        {
            Instantiate(P6_Q_P, new Vector2(PosX160, myPosY + Intersecciones * 160), transform.rotation);
        }
        int ValorP161 = Random.Range(0, 6);
        float PosX161 = Random.Range(-2.6f, 2.6f);
        if (ValorP161 == 0)
        {
            Instantiate(P6_M, new Vector2(PosX161, myPosY + Intersecciones * 161), transform.rotation);
        }
        if (ValorP161 == 1)
        {
            Instantiate(P6_Q, new Vector2(PosX161, myPosY + Intersecciones * 161), transform.rotation);
        }
        if (ValorP161 == 2)
        {
            Instantiate(P6_M_SS, new Vector2(PosX161, myPosY + Intersecciones * 161), transform.rotation);
        }
        if (ValorP161 == 3)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX161, myPosY + Intersecciones * 161), transform.rotation);
        }
        if (ValorP161 == 4)
        {
            Instantiate(P6_M_P, new Vector2(PosX161, myPosY + Intersecciones * 161), transform.rotation);
        }
        if (ValorP161 == 5)
        {
            Instantiate(P6_Q_P, new Vector2(PosX161, myPosY + Intersecciones * 161), transform.rotation);
        }
        int ValorP162 = Random.Range(0, 6);
        float PosX162 = Random.Range(-2.6f, 2.6f);
        if (ValorP162 == 0)
        {
            Instantiate(P6_M, new Vector2(PosX162, myPosY + Intersecciones * 162), transform.rotation);
        }
        if (ValorP162 == 1)
        {
            Instantiate(P6_Q, new Vector2(PosX162, myPosY + Intersecciones * 162), transform.rotation);
        }
        if (ValorP162 == 2)
        {
            Instantiate(P6_M_SS, new Vector2(PosX162, myPosY + Intersecciones * 162), transform.rotation);
        }
        if (ValorP162 == 3)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX162, myPosY + Intersecciones * 162), transform.rotation);
        }
        if (ValorP162 == 4)
        {
            Instantiate(P6_M_P, new Vector2(PosX162, myPosY + Intersecciones * 162), transform.rotation);
        }
        if (ValorP162 == 5)
        {
            Instantiate(P6_Q_P, new Vector2(PosX162, myPosY + Intersecciones * 162), transform.rotation);
        }
        int ValorP163 = Random.Range(0, 6);
        float PosX163 = Random.Range(-2.6f, 2.6f);
        if (ValorP163 == 0)
        {
            Instantiate(P6_M, new Vector2(PosX163, myPosY + Intersecciones * 163), transform.rotation);
        }
        if (ValorP163 == 1)
        {
            Instantiate(P6_Q, new Vector2(PosX163, myPosY + Intersecciones * 163), transform.rotation);
        }
        if (ValorP163 == 2)
        {
            Instantiate(P6_M_SS, new Vector2(PosX163, myPosY + Intersecciones * 163), transform.rotation);
        }
        if (ValorP163 == 3)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX163, myPosY + Intersecciones * 163), transform.rotation);
        }
        if (ValorP163 == 4)
        {
            Instantiate(P6_M_P, new Vector2(PosX163, myPosY + Intersecciones * 163), transform.rotation);
        }
        if (ValorP163 == 5)
        {
            Instantiate(P6_Q_P, new Vector2(PosX163, myPosY + Intersecciones * 163), transform.rotation);
        }
        int ValorP164 = Random.Range(0, 6);
        float PosX164 = Random.Range(-2.6f, 2.6f);
        if (ValorP164 == 0)
        {
            Instantiate(P6_M, new Vector2(PosX164, myPosY + Intersecciones * 164), transform.rotation);
        }
        if (ValorP164 == 1)
        {
            Instantiate(P6_Q, new Vector2(PosX164, myPosY + Intersecciones * 164), transform.rotation);
        }
        if (ValorP164 == 2)
        {
            Instantiate(P6_M_SS, new Vector2(PosX164, myPosY + Intersecciones * 164), transform.rotation);
        }
        if (ValorP164 == 3)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX164, myPosY + Intersecciones * 164), transform.rotation);
        }
        if (ValorP164 == 4)
        {
            Instantiate(P6_M_P, new Vector2(PosX164, myPosY + Intersecciones * 164), transform.rotation);
        }
        if (ValorP164 == 5)
        {
            Instantiate(P6_Q_P, new Vector2(PosX164, myPosY + Intersecciones * 164), transform.rotation);
        }
        int ValorP165 = Random.Range(0, 6);
        float PosX165 = Random.Range(-2.6f, 2.6f);
        if (ValorP165 == 0)
        {
            Instantiate(P6_M, new Vector2(PosX165, myPosY + Intersecciones * 165), transform.rotation);
        }
        if (ValorP165 == 1)
        {
            Instantiate(P6_Q, new Vector2(PosX165, myPosY + Intersecciones * 165), transform.rotation);
        }
        if (ValorP165 == 2)
        {
            Instantiate(P6_M_SS, new Vector2(PosX165, myPosY + Intersecciones * 165), transform.rotation);
        }
        if (ValorP165 == 3)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX165, myPosY + Intersecciones * 165), transform.rotation);
        }
        if (ValorP165 == 4)
        {
            Instantiate(P6_M_P, new Vector2(PosX165, myPosY + Intersecciones * 165), transform.rotation);
        }
        if (ValorP165 == 5)
        {
            Instantiate(P6_Q_P, new Vector2(PosX165, myPosY + Intersecciones * 165), transform.rotation);
        }
        int ValorP166 = Random.Range(0, 6);
        float PosX166 = Random.Range(-2.6f, 2.6f);
        if (ValorP166 == 0)
        {
            Instantiate(P6_M, new Vector2(PosX166, myPosY + Intersecciones * 166), transform.rotation);
        }
        if (ValorP166 == 1)
        {
            Instantiate(P6_Q, new Vector2(PosX166, myPosY + Intersecciones * 166), transform.rotation);
        }
        if (ValorP166 == 2)
        {
            Instantiate(P6_M_SS, new Vector2(PosX166, myPosY + Intersecciones * 166), transform.rotation);
        }
        if (ValorP166 == 3)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX166, myPosY + Intersecciones * 166), transform.rotation);
        }
        if (ValorP166 == 4)
        {
            Instantiate(P6_M_P, new Vector2(PosX166, myPosY + Intersecciones * 166), transform.rotation);
        }
        if (ValorP166 == 5)
        {
            Instantiate(P6_Q_P, new Vector2(PosX166, myPosY + Intersecciones * 166), transform.rotation);
        }
        int ValorP167 = Random.Range(0, 6);
        float PosX167 = Random.Range(-2.6f, 2.6f);
        if (ValorP167 == 0)
        {
            Instantiate(P6_M, new Vector2(PosX167, myPosY + Intersecciones * 167), transform.rotation);
        }
        if (ValorP167 == 1)
        {
            Instantiate(P6_Q, new Vector2(PosX167, myPosY + Intersecciones * 167), transform.rotation);
        }
        if (ValorP167 == 2)
        {
            Instantiate(P6_M_SS, new Vector2(PosX167, myPosY + Intersecciones * 167), transform.rotation);
        }
        if (ValorP167 == 3)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX167, myPosY + Intersecciones * 167), transform.rotation);
        }
        if (ValorP167 == 4)
        {
            Instantiate(P6_M_P, new Vector2(PosX167, myPosY + Intersecciones * 167), transform.rotation);
        }
        if (ValorP167 == 5)
        {
            Instantiate(P6_Q_P, new Vector2(PosX167, myPosY + Intersecciones * 167), transform.rotation);
        }
        int ValorP168 = Random.Range(0, 6);
        float PosX168 = Random.Range(-2.6f, 2.6f);
        if (ValorP168 == 0)
        {
            Instantiate(P6_M, new Vector2(PosX168, myPosY + Intersecciones * 168), transform.rotation);
        }
        if (ValorP168 == 1)
        {
            Instantiate(P6_Q, new Vector2(PosX168, myPosY + Intersecciones * 168), transform.rotation);
        }
        if (ValorP168 == 2)
        {
            Instantiate(P6_M_SS, new Vector2(PosX168, myPosY + Intersecciones * 168), transform.rotation);
        }
        if (ValorP168 == 3)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX168, myPosY + Intersecciones * 168), transform.rotation);
        }
        if (ValorP168 == 4)
        {
            Instantiate(P6_M_P, new Vector2(PosX168, myPosY + Intersecciones * 168), transform.rotation);
        }
        if (ValorP168 == 5)
        {
            Instantiate(P6_Q_P, new Vector2(PosX168, myPosY + Intersecciones * 168), transform.rotation);
        }
        int ValorP169 = Random.Range(0, 6);
        float PosX169 = Random.Range(-2.6f, 2.6f);
        if (ValorP169 == 0)
        {
            Instantiate(P6_M, new Vector2(PosX169, myPosY + Intersecciones * 169), transform.rotation);
        }
        if (ValorP169 == 1)
        {
            Instantiate(P6_Q, new Vector2(PosX169, myPosY + Intersecciones * 169), transform.rotation);
        }
        if (ValorP169 == 2)
        {
            Instantiate(P6_M_SS, new Vector2(PosX169, myPosY + Intersecciones * 169), transform.rotation);
        }
        if (ValorP169 == 3)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX169, myPosY + Intersecciones * 169), transform.rotation);
        }
        if (ValorP169 == 4)
        {
            Instantiate(P6_M_P, new Vector2(PosX169, myPosY + Intersecciones * 169), transform.rotation);
        }
        if (ValorP169 == 5)
        {
            Instantiate(P6_Q_P, new Vector2(PosX169, myPosY + Intersecciones * 169), transform.rotation);
        }
        int ValorP170 = Random.Range(0, 6);
        float PosX170 = Random.Range(-2.6f, 2.6f);
        if (ValorP170 == 0)
        {
            Instantiate(P6_M, new Vector2(PosX170, myPosY + Intersecciones * 170), transform.rotation);
        }
        if (ValorP170 == 1)
        {
            Instantiate(P6_Q, new Vector2(PosX170, myPosY + Intersecciones * 170), transform.rotation);
        }
        if (ValorP170 == 2)
        {
            Instantiate(P6_M_SS, new Vector2(PosX170, myPosY + Intersecciones * 170), transform.rotation);
        }
        if (ValorP170 == 3)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX170, myPosY + Intersecciones * 170), transform.rotation);
        }
        if (ValorP170 == 4)
        {
            Instantiate(P6_M_P, new Vector2(PosX170, myPosY + Intersecciones * 170), transform.rotation);
        }
        if (ValorP170 == 5)
        {
            Instantiate(P6_Q_P, new Vector2(PosX170, myPosY + Intersecciones * 170), transform.rotation);
        }
        int ValorP171 = Random.Range(0, 12);
        float PosX171 = Random.Range(-2.6f, 2.6f);
        if (ValorP171 == 0)
        {
            Instantiate(P6_M, new Vector2(PosX171, myPosY + Intersecciones * 171), transform.rotation);
        }
        if (ValorP171 == 1)
        {
            Instantiate(P6_Q, new Vector2(PosX171, myPosY + Intersecciones * 171), transform.rotation);
        }
        if (ValorP171 == 2)
        {
            Instantiate(P6_M_SS, new Vector2(PosX171, myPosY + Intersecciones * 171), transform.rotation);
        }
        if (ValorP171 == 3)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX171, myPosY + Intersecciones * 171), transform.rotation);
        }
        if (ValorP171 == 4)
        {
            Instantiate(P6_M_P, new Vector2(PosX171, myPosY + Intersecciones * 171), transform.rotation);
        }
        if (ValorP171 == 5)
        {
            Instantiate(P6_Q_P, new Vector2(PosX171, myPosY + Intersecciones * 171), transform.rotation);
        }
        if (ValorP171 == 6)
        {
            Instantiate(P7_M, new Vector2(PosX171, myPosY + Intersecciones * 171), transform.rotation);
        }
        if (ValorP171 == 7)
        {
            Instantiate(P7_Q, new Vector2(PosX171, myPosY + Intersecciones * 171), transform.rotation);
        }
        if (ValorP171 == 8)
        {
            Instantiate(P7_M_SS, new Vector2(PosX171, myPosY + Intersecciones * 171), transform.rotation);
        }
        if (ValorP171 == 9)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX171, myPosY + Intersecciones * 171), transform.rotation);
        }
        if (ValorP171 == 10)
        {
            Instantiate(P7_M_P, new Vector2(PosX171, myPosY + Intersecciones * 171), transform.rotation);
        }
        if (ValorP171 == 11)
        {
            Instantiate(P7_Q_P, new Vector2(PosX171, myPosY + Intersecciones * 171), transform.rotation);
        }
        int ValorP172 = Random.Range(0, 12);
        float PosX172 = Random.Range(-2.6f, 2.6f);
        if (ValorP172 == 0)
        {
            Instantiate(P6_M, new Vector2(PosX172, myPosY + Intersecciones * 172), transform.rotation);
        }
        if (ValorP172 == 1)
        {
            Instantiate(P6_Q, new Vector2(PosX172, myPosY + Intersecciones * 172), transform.rotation);
        }
        if (ValorP172 == 2)
        {
            Instantiate(P6_M_SS, new Vector2(PosX172, myPosY + Intersecciones * 172), transform.rotation);
        }
        if (ValorP172 == 3)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX172, myPosY + Intersecciones * 172), transform.rotation);
        }
        if (ValorP172 == 4)
        {
            Instantiate(P6_M_P, new Vector2(PosX172, myPosY + Intersecciones * 172), transform.rotation);
        }
        if (ValorP172 == 5)
        {
            Instantiate(P6_Q_P, new Vector2(PosX172, myPosY + Intersecciones * 172), transform.rotation);
        }
        if (ValorP172 == 6)
        {
            Instantiate(P7_M, new Vector2(PosX172, myPosY + Intersecciones * 172), transform.rotation);
        }
        if (ValorP172 == 7)
        {
            Instantiate(P7_Q, new Vector2(PosX172, myPosY + Intersecciones * 172), transform.rotation);
        }
        if (ValorP172 == 8)
        {
            Instantiate(P7_M_SS, new Vector2(PosX172, myPosY + Intersecciones * 172), transform.rotation);
        }
        if (ValorP172 == 9)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX172, myPosY + Intersecciones * 172), transform.rotation);
        }
        if (ValorP172 == 10)
        {
            Instantiate(P7_M_P, new Vector2(PosX172, myPosY + Intersecciones * 172), transform.rotation);
        }
        if (ValorP172 == 11)
        {
            Instantiate(P7_Q_P, new Vector2(PosX172, myPosY + Intersecciones * 172), transform.rotation);
        }
        int ValorP173 = Random.Range(0, 12);
        float PosX173 = Random.Range(-2.6f, 2.6f);
        if (ValorP173 == 0)
        {
            Instantiate(P6_M, new Vector2(PosX173, myPosY + Intersecciones * 173), transform.rotation);
        }
        if (ValorP173 == 1)
        {
            Instantiate(P6_Q, new Vector2(PosX173, myPosY + Intersecciones * 173), transform.rotation);
        }
        if (ValorP173 == 2)
        {
            Instantiate(P6_M_SS, new Vector2(PosX173, myPosY + Intersecciones * 173), transform.rotation);
        }
        if (ValorP173 == 3)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX173, myPosY + Intersecciones * 173), transform.rotation);
        }
        if (ValorP173 == 4)
        {
            Instantiate(P6_M_P, new Vector2(PosX173, myPosY + Intersecciones * 173), transform.rotation);
        }
        if (ValorP173 == 5)
        {
            Instantiate(P6_Q_P, new Vector2(PosX173, myPosY + Intersecciones * 173), transform.rotation);
        }
        if (ValorP173 == 6)
        {
            Instantiate(P7_M, new Vector2(PosX173, myPosY + Intersecciones * 173), transform.rotation);
        }
        if (ValorP173 == 7)
        {
            Instantiate(P7_Q, new Vector2(PosX173, myPosY + Intersecciones * 173), transform.rotation);
        }
        if (ValorP173 == 8)
        {
            Instantiate(P7_M_SS, new Vector2(PosX173, myPosY + Intersecciones * 173), transform.rotation);
        }
        if (ValorP173 == 9)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX173, myPosY + Intersecciones * 173), transform.rotation);
        }
        if (ValorP173 == 10)
        {
            Instantiate(P7_M_P, new Vector2(PosX173, myPosY + Intersecciones * 173), transform.rotation);
        }
        if (ValorP173 == 11)
        {
            Instantiate(P7_Q_P, new Vector2(PosX173, myPosY + Intersecciones * 173), transform.rotation);
        }
        int ValorP174 = Random.Range(0, 12);
        float PosX174 = Random.Range(-2.6f, 2.6f);
        if (ValorP174 == 0)
        {
            Instantiate(P6_M, new Vector2(PosX174, myPosY + Intersecciones * 174), transform.rotation);
        }
        if (ValorP174 == 1)
        {
            Instantiate(P6_Q, new Vector2(PosX174, myPosY + Intersecciones * 174), transform.rotation);
        }
        if (ValorP174 == 2)
        {
            Instantiate(P6_M_SS, new Vector2(PosX174, myPosY + Intersecciones * 174), transform.rotation);
        }
        if (ValorP174 == 3)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX174, myPosY + Intersecciones * 174), transform.rotation);
        }
        if (ValorP174 == 4)
        {
            Instantiate(P6_M_P, new Vector2(PosX174, myPosY + Intersecciones * 174), transform.rotation);
        }
        if (ValorP174 == 5)
        {
            Instantiate(P6_Q_P, new Vector2(PosX174, myPosY + Intersecciones * 174), transform.rotation);
        }
        if (ValorP174 == 6)
        {
            Instantiate(P7_M, new Vector2(PosX174, myPosY + Intersecciones * 174), transform.rotation);
        }
        if (ValorP174 == 7)
        {
            Instantiate(P7_Q, new Vector2(PosX174, myPosY + Intersecciones * 174), transform.rotation);
        }
        if (ValorP174 == 8)
        {
            Instantiate(P7_M_SS, new Vector2(PosX174, myPosY + Intersecciones * 174), transform.rotation);
        }
        if (ValorP174 == 9)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX174, myPosY + Intersecciones * 174), transform.rotation);
        }
        if (ValorP174 == 10)
        {
            Instantiate(P7_M_P, new Vector2(PosX174, myPosY + Intersecciones * 174), transform.rotation);
        }
        if (ValorP174 == 11)
        {
            Instantiate(P7_Q_P, new Vector2(PosX174, myPosY + Intersecciones * 174), transform.rotation);
        }
        #endregion
        #region Nivel7
        int ValorP175 = Random.Range(0, 12);
        float PosX175 = Random.Range(-2.6f, 2.6f);
        if (ValorP175 == 0)
        {
            Instantiate(P6_M, new Vector2(PosX175, myPosY + Intersecciones * 175), transform.rotation);
        }
        if (ValorP175 == 1)
        {
            Instantiate(P6_Q, new Vector2(PosX175, myPosY + Intersecciones * 175), transform.rotation);
        }
        if (ValorP175 == 2)
        {
            Instantiate(P6_M_SS, new Vector2(PosX175, myPosY + Intersecciones * 175), transform.rotation);
        }
        if (ValorP175 == 3)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX175, myPosY + Intersecciones * 175), transform.rotation);
        }
        if (ValorP175 == 4)
        {
            Instantiate(P6_M_P, new Vector2(PosX175, myPosY + Intersecciones * 175), transform.rotation);
        }
        if (ValorP175 == 5)
        {
            Instantiate(P6_Q_P, new Vector2(PosX175, myPosY + Intersecciones * 175), transform.rotation);
        }
        if (ValorP175 == 6)
        {
            Instantiate(P7_M, new Vector2(PosX175, myPosY + Intersecciones * 175), transform.rotation);
        }
        if (ValorP175 == 7)
        {
            Instantiate(P7_Q, new Vector2(PosX175, myPosY + Intersecciones * 175), transform.rotation);
        }
        if (ValorP175 == 8)
        {
            Instantiate(P7_M_SS, new Vector2(PosX175, myPosY + Intersecciones * 175), transform.rotation);
        }
        if (ValorP175 == 9)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX175, myPosY + Intersecciones * 175), transform.rotation);
        }
        if (ValorP175 == 10)
        {
            Instantiate(P7_M_P, new Vector2(PosX175, myPosY + Intersecciones * 175), transform.rotation);
        }
        if (ValorP175 == 11)
        {
            Instantiate(P7_Q_P, new Vector2(PosX175, myPosY + Intersecciones * 175), transform.rotation);
        }
        int ValorP176 = Random.Range(0, 12);
        float PosX176 = Random.Range(-2.6f, 2.6f);
        if (ValorP176 == 0)
        {
            Instantiate(P6_M, new Vector2(PosX176, myPosY + Intersecciones * 176), transform.rotation);
        }
        if (ValorP176 == 1)
        {
            Instantiate(P6_Q, new Vector2(PosX176, myPosY + Intersecciones * 176), transform.rotation);
        }
        if (ValorP176 == 2)
        {
            Instantiate(P6_M_SS, new Vector2(PosX176, myPosY + Intersecciones * 176), transform.rotation);
        }
        if (ValorP176 == 3)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX176, myPosY + Intersecciones * 176), transform.rotation);
        }
        if (ValorP176 == 4)
        {
            Instantiate(P6_M_P, new Vector2(PosX176, myPosY + Intersecciones * 176), transform.rotation);
        }
        if (ValorP176 == 5)
        {
            Instantiate(P6_Q_P, new Vector2(PosX176, myPosY + Intersecciones * 176), transform.rotation);
        }
        if (ValorP176 == 6)
        {
            Instantiate(P7_M, new Vector2(PosX176, myPosY + Intersecciones * 176), transform.rotation);
        }
        if (ValorP176 == 7)
        {
            Instantiate(P7_Q, new Vector2(PosX176, myPosY + Intersecciones * 176), transform.rotation);
        }
        if (ValorP176 == 8)
        {
            Instantiate(P7_M_SS, new Vector2(PosX176, myPosY + Intersecciones * 176), transform.rotation);
        }
        if (ValorP176 == 9)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX176, myPosY + Intersecciones * 176), transform.rotation);
        }
        if (ValorP176 == 10)
        {
            Instantiate(P7_M_P, new Vector2(PosX176, myPosY + Intersecciones * 176), transform.rotation);
        }
        if (ValorP176 == 11)
        {
            Instantiate(P7_Q_P, new Vector2(PosX176, myPosY + Intersecciones * 176), transform.rotation);
        }
        int ValorP177 = Random.Range(0, 12);
        float PosX177 = Random.Range(-2.6f, 2.6f);
        if (ValorP177 == 0)
        {
            Instantiate(P6_M, new Vector2(PosX177, myPosY + Intersecciones * 177), transform.rotation);
        }
        if (ValorP177 == 1)
        {
            Instantiate(P6_Q, new Vector2(PosX177, myPosY + Intersecciones * 177), transform.rotation);
        }
        if (ValorP177 == 2)
        {
            Instantiate(P6_M_SS, new Vector2(PosX177, myPosY + Intersecciones * 177), transform.rotation);
        }
        if (ValorP177 == 3)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX177, myPosY + Intersecciones * 177), transform.rotation);
        }
        if (ValorP177 == 4)
        {
            Instantiate(P6_M_P, new Vector2(PosX177, myPosY + Intersecciones * 177), transform.rotation);
        }
        if (ValorP177 == 5)
        {
            Instantiate(P6_Q_P, new Vector2(PosX177, myPosY + Intersecciones * 177), transform.rotation);
        }
        if (ValorP177 == 6)
        {
            Instantiate(P7_M, new Vector2(PosX177, myPosY + Intersecciones * 177), transform.rotation);
        }
        if (ValorP177 == 7)
        {
            Instantiate(P7_Q, new Vector2(PosX177, myPosY + Intersecciones * 177), transform.rotation);
        }
        if (ValorP177 == 8)
        {
            Instantiate(P7_M_SS, new Vector2(PosX177, myPosY + Intersecciones * 177), transform.rotation);
        }
        if (ValorP177 == 9)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX177, myPosY + Intersecciones * 177), transform.rotation);
        }
        if (ValorP177 == 10)
        {
            Instantiate(P7_M_P, new Vector2(PosX177, myPosY + Intersecciones * 177), transform.rotation);
        }
        if (ValorP177 == 11)
        {
            Instantiate(P7_Q_P, new Vector2(PosX177, myPosY + Intersecciones * 177), transform.rotation);
        }
        int ValorP178 = Random.Range(0, 12);
        float PosX178 = Random.Range(-2.6f, 2.6f);
        if (ValorP178 == 0)
        {
            Instantiate(P6_M, new Vector2(PosX178, myPosY + Intersecciones * 178), transform.rotation);
        }
        if (ValorP178 == 1)
        {
            Instantiate(P6_Q, new Vector2(PosX178, myPosY + Intersecciones * 178), transform.rotation);
        }
        if (ValorP178 == 2)
        {
            Instantiate(P6_M_SS, new Vector2(PosX178, myPosY + Intersecciones * 178), transform.rotation);
        }
        if (ValorP178 == 3)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX178, myPosY + Intersecciones * 178), transform.rotation);
        }
        if (ValorP178 == 4)
        {
            Instantiate(P6_M_P, new Vector2(PosX178, myPosY + Intersecciones * 178), transform.rotation);
        }
        if (ValorP178 == 5)
        {
            Instantiate(P6_Q_P, new Vector2(PosX178, myPosY + Intersecciones * 178), transform.rotation);
        }
        if (ValorP178 == 6)
        {
            Instantiate(P7_M, new Vector2(PosX178, myPosY + Intersecciones * 178), transform.rotation);
        }
        if (ValorP178 == 7)
        {
            Instantiate(P7_Q, new Vector2(PosX178, myPosY + Intersecciones * 178), transform.rotation);
        }
        if (ValorP178 == 8)
        {
            Instantiate(P7_M_SS, new Vector2(PosX178, myPosY + Intersecciones * 178), transform.rotation);
        }
        if (ValorP178 == 9)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX178, myPosY + Intersecciones * 178), transform.rotation);
        }
        if (ValorP178 == 10)
        {
            Instantiate(P7_M_P, new Vector2(PosX178, myPosY + Intersecciones * 178), transform.rotation);
        }
        if (ValorP178 == 11)
        {
            Instantiate(P7_Q_P, new Vector2(PosX178, myPosY + Intersecciones * 178), transform.rotation);
        }
        int ValorP179 = Random.Range(0, 12);
        float PosX179 = Random.Range(-2.6f, 2.6f);
        if (ValorP179 == 0)
        {
            Instantiate(P6_M, new Vector2(PosX179, myPosY + Intersecciones * 179), transform.rotation);
        }
        if (ValorP179 == 1)
        {
            Instantiate(P6_Q, new Vector2(PosX179, myPosY + Intersecciones * 179), transform.rotation);
        }
        if (ValorP179 == 2)
        {
            Instantiate(P6_M_SS, new Vector2(PosX179, myPosY + Intersecciones * 179), transform.rotation);
        }
        if (ValorP179 == 3)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX179, myPosY + Intersecciones * 179), transform.rotation);
        }
        if (ValorP179 == 4)
        {
            Instantiate(P6_M_P, new Vector2(PosX179, myPosY + Intersecciones * 179), transform.rotation);
        }
        if (ValorP179 == 5)
        {
            Instantiate(P6_Q_P, new Vector2(PosX179, myPosY + Intersecciones * 179), transform.rotation);
        }
        if (ValorP179 == 6)
        {
            Instantiate(P7_M, new Vector2(PosX179, myPosY + Intersecciones * 179), transform.rotation);
        }
        if (ValorP179 == 7)
        {
            Instantiate(P7_Q, new Vector2(PosX179, myPosY + Intersecciones * 179), transform.rotation);
        }
        if (ValorP179 == 8)
        {
            Instantiate(P7_M_SS, new Vector2(PosX179, myPosY + Intersecciones * 179), transform.rotation);
        }
        if (ValorP179 == 9)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX179, myPosY + Intersecciones * 179), transform.rotation);
        }
        if (ValorP179 == 10)
        {
            Instantiate(P7_M_P, new Vector2(PosX179, myPosY + Intersecciones * 179), transform.rotation);
        }
        if (ValorP179 == 11)
        {
            Instantiate(P7_Q_P, new Vector2(PosX179, myPosY + Intersecciones * 179), transform.rotation);
        }
        int ValorP180 = Random.Range(0, 12);
        float PosX180 = Random.Range(-2.6f, 2.6f);
        if (ValorP180 == 0)
        {
            Instantiate(P6_M, new Vector2(PosX180, myPosY + Intersecciones * 180), transform.rotation);
        }
        if (ValorP180 == 1)
        {
            Instantiate(P6_Q, new Vector2(PosX180, myPosY + Intersecciones * 180), transform.rotation);
        }
        if (ValorP180 == 2)
        {
            Instantiate(P6_M_SS, new Vector2(PosX180, myPosY + Intersecciones * 180), transform.rotation);
        }
        if (ValorP180 == 3)
        {
            Instantiate(P6_Q_SS, new Vector2(PosX180, myPosY + Intersecciones * 180), transform.rotation);
        }
        if (ValorP180 == 4)
        {
            Instantiate(P6_M_P, new Vector2(PosX180, myPosY + Intersecciones * 180), transform.rotation);
        }
        if (ValorP180 == 5)
        {
            Instantiate(P6_Q_P, new Vector2(PosX180, myPosY + Intersecciones * 180), transform.rotation);
        }
        if (ValorP180 == 6)
        {
            Instantiate(P7_M, new Vector2(PosX180, myPosY + Intersecciones * 180), transform.rotation);
        }
        if (ValorP180 == 7)
        {
            Instantiate(P7_Q, new Vector2(PosX180, myPosY + Intersecciones * 180), transform.rotation);
        }
        if (ValorP180 == 8)
        {
            Instantiate(P7_M_SS, new Vector2(PosX180, myPosY + Intersecciones * 180), transform.rotation);
        }
        if (ValorP180 == 9)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX180, myPosY + Intersecciones * 180), transform.rotation);
        }
        if (ValorP180 == 10)
        {
            Instantiate(P7_M_P, new Vector2(PosX180, myPosY + Intersecciones * 180), transform.rotation);
        }
        if (ValorP180 == 11)
        {
            Instantiate(P7_Q_P, new Vector2(PosX180, myPosY + Intersecciones * 180), transform.rotation);
        }
        int ValorP181 = Random.Range(0, 6);
        float PosX181 = Random.Range(-2.6f, 2.6f);
        if (ValorP181 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX181, myPosY + Intersecciones * 181), transform.rotation);
        }
        if (ValorP181 == 1)
        {
            Instantiate(P7_Q, new Vector2(PosX181, myPosY + Intersecciones * 181), transform.rotation);
        }
        if (ValorP181 == 2)
        {
            Instantiate(P7_M_SS, new Vector2(PosX181, myPosY + Intersecciones * 181), transform.rotation);
        }
        if (ValorP181 == 3)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX181, myPosY + Intersecciones * 181), transform.rotation);
        }
        if (ValorP181 == 4)
        {
            Instantiate(P7_M_P, new Vector2(PosX181, myPosY + Intersecciones * 181), transform.rotation);
        }
        if (ValorP181 == 5)
        {
            Instantiate(P7_Q_P, new Vector2(PosX181, myPosY + Intersecciones * 181), transform.rotation);
        }
        int ValorP182 = Random.Range(0, 6);
        float PosX182 = Random.Range(-2.6f, 2.6f);
        if (ValorP182 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX182, myPosY + Intersecciones * 182), transform.rotation);
        }
        if (ValorP182 == 1)
        {
            Instantiate(P7_Q, new Vector2(PosX182, myPosY + Intersecciones * 182), transform.rotation);
        }
        if (ValorP182 == 2)
        {
            Instantiate(P7_M_SS, new Vector2(PosX182, myPosY + Intersecciones * 182), transform.rotation);
        }
        if (ValorP182 == 3)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX182, myPosY + Intersecciones * 182), transform.rotation);
        }
        if (ValorP182 == 4)
        {
            Instantiate(P7_M_P, new Vector2(PosX182, myPosY + Intersecciones * 182), transform.rotation);
        }
        if (ValorP182 == 5)
        {
            Instantiate(P7_Q_P, new Vector2(PosX182, myPosY + Intersecciones * 182), transform.rotation);
        }
        int ValorP183 = Random.Range(0, 6);
        float PosX183 = Random.Range(-2.6f, 2.6f);
        if (ValorP183 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX183, myPosY + Intersecciones * 183), transform.rotation);
        }
        if (ValorP183 == 1)
        {
            Instantiate(P7_Q, new Vector2(PosX183, myPosY + Intersecciones * 183), transform.rotation);
        }
        if (ValorP183 == 2)
        {
            Instantiate(P7_M_SS, new Vector2(PosX183, myPosY + Intersecciones * 183), transform.rotation);
        }
        if (ValorP183 == 3)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX183, myPosY + Intersecciones * 183), transform.rotation);
        }
        if (ValorP183 == 4)
        {
            Instantiate(P7_M_P, new Vector2(PosX183, myPosY + Intersecciones * 183), transform.rotation);
        }
        if (ValorP183 == 5)
        {
            Instantiate(P7_Q_P, new Vector2(PosX183, myPosY + Intersecciones * 183), transform.rotation);
        }
        int ValorP184 = Random.Range(0, 6);
        float PosX184 = Random.Range(-2.6f, 2.6f);
        if (ValorP184 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX184, myPosY + Intersecciones * 184), transform.rotation);
        }
        if (ValorP184 == 1)
        {
            Instantiate(P7_Q, new Vector2(PosX184, myPosY + Intersecciones * 184), transform.rotation);
        }
        if (ValorP184 == 2)
        {
            Instantiate(P7_M_SS, new Vector2(PosX184, myPosY + Intersecciones * 184), transform.rotation);
        }
        if (ValorP184 == 3)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX184, myPosY + Intersecciones * 184), transform.rotation);
        }
        if (ValorP184 == 4)
        {
            Instantiate(P7_M_P, new Vector2(PosX184, myPosY + Intersecciones * 184), transform.rotation);
        }
        if (ValorP184 == 5)
        {
            Instantiate(P7_Q_P, new Vector2(PosX184, myPosY + Intersecciones * 184), transform.rotation);
        }
        int ValorP185 = Random.Range(0, 6);
        float PosX185 = Random.Range(-2.6f, 2.6f);
        if (ValorP185 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX185, myPosY + Intersecciones * 185), transform.rotation);
        }
        if (ValorP185 == 1)
        {
            Instantiate(P7_Q, new Vector2(PosX185, myPosY + Intersecciones * 185), transform.rotation);
        }
        if (ValorP185 == 2)
        {
            Instantiate(P7_M_SS, new Vector2(PosX185, myPosY + Intersecciones * 185), transform.rotation);
        }
        if (ValorP185 == 3)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX185, myPosY + Intersecciones * 185), transform.rotation);
        }
        if (ValorP185 == 4)
        {
            Instantiate(P7_M_P, new Vector2(PosX185, myPosY + Intersecciones * 185), transform.rotation);
        }
        if (ValorP185 == 5)
        {
            Instantiate(P7_Q_P, new Vector2(PosX185, myPosY + Intersecciones * 185), transform.rotation);
        }
        int ValorP186 = Random.Range(0, 6);
        float PosX186 = Random.Range(-2.6f, 2.6f);
        if (ValorP186 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX186, myPosY + Intersecciones * 186), transform.rotation);
        }
        if (ValorP186 == 1)
        {
            Instantiate(P7_Q, new Vector2(PosX186, myPosY + Intersecciones * 186), transform.rotation);
        }
        if (ValorP186 == 2)
        {
            Instantiate(P7_M_SS, new Vector2(PosX186, myPosY + Intersecciones * 186), transform.rotation);
        }
        if (ValorP186 == 3)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX186, myPosY + Intersecciones * 186), transform.rotation);
        }
        if (ValorP186 == 4)
        {
            Instantiate(P7_M_P, new Vector2(PosX186, myPosY + Intersecciones * 186), transform.rotation);
        }
        if (ValorP186 == 5)
        {
            Instantiate(P7_Q_P, new Vector2(PosX186, myPosY + Intersecciones * 186), transform.rotation);
        }
        int ValorP187 = Random.Range(0, 6);
        float PosX187 = Random.Range(-2.6f, 2.6f);
        if (ValorP187 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX187, myPosY + Intersecciones * 187), transform.rotation);
        }
        if (ValorP187 == 1)
        {
            Instantiate(P7_Q, new Vector2(PosX187, myPosY + Intersecciones * 187), transform.rotation);
        }
        if (ValorP187 == 2)
        {
            Instantiate(P7_M_SS, new Vector2(PosX187, myPosY + Intersecciones * 187), transform.rotation);
        }
        if (ValorP187 == 3)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX187, myPosY + Intersecciones * 187), transform.rotation);
        }
        if (ValorP187 == 4)
        {
            Instantiate(P7_M_P, new Vector2(PosX187, myPosY + Intersecciones * 187), transform.rotation);
        }
        if (ValorP187 == 5)
        {
            Instantiate(P7_Q_P, new Vector2(PosX187, myPosY + Intersecciones * 187), transform.rotation);
        }
        int ValorP188 = Random.Range(0, 6);
        float PosX188 = Random.Range(-2.6f, 2.6f);
        if (ValorP188 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX188, myPosY + Intersecciones * 188), transform.rotation);
        }
        if (ValorP188 == 1)
        {
            Instantiate(P7_Q, new Vector2(PosX188, myPosY + Intersecciones * 188), transform.rotation);
        }
        if (ValorP188 == 2)
        {
            Instantiate(P7_M_SS, new Vector2(PosX188, myPosY + Intersecciones * 188), transform.rotation);
        }
        if (ValorP188 == 3)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX188, myPosY + Intersecciones * 188), transform.rotation);
        }
        if (ValorP188 == 4)
        {
            Instantiate(P7_M_P, new Vector2(PosX188, myPosY + Intersecciones * 188), transform.rotation);
        }
        if (ValorP188 == 5)
        {
            Instantiate(P7_Q_P, new Vector2(PosX188, myPosY + Intersecciones * 188), transform.rotation);
        }
        int ValorP189 = Random.Range(0, 6);
        float PosX189 = Random.Range(-2.6f, 2.6f);
        if (ValorP189 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX189, myPosY + Intersecciones * 189), transform.rotation);
        }
        if (ValorP189 == 1)
        {
            Instantiate(P7_Q, new Vector2(PosX189, myPosY + Intersecciones * 189), transform.rotation);
        }
        if (ValorP189 == 2)
        {
            Instantiate(P7_M_SS, new Vector2(PosX189, myPosY + Intersecciones * 189), transform.rotation);
        }
        if (ValorP189 == 3)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX189, myPosY + Intersecciones * 189), transform.rotation);
        }
        if (ValorP189 == 4)
        {
            Instantiate(P7_M_P, new Vector2(PosX189, myPosY + Intersecciones * 189), transform.rotation);
        }
        if (ValorP189 == 5)
        {
            Instantiate(P7_Q_P, new Vector2(PosX189, myPosY + Intersecciones * 189), transform.rotation);
        }
        int ValorP190 = Random.Range(0, 6);
        float PosX190 = Random.Range(-2.6f, 2.6f);
        if (ValorP190 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX190, myPosY + Intersecciones * 190), transform.rotation);
        }
        if (ValorP190 == 1)
        {
            Instantiate(P7_Q, new Vector2(PosX190, myPosY + Intersecciones * 190), transform.rotation);
        }
        if (ValorP190 == 2)
        {
            Instantiate(P7_M_SS, new Vector2(PosX190, myPosY + Intersecciones * 190), transform.rotation);
        }
        if (ValorP190 == 3)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX190, myPosY + Intersecciones * 190), transform.rotation);
        }
        if (ValorP190 == 4)
        {
            Instantiate(P7_M_P, new Vector2(PosX190, myPosY + Intersecciones * 190), transform.rotation);
        }
        if (ValorP190 == 5)
        {
            Instantiate(P7_Q_P, new Vector2(PosX190, myPosY + Intersecciones * 190), transform.rotation);
        }
        int ValorP191 = Random.Range(0, 6);
        float PosX191 = Random.Range(-2.6f, 2.6f);
        if (ValorP191 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX191, myPosY + Intersecciones * 191), transform.rotation);
        }
        if (ValorP191 == 1)
        {
            Instantiate(P7_Q, new Vector2(PosX191, myPosY + Intersecciones * 191), transform.rotation);
        }
        if (ValorP191 == 2)
        {
            Instantiate(P7_M_SS, new Vector2(PosX191, myPosY + Intersecciones * 191), transform.rotation);
        }
        if (ValorP191 == 3)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX191, myPosY + Intersecciones * 191), transform.rotation);
        }
        if (ValorP191 == 4)
        {
            Instantiate(P7_M_P, new Vector2(PosX191, myPosY + Intersecciones * 191), transform.rotation);
        }
        if (ValorP191 == 5)
        {
            Instantiate(P7_Q_P, new Vector2(PosX191, myPosY + Intersecciones * 191), transform.rotation);
        }
        int ValorP192 = Random.Range(0, 6);
        float PosX192 = Random.Range(-2.6f, 2.6f);
        if (ValorP192 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX192, myPosY + Intersecciones * 192), transform.rotation);
        }
        if (ValorP192 == 1)
        {
            Instantiate(P7_Q, new Vector2(PosX192, myPosY + Intersecciones * 192), transform.rotation);
        }
        if (ValorP192 == 2)
        {
            Instantiate(P7_M_SS, new Vector2(PosX192, myPosY + Intersecciones * 192), transform.rotation);
        }
        if (ValorP192 == 3)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX192, myPosY + Intersecciones * 192), transform.rotation);
        }
        if (ValorP192 == 4)
        {
            Instantiate(P7_M_P, new Vector2(PosX192, myPosY + Intersecciones * 192), transform.rotation);
        }
        if (ValorP192 == 5)
        {
            Instantiate(P7_Q_P, new Vector2(PosX192, myPosY + Intersecciones * 192), transform.rotation);
        }
        int ValorP193 = Random.Range(0, 6);
        float PosX193 = Random.Range(-2.6f, 2.6f);
        if (ValorP193 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX193, myPosY + Intersecciones * 193), transform.rotation);
        }
        if (ValorP193 == 1)
        {
            Instantiate(P7_Q, new Vector2(PosX193, myPosY + Intersecciones * 193), transform.rotation);
        }
        if (ValorP193 == 2)
        {
            Instantiate(P7_M_SS, new Vector2(PosX193, myPosY + Intersecciones * 193), transform.rotation);
        }
        if (ValorP193 == 3)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX193, myPosY + Intersecciones * 193), transform.rotation);
        }
        if (ValorP193 == 4)
        {
            Instantiate(P7_M_P, new Vector2(PosX193, myPosY + Intersecciones * 193), transform.rotation);
        }
        if (ValorP193 == 5)
        {
            Instantiate(P7_Q_P, new Vector2(PosX193, myPosY + Intersecciones * 193), transform.rotation);
        }
        int ValorP194 = Random.Range(0, 6);
        float PosX194 = Random.Range(-2.6f, 2.6f);
        if (ValorP194 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX194, myPosY + Intersecciones * 194), transform.rotation);
        }
        if (ValorP194 == 1)
        {
            Instantiate(P7_Q, new Vector2(PosX194, myPosY + Intersecciones * 194), transform.rotation);
        }
        if (ValorP194 == 2)
        {
            Instantiate(P7_M_SS, new Vector2(PosX194, myPosY + Intersecciones * 194), transform.rotation);
        }
        if (ValorP194 == 3)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX194, myPosY + Intersecciones * 194), transform.rotation);
        }
        if (ValorP194 == 4)
        {
            Instantiate(P7_M_P, new Vector2(PosX194, myPosY + Intersecciones * 194), transform.rotation);
        }
        if (ValorP194 == 5)
        {
            Instantiate(P7_Q_P, new Vector2(PosX194, myPosY + Intersecciones * 194), transform.rotation);
        }
        int ValorP195 = Random.Range(0, 6);
        float PosX195 = Random.Range(-2.6f, 2.6f);
        if (ValorP195 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX195, myPosY + Intersecciones * 195), transform.rotation);
        }
        if (ValorP195 == 1)
        {
            Instantiate(P7_Q, new Vector2(PosX195, myPosY + Intersecciones * 195), transform.rotation);
        }
        if (ValorP195 == 2)
        {
            Instantiate(P7_M_SS, new Vector2(PosX195, myPosY + Intersecciones * 195), transform.rotation);
        }
        if (ValorP195 == 3)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX195, myPosY + Intersecciones * 195), transform.rotation);
        }
        if (ValorP195 == 4)
        {
            Instantiate(P7_M_P, new Vector2(PosX195, myPosY + Intersecciones * 195), transform.rotation);
        }
        if (ValorP195 == 5)
        {
            Instantiate(P7_Q_P, new Vector2(PosX195, myPosY + Intersecciones * 195), transform.rotation);
        }
        int ValorP196 = Random.Range(0, 6);
        float PosX196 = Random.Range(-2.6f, 2.6f);
        if (ValorP196 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX196, myPosY + Intersecciones * 196), transform.rotation);
        }
        if (ValorP196 == 1)
        {
            Instantiate(P7_Q, new Vector2(PosX196, myPosY + Intersecciones * 196), transform.rotation);
        }
        if (ValorP196 == 2)
        {
            Instantiate(P7_M_SS, new Vector2(PosX196, myPosY + Intersecciones * 196), transform.rotation);
        }
        if (ValorP196 == 3)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX196, myPosY + Intersecciones * 196), transform.rotation);
        }
        if (ValorP196 == 4)
        {
            Instantiate(P7_M_P, new Vector2(PosX196, myPosY + Intersecciones * 196), transform.rotation);
        }
        if (ValorP196 == 5)
        {
            Instantiate(P7_Q_P, new Vector2(PosX196, myPosY + Intersecciones * 196), transform.rotation);
        }
        int ValorP197 = Random.Range(0, 6);
        float PosX197 = Random.Range(-2.6f, 2.6f);
        if (ValorP197 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX197, myPosY + Intersecciones * 197), transform.rotation);
        }
        if (ValorP197 == 1)
        {
            Instantiate(P7_Q, new Vector2(PosX197, myPosY + Intersecciones * 197), transform.rotation);
        }
        if (ValorP197 == 2)
        {
            Instantiate(P7_M_SS, new Vector2(PosX197, myPosY + Intersecciones * 197), transform.rotation);
        }
        if (ValorP197 == 3)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX197, myPosY + Intersecciones * 197), transform.rotation);
        }
        if (ValorP197 == 4)
        {
            Instantiate(P7_M_P, new Vector2(PosX197, myPosY + Intersecciones * 197), transform.rotation);
        }
        if (ValorP197 == 5)
        {
            Instantiate(P7_Q_P, new Vector2(PosX197, myPosY + Intersecciones * 197), transform.rotation);
        }
        int ValorP198 = Random.Range(0, 6);
        float PosX198 = Random.Range(-2.6f, 2.6f);
        if (ValorP198 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX198, myPosY + Intersecciones * 198), transform.rotation);
        }
        if (ValorP198 == 1)
        {
            Instantiate(P7_Q, new Vector2(PosX198, myPosY + Intersecciones * 198), transform.rotation);
        }
        if (ValorP198 == 2)
        {
            Instantiate(P7_M_SS, new Vector2(PosX198, myPosY + Intersecciones * 198), transform.rotation);
        }
        if (ValorP198 == 3)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX198, myPosY + Intersecciones * 198), transform.rotation);
        }
        if (ValorP198 == 4)
        {
            Instantiate(P7_M_P, new Vector2(PosX198, myPosY + Intersecciones * 198), transform.rotation);
        }
        if (ValorP198 == 5)
        {
            Instantiate(P7_Q_P, new Vector2(PosX198, myPosY + Intersecciones * 198), transform.rotation);
        }
        int ValorP199 = Random.Range(0, 6);
        float PosX199 = Random.Range(-2.6f, 2.6f);
        if (ValorP199 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX199, myPosY + Intersecciones * 199), transform.rotation);
        }
        if (ValorP199 == 1)
        {
            Instantiate(P7_Q, new Vector2(PosX199, myPosY + Intersecciones * 199), transform.rotation);
        }
        if (ValorP199 == 2)
        {
            Instantiate(P7_M_SS, new Vector2(PosX199, myPosY + Intersecciones * 199), transform.rotation);
        }
        if (ValorP199 == 3)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX199, myPosY + Intersecciones * 199), transform.rotation);
        }
        if (ValorP199 == 4)
        {
            Instantiate(P7_M_P, new Vector2(PosX199, myPosY + Intersecciones * 199), transform.rotation);
        }
        if (ValorP199 == 5)
        {
            Instantiate(P7_Q_P, new Vector2(PosX199, myPosY + Intersecciones * 199), transform.rotation);
        }
        int ValorP200 = Random.Range(0, 6);
        float PosX200 = Random.Range(-2.6f, 2.6f);
        if (ValorP200 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX200, myPosY + Intersecciones * 200), transform.rotation);
        }
        if (ValorP200 == 1)
        {
            Instantiate(P7_Q, new Vector2(PosX200, myPosY + Intersecciones * 200), transform.rotation);
        }
        if (ValorP200 == 2)
        {
            Instantiate(P7_M_SS, new Vector2(PosX200, myPosY + Intersecciones * 200), transform.rotation);
        }
        if (ValorP200 == 3)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX200, myPosY + Intersecciones * 200), transform.rotation);
        }
        if (ValorP200 == 4)
        {
            Instantiate(P7_M_P, new Vector2(PosX200, myPosY + Intersecciones * 200), transform.rotation);
        }
        if (ValorP200 == 5)
        {
            Instantiate(P7_Q_P, new Vector2(PosX200, myPosY + Intersecciones * 200), transform.rotation);
        }
        int ValorP201 = Random.Range(0, 6);
        float PosX201 = Random.Range(-2.6f, 2.6f);
        if (ValorP201 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX201, myPosY + Intersecciones * 201), transform.rotation);
        }
        if (ValorP201 == 1)
        {
            Instantiate(P7_Q, new Vector2(PosX201, myPosY + Intersecciones * 201), transform.rotation);
        }
        if (ValorP201 == 2)
        {
            Instantiate(P7_M_SS, new Vector2(PosX201, myPosY + Intersecciones * 201), transform.rotation);
        }
        if (ValorP201 == 3)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX201, myPosY + Intersecciones * 201), transform.rotation);
        }
        if (ValorP201 == 4)
        {
            Instantiate(P7_M_P, new Vector2(PosX201, myPosY + Intersecciones * 201), transform.rotation);
        }
        if (ValorP201 == 5)
        {
            Instantiate(P7_Q_P, new Vector2(PosX201, myPosY + Intersecciones * 201), transform.rotation);
        }
        int ValorP202 = Random.Range(0, 12);
        float PosX202 = Random.Range(-2.6f, 2.6f);
        if (ValorP202 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX202, myPosY + Intersecciones * 202), transform.rotation);
        }
        if (ValorP202 == 2)
        {
            Instantiate(P7_Q, new Vector2(PosX202, myPosY + Intersecciones * 202), transform.rotation);
        }
        if (ValorP202 == 4)
        {
            Instantiate(P7_M_SS, new Vector2(PosX202, myPosY + Intersecciones * 202), transform.rotation);
        }
        if (ValorP202 == 6)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX202, myPosY + Intersecciones * 202), transform.rotation);
        }
        if (ValorP202 == 8)
        {
            Instantiate(P7_M_P, new Vector2(PosX202, myPosY + Intersecciones * 202), transform.rotation);
        }
        if (ValorP202 == 10)
        {
            Instantiate(P7_Q_P, new Vector2(PosX202, myPosY + Intersecciones * 202), transform.rotation);
        }
        if (ValorP202 == 1)
        {
            Instantiate(P8_M, new Vector2(PosX202, myPosY + Intersecciones * 202), transform.rotation);
        }
        if (ValorP202 == 3)
        {
            Instantiate(P8_Q, new Vector2(PosX202, myPosY + Intersecciones * 202), transform.rotation);
        }
        if (ValorP202 == 5)
        {
            Instantiate(P8_M_SS, new Vector2(PosX202, myPosY + Intersecciones * 202), transform.rotation);
        }
        if (ValorP202 == 7)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX202, myPosY + Intersecciones * 202), transform.rotation);
        }
        if (ValorP202 == 9)
        {
            Instantiate(P8_M_P, new Vector2(PosX202, myPosY + Intersecciones * 202), transform.rotation);
        }
        if (ValorP202 == 11)
        {
            Instantiate(P8_Q_P, new Vector2(PosX202, myPosY + Intersecciones * 202), transform.rotation);
        }
        int ValorP203 = Random.Range(0, 12);
        float PosX203 = Random.Range(-2.6f, 2.6f);
        if (ValorP203 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX203, myPosY + Intersecciones * 203), transform.rotation);
        }
        if (ValorP203 == 2)
        {
            Instantiate(P7_Q, new Vector2(PosX203, myPosY + Intersecciones * 203), transform.rotation);
        }
        if (ValorP203 == 4)
        {
            Instantiate(P7_M_SS, new Vector2(PosX203, myPosY + Intersecciones * 203), transform.rotation);
        }
        if (ValorP203 == 6)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX203, myPosY + Intersecciones * 203), transform.rotation);
        }
        if (ValorP203 == 8)
        {
            Instantiate(P7_M_P, new Vector2(PosX203, myPosY + Intersecciones * 203), transform.rotation);
        }
        if (ValorP203 == 10)
        {
            Instantiate(P7_Q_P, new Vector2(PosX203, myPosY + Intersecciones * 203), transform.rotation);
        }
        if (ValorP203 == 1)
        {
            Instantiate(P8_M, new Vector2(PosX203, myPosY + Intersecciones * 203), transform.rotation);
        }
        if (ValorP203 == 3)
        {
            Instantiate(P8_Q, new Vector2(PosX203, myPosY + Intersecciones * 203), transform.rotation);
        }
        if (ValorP203 == 5)
        {
            Instantiate(P8_M_SS, new Vector2(PosX203, myPosY + Intersecciones * 203), transform.rotation);
        }
        if (ValorP203 == 7)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX203, myPosY + Intersecciones * 203), transform.rotation);
        }
        if (ValorP203 == 9)
        {
            Instantiate(P8_M_P, new Vector2(PosX203, myPosY + Intersecciones * 203), transform.rotation);
        }
        if (ValorP203 == 11)
        {
            Instantiate(P8_Q_P, new Vector2(PosX203, myPosY + Intersecciones * 203), transform.rotation);
        }
        int ValorP204 = Random.Range(0, 12);
        float PosX204 = Random.Range(-2.6f, 2.6f);
        if (ValorP204 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX204, myPosY + Intersecciones * 204), transform.rotation);
        }
        if (ValorP204 == 2)
        {
            Instantiate(P7_Q, new Vector2(PosX204, myPosY + Intersecciones * 204), transform.rotation);
        }
        if (ValorP204 == 4)
        {
            Instantiate(P7_M_SS, new Vector2(PosX204, myPosY + Intersecciones * 204), transform.rotation);
        }
        if (ValorP204 == 6)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX204, myPosY + Intersecciones * 204), transform.rotation);
        }
        if (ValorP204 == 8)
        {
            Instantiate(P7_M_P, new Vector2(PosX204, myPosY + Intersecciones * 204), transform.rotation);
        }
        if (ValorP204 == 10)
        {
            Instantiate(P7_Q_P, new Vector2(PosX204, myPosY + Intersecciones * 204), transform.rotation);
        }
        if (ValorP204 == 1)
        {
            Instantiate(P8_M, new Vector2(PosX204, myPosY + Intersecciones * 204), transform.rotation);
        }
        if (ValorP204 == 3)
        {
            Instantiate(P8_Q, new Vector2(PosX204, myPosY + Intersecciones * 204), transform.rotation);
        }
        if (ValorP204 == 5)
        {
            Instantiate(P8_M_SS, new Vector2(PosX204, myPosY + Intersecciones * 204), transform.rotation);
        }
        if (ValorP204 == 7)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX204, myPosY + Intersecciones * 204), transform.rotation);
        }
        if (ValorP204 == 9)
        {
            Instantiate(P8_M_P, new Vector2(PosX204, myPosY + Intersecciones * 204), transform.rotation);
        }
        if (ValorP204 == 11)
        {
            Instantiate(P8_Q_P, new Vector2(PosX204, myPosY + Intersecciones * 204), transform.rotation);
        }
        int ValorP205 = Random.Range(0, 12);
        float PosX205 = Random.Range(-2.6f, 2.6f);
        if (ValorP205 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX205, myPosY + Intersecciones * 205), transform.rotation);
        }
        if (ValorP205 == 2)
        {
            Instantiate(P7_Q, new Vector2(PosX205, myPosY + Intersecciones * 205), transform.rotation);
        }
        if (ValorP205 == 4)
        {
            Instantiate(P7_M_SS, new Vector2(PosX205, myPosY + Intersecciones * 205), transform.rotation);
        }
        if (ValorP205 == 6)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX205, myPosY + Intersecciones * 205), transform.rotation);
        }
        if (ValorP205 == 8)
        {
            Instantiate(P7_M_P, new Vector2(PosX205, myPosY + Intersecciones * 205), transform.rotation);
        }
        if (ValorP205 == 10)
        {
            Instantiate(P7_Q_P, new Vector2(PosX205, myPosY + Intersecciones * 205), transform.rotation);
        }
        if (ValorP205 == 1)
        {
            Instantiate(P8_M, new Vector2(PosX205, myPosY + Intersecciones * 205), transform.rotation);
        }
        if (ValorP205 == 3)
        {
            Instantiate(P8_Q, new Vector2(PosX205, myPosY + Intersecciones * 205), transform.rotation);
        }
        if (ValorP205 == 5)
        {
            Instantiate(P8_M_SS, new Vector2(PosX205, myPosY + Intersecciones * 205), transform.rotation);
        }
        if (ValorP205 == 7)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX205, myPosY + Intersecciones * 205), transform.rotation);
        }
        if (ValorP205 == 9)
        {
            Instantiate(P8_M_P, new Vector2(PosX205, myPosY + Intersecciones * 205), transform.rotation);
        }
        if (ValorP205 == 11)
        {
            Instantiate(P8_Q_P, new Vector2(PosX205, myPosY + Intersecciones * 205), transform.rotation);
        }
        int ValorP206 = Random.Range(0, 12);
        float PosX206 = Random.Range(-2.6f, 2.6f);
        if (ValorP206 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX206, myPosY + Intersecciones * 206), transform.rotation);
        }
        if (ValorP206 == 2)
        {
            Instantiate(P7_Q, new Vector2(PosX206, myPosY + Intersecciones * 206), transform.rotation);
        }
        if (ValorP206 == 4)
        {
            Instantiate(P7_M_SS, new Vector2(PosX206, myPosY + Intersecciones * 206), transform.rotation);
        }
        if (ValorP206 == 6)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX206, myPosY + Intersecciones * 206), transform.rotation);
        }
        if (ValorP206 == 8)
        {
            Instantiate(P7_M_P, new Vector2(PosX206, myPosY + Intersecciones * 206), transform.rotation);
        }
        if (ValorP206 == 10)
        {
            Instantiate(P7_Q_P, new Vector2(PosX206, myPosY + Intersecciones * 206), transform.rotation);
        }
        if (ValorP206 == 1)
        {
            Instantiate(P8_M, new Vector2(PosX206, myPosY + Intersecciones * 206), transform.rotation);
        }
        if (ValorP206 == 3)
        {
            Instantiate(P8_Q, new Vector2(PosX206, myPosY + Intersecciones * 206), transform.rotation);
        }
        if (ValorP206 == 5)
        {
            Instantiate(P8_M_SS, new Vector2(PosX206, myPosY + Intersecciones * 206), transform.rotation);
        }
        if (ValorP206 == 7)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX206, myPosY + Intersecciones * 206), transform.rotation);
        }
        if (ValorP206 == 9)
        {
            Instantiate(P8_M_P, new Vector2(PosX206, myPosY + Intersecciones * 206), transform.rotation);
        }
        if (ValorP206 == 11)
        {
            Instantiate(P8_Q_P, new Vector2(PosX206, myPosY + Intersecciones * 206), transform.rotation);
        }
        int ValorP207 = Random.Range(0, 12);
        float PosX207 = Random.Range(-2.6f, 2.6f);
        if (ValorP207 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX207, myPosY + Intersecciones * 207), transform.rotation);
        }
        if (ValorP207 == 2)
        {
            Instantiate(P7_Q, new Vector2(PosX207, myPosY + Intersecciones * 207), transform.rotation);
        }
        if (ValorP207 == 4)
        {
            Instantiate(P7_M_SS, new Vector2(PosX207, myPosY + Intersecciones * 207), transform.rotation);
        }
        if (ValorP207 == 6)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX207, myPosY + Intersecciones * 207), transform.rotation);
        }
        if (ValorP207 == 8)
        {
            Instantiate(P7_M_P, new Vector2(PosX207, myPosY + Intersecciones * 207), transform.rotation);
        }
        if (ValorP207 == 10)
        {
            Instantiate(P7_Q_P, new Vector2(PosX207, myPosY + Intersecciones * 207), transform.rotation);
        }
        if (ValorP207 == 1)
        {
            Instantiate(P8_M, new Vector2(PosX207, myPosY + Intersecciones * 207), transform.rotation);
        }
        if (ValorP207 == 3)
        {
            Instantiate(P8_Q, new Vector2(PosX207, myPosY + Intersecciones * 207), transform.rotation);
        }
        if (ValorP207 == 5)
        {
            Instantiate(P8_M_SS, new Vector2(PosX207, myPosY + Intersecciones * 207), transform.rotation);
        }
        if (ValorP207 == 7)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX207, myPosY + Intersecciones * 207), transform.rotation);
        }
        if (ValorP207 == 9)
        {
            Instantiate(P8_M_P, new Vector2(PosX207, myPosY + Intersecciones * 207), transform.rotation);
        }
        if (ValorP207 == 11)
        {
            Instantiate(P8_Q_P, new Vector2(PosX207, myPosY + Intersecciones * 207), transform.rotation);
        }
        #endregion
        #region Nivel8
        int ValorP208 = Random.Range(0, 12);
        float PosX208 = Random.Range(-2.6f, 2.6f);
        if (ValorP208 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX208, myPosY + Intersecciones * 208), transform.rotation);
        }
        if (ValorP208 == 2)
        {
            Instantiate(P7_Q, new Vector2(PosX208, myPosY + Intersecciones * 208), transform.rotation);
        }
        if (ValorP208 == 4)
        {
            Instantiate(P7_M_SS, new Vector2(PosX208, myPosY + Intersecciones * 208), transform.rotation);
        }
        if (ValorP208 == 6)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX208, myPosY + Intersecciones * 208), transform.rotation);
        }
        if (ValorP208 == 8)
        {
            Instantiate(P7_M_P, new Vector2(PosX208, myPosY + Intersecciones * 208), transform.rotation);
        }
        if (ValorP208 == 10)
        {
            Instantiate(P7_Q_P, new Vector2(PosX208, myPosY + Intersecciones * 208), transform.rotation);
        }
        if (ValorP208 == 1)
        {
            Instantiate(P8_M, new Vector2(PosX208, myPosY + Intersecciones * 208), transform.rotation);
        }
        if (ValorP208 == 3)
        {
            Instantiate(P8_Q, new Vector2(PosX208, myPosY + Intersecciones * 208), transform.rotation);
        }
        if (ValorP208 == 5)
        {
            Instantiate(P8_M_SS, new Vector2(PosX208, myPosY + Intersecciones * 208), transform.rotation);
        }
        if (ValorP208 == 7)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX208, myPosY + Intersecciones * 208), transform.rotation);
        }
        if (ValorP208 == 9)
        {
            Instantiate(P8_M_P, new Vector2(PosX208, myPosY + Intersecciones * 208), transform.rotation);
        }
        if (ValorP208 == 11)
        {
            Instantiate(P8_Q_P, new Vector2(PosX208, myPosY + Intersecciones * 208), transform.rotation);
        }
        int ValorP209 = Random.Range(0, 12);
        float PosX209 = Random.Range(-2.6f, 2.6f);
        if (ValorP209 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX209, myPosY + Intersecciones * 209), transform.rotation);
        }
        if (ValorP209 == 2)
        {
            Instantiate(P7_Q, new Vector2(PosX209, myPosY + Intersecciones * 209), transform.rotation);
        }
        if (ValorP209 == 4)
        {
            Instantiate(P7_M_SS, new Vector2(PosX209, myPosY + Intersecciones * 209), transform.rotation);
        }
        if (ValorP209 == 6)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX209, myPosY + Intersecciones * 209), transform.rotation);
        }
        if (ValorP209 == 8)
        {
            Instantiate(P7_M_P, new Vector2(PosX209, myPosY + Intersecciones * 209), transform.rotation);
        }
        if (ValorP209 == 10)
        {
            Instantiate(P7_Q_P, new Vector2(PosX209, myPosY + Intersecciones * 209), transform.rotation);
        }
        if (ValorP209 == 1)
        {
            Instantiate(P8_M, new Vector2(PosX209, myPosY + Intersecciones * 209), transform.rotation);
        }
        if (ValorP209 == 3)
        {
            Instantiate(P8_Q, new Vector2(PosX209, myPosY + Intersecciones * 209), transform.rotation);
        }
        if (ValorP209 == 5)
        {
            Instantiate(P8_M_SS, new Vector2(PosX209, myPosY + Intersecciones * 209), transform.rotation);
        }
        if (ValorP209 == 7)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX209, myPosY + Intersecciones * 209), transform.rotation);
        }
        if (ValorP209 == 9)
        {
            Instantiate(P8_M_P, new Vector2(PosX209, myPosY + Intersecciones * 209), transform.rotation);
        }
        if (ValorP209 == 11)
        {
            Instantiate(P8_Q_P, new Vector2(PosX209, myPosY + Intersecciones * 209), transform.rotation);
        }
        int ValorP210 = Random.Range(0, 12);
        float PosX210 = Random.Range(-2.6f, 2.6f);
        if (ValorP210 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX210, myPosY + Intersecciones * 210), transform.rotation);
        }
        if (ValorP210 == 2)
        {
            Instantiate(P7_Q, new Vector2(PosX210, myPosY + Intersecciones * 210), transform.rotation);
        }
        if (ValorP210 == 4)
        {
            Instantiate(P7_M_SS, new Vector2(PosX210, myPosY + Intersecciones * 210), transform.rotation);
        }
        if (ValorP210 == 6)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX210, myPosY + Intersecciones * 210), transform.rotation);
        }
        if (ValorP210 == 8)
        {
            Instantiate(P7_M_P, new Vector2(PosX210, myPosY + Intersecciones * 210), transform.rotation);
        }
        if (ValorP210 == 10)
        {
            Instantiate(P7_Q_P, new Vector2(PosX210, myPosY + Intersecciones * 210), transform.rotation);
        }
        if (ValorP210 == 1)
        {
            Instantiate(P8_M, new Vector2(PosX210, myPosY + Intersecciones * 210), transform.rotation);
        }
        if (ValorP210 == 3)
        {
            Instantiate(P8_Q, new Vector2(PosX210, myPosY + Intersecciones * 210), transform.rotation);
        }
        if (ValorP210 == 5)
        {
            Instantiate(P8_M_SS, new Vector2(PosX210, myPosY + Intersecciones * 210), transform.rotation);
        }
        if (ValorP210 == 7)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX210, myPosY + Intersecciones * 210), transform.rotation);
        }
        if (ValorP210 == 9)
        {
            Instantiate(P8_M_P, new Vector2(PosX210, myPosY + Intersecciones * 210), transform.rotation);
        }
        if (ValorP210 == 11)
        {
            Instantiate(P8_Q_P, new Vector2(PosX210, myPosY + Intersecciones * 210), transform.rotation);
        }
        int ValorP211 = Random.Range(0, 12);
        float PosX211 = Random.Range(-2.6f, 2.6f);
        if (ValorP211 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX211, myPosY + Intersecciones * 211), transform.rotation);
        }
        if (ValorP211 == 2)
        {
            Instantiate(P7_Q, new Vector2(PosX211, myPosY + Intersecciones * 211), transform.rotation);
        }
        if (ValorP211 == 4)
        {
            Instantiate(P7_M_SS, new Vector2(PosX211, myPosY + Intersecciones * 211), transform.rotation);
        }
        if (ValorP211 == 6)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX211, myPosY + Intersecciones * 211), transform.rotation);
        }
        if (ValorP211 == 8)
        {
            Instantiate(P7_M_P, new Vector2(PosX211, myPosY + Intersecciones * 211), transform.rotation);
        }
        if (ValorP211 == 10)
        {
            Instantiate(P7_Q_P, new Vector2(PosX211, myPosY + Intersecciones * 211), transform.rotation);
        }
        if (ValorP211 == 1)
        {
            Instantiate(P8_M, new Vector2(PosX211, myPosY + Intersecciones * 211), transform.rotation);
        }
        if (ValorP211 == 3)
        {
            Instantiate(P8_Q, new Vector2(PosX211, myPosY + Intersecciones * 211), transform.rotation);
        }
        if (ValorP211 == 5)
        {
            Instantiate(P8_M_SS, new Vector2(PosX211, myPosY + Intersecciones * 211), transform.rotation);
        }
        if (ValorP211 == 7)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX211, myPosY + Intersecciones * 211), transform.rotation);
        }
        if (ValorP211 == 9)
        {
            Instantiate(P8_M_P, new Vector2(PosX211, myPosY + Intersecciones * 211), transform.rotation);
        }
        if (ValorP211 == 11)
        {
            Instantiate(P8_Q_P, new Vector2(PosX211, myPosY + Intersecciones * 211), transform.rotation);
        }
        int ValorP212 = Random.Range(0, 12);
        float PosX212 = Random.Range(-2.6f, 2.6f);
        if (ValorP212 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX212, myPosY + Intersecciones * 212), transform.rotation);
        }
        if (ValorP212 == 2)
        {
            Instantiate(P7_Q, new Vector2(PosX212, myPosY + Intersecciones * 212), transform.rotation);
        }
        if (ValorP212 == 4)
        {
            Instantiate(P7_M_SS, new Vector2(PosX212, myPosY + Intersecciones * 212), transform.rotation);
        }
        if (ValorP212 == 6)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX212, myPosY + Intersecciones * 212), transform.rotation);
        }
        if (ValorP212 == 8)
        {
            Instantiate(P7_M_P, new Vector2(PosX212, myPosY + Intersecciones * 212), transform.rotation);
        }
        if (ValorP212 == 10)
        {
            Instantiate(P7_Q_P, new Vector2(PosX212, myPosY + Intersecciones * 212), transform.rotation);
        }
        if (ValorP212 == 1)
        {
            Instantiate(P8_M, new Vector2(PosX212, myPosY + Intersecciones * 212), transform.rotation);
        }
        if (ValorP212 == 3)
        {
            Instantiate(P8_Q, new Vector2(PosX212, myPosY + Intersecciones * 212), transform.rotation);
        }
        if (ValorP212 == 5)
        {
            Instantiate(P8_M_SS, new Vector2(PosX212, myPosY + Intersecciones * 212), transform.rotation);
        }
        if (ValorP212 == 7)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX212, myPosY + Intersecciones * 212), transform.rotation);
        }
        if (ValorP212 == 9)
        {
            Instantiate(P8_M_P, new Vector2(PosX212, myPosY + Intersecciones * 212), transform.rotation);
        }
        if (ValorP212 == 11)
        {
            Instantiate(P8_Q_P, new Vector2(PosX212, myPosY + Intersecciones * 212), transform.rotation);
        }
        int ValorP213 = Random.Range(0, 12);
        float PosX213 = Random.Range(-2.6f, 2.6f);
        if (ValorP213 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX213, myPosY + Intersecciones * 213), transform.rotation);
        }
        if (ValorP213 == 2)
        {
            Instantiate(P7_Q, new Vector2(PosX213, myPosY + Intersecciones * 213), transform.rotation);
        }
        if (ValorP213 == 4)
        {
            Instantiate(P7_M_SS, new Vector2(PosX213, myPosY + Intersecciones * 213), transform.rotation);
        }
        if (ValorP213 == 6)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX213, myPosY + Intersecciones * 213), transform.rotation);
        }
        if (ValorP213 == 8)
        {
            Instantiate(P7_M_P, new Vector2(PosX213, myPosY + Intersecciones * 213), transform.rotation);
        }
        if (ValorP213 == 10)
        {
            Instantiate(P7_Q_P, new Vector2(PosX213, myPosY + Intersecciones * 213), transform.rotation);
        }
        if (ValorP213 == 1)
        {
            Instantiate(P8_M, new Vector2(PosX213, myPosY + Intersecciones * 213), transform.rotation);
        }
        if (ValorP213 == 3)
        {
            Instantiate(P8_Q, new Vector2(PosX213, myPosY + Intersecciones * 213), transform.rotation);
        }
        if (ValorP213 == 5)
        {
            Instantiate(P8_M_SS, new Vector2(PosX213, myPosY + Intersecciones * 213), transform.rotation);
        }
        if (ValorP213 == 7)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX213, myPosY + Intersecciones * 213), transform.rotation);
        }
        if (ValorP213 == 9)
        {
            Instantiate(P8_M_P, new Vector2(PosX213, myPosY + Intersecciones * 213), transform.rotation);
        }
        if (ValorP213 == 11)
        {
            Instantiate(P8_Q_P, new Vector2(PosX213, myPosY + Intersecciones * 213), transform.rotation);
        }
        int ValorP214 = Random.Range(0, 12);
        float PosX214 = Random.Range(-2.6f, 2.6f);
        if (ValorP214 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX214, myPosY + Intersecciones * 214), transform.rotation);
        }
        if (ValorP214 == 2)
        {
            Instantiate(P7_Q, new Vector2(PosX214, myPosY + Intersecciones * 214), transform.rotation);
        }
        if (ValorP214 == 4)
        {
            Instantiate(P7_M_SS, new Vector2(PosX214, myPosY + Intersecciones * 214), transform.rotation);
        }
        if (ValorP214 == 6)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX214, myPosY + Intersecciones * 214), transform.rotation);
        }
        if (ValorP214 == 8)
        {
            Instantiate(P7_M_P, new Vector2(PosX214, myPosY + Intersecciones * 214), transform.rotation);
        }
        if (ValorP214 == 10)
        {
            Instantiate(P7_Q_P, new Vector2(PosX214, myPosY + Intersecciones * 214), transform.rotation);
        }
        if (ValorP214 == 1)
        {
            Instantiate(P8_M, new Vector2(PosX214, myPosY + Intersecciones * 214), transform.rotation);
        }
        if (ValorP214 == 3)
        {
            Instantiate(P8_Q, new Vector2(PosX214, myPosY + Intersecciones * 214), transform.rotation);
        }
        if (ValorP214 == 5)
        {
            Instantiate(P8_M_SS, new Vector2(PosX214, myPosY + Intersecciones * 214), transform.rotation);
        }
        if (ValorP214 == 7)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX214, myPosY + Intersecciones * 214), transform.rotation);
        }
        if (ValorP214 == 9)
        {
            Instantiate(P8_M_P, new Vector2(PosX214, myPosY + Intersecciones * 214), transform.rotation);
        }
        if (ValorP214 == 11)
        {
            Instantiate(P8_Q_P, new Vector2(PosX214, myPosY + Intersecciones * 214), transform.rotation);
        }
        int ValorP215 = Random.Range(0, 12);
        float PosX215 = Random.Range(-2.6f, 2.6f);
        if (ValorP215 == 0)
        {
            Instantiate(P7_M, new Vector2(PosX215, myPosY + Intersecciones * 215), transform.rotation);
        }
        if (ValorP215 == 2)
        {
            Instantiate(P7_Q, new Vector2(PosX215, myPosY + Intersecciones * 215), transform.rotation);
        }
        if (ValorP215 == 4)
        {
            Instantiate(P7_M_SS, new Vector2(PosX215, myPosY + Intersecciones * 215), transform.rotation);
        }
        if (ValorP215 == 6)
        {
            Instantiate(P7_Q_SS, new Vector2(PosX215, myPosY + Intersecciones * 215), transform.rotation);
        }
        if (ValorP215 == 8)
        {
            Instantiate(P7_M_P, new Vector2(PosX215, myPosY + Intersecciones * 215), transform.rotation);
        }
        if (ValorP215 == 10)
        {
            Instantiate(P7_Q_P, new Vector2(PosX215, myPosY + Intersecciones * 215), transform.rotation);
        }
        if (ValorP215 == 1)
        {
            Instantiate(P8_M, new Vector2(PosX215, myPosY + Intersecciones * 215), transform.rotation);
        }
        if (ValorP215 == 3)
        {
            Instantiate(P8_Q, new Vector2(PosX215, myPosY + Intersecciones * 215), transform.rotation);
        }
        if (ValorP215 == 5)
        {
            Instantiate(P8_M_SS, new Vector2(PosX215, myPosY + Intersecciones * 215), transform.rotation);
        }
        if (ValorP215 == 7)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX215, myPosY + Intersecciones * 215), transform.rotation);
        }
        if (ValorP215 == 9)
        {
            Instantiate(P8_M_P, new Vector2(PosX215, myPosY + Intersecciones * 215), transform.rotation);
        }
        if (ValorP215 == 11)
        {
            Instantiate(P8_Q_P, new Vector2(PosX215, myPosY + Intersecciones * 215), transform.rotation);
        }
        int ValorP216 = Random.Range(0, 6);
        float PosX216 = Random.Range(-2.6f, 2.6f);
        if (ValorP216 == 0)
        {
            Instantiate(P8_M, new Vector2(PosX216, myPosY + Intersecciones * 216), transform.rotation);
        }
        if (ValorP216 == 1)
        {
            Instantiate(P8_Q, new Vector2(PosX216, myPosY + Intersecciones * 216), transform.rotation);
        }
        if (ValorP216 == 2)
        {
            Instantiate(P8_M_SS, new Vector2(PosX216, myPosY + Intersecciones * 216), transform.rotation);
        }
        if (ValorP216 == 3)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX216, myPosY + Intersecciones * 216), transform.rotation);
        }
        if (ValorP216 == 4)
        {
            Instantiate(P8_M_P, new Vector2(PosX216, myPosY + Intersecciones * 216), transform.rotation);
        }
        if (ValorP216 == 5)
        {
            Instantiate(P8_Q_P, new Vector2(PosX216, myPosY + Intersecciones * 216), transform.rotation);
        }
        int ValorP217 = Random.Range(0, 6);
        float PosX217 = Random.Range(-2.6f, 2.6f);
        if (ValorP217 == 0)
        {
            Instantiate(P8_M, new Vector2(PosX217, myPosY + Intersecciones * 217), transform.rotation);
        }
        if (ValorP217 == 1)
        {
            Instantiate(P8_Q, new Vector2(PosX217, myPosY + Intersecciones * 217), transform.rotation);
        }
        if (ValorP217 == 2)
        {
            Instantiate(P8_M_SS, new Vector2(PosX217, myPosY + Intersecciones * 217), transform.rotation);
        }
        if (ValorP217 == 3)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX217, myPosY + Intersecciones * 217), transform.rotation);
        }
        if (ValorP217 == 4)
        {
            Instantiate(P8_M_P, new Vector2(PosX217, myPosY + Intersecciones * 217), transform.rotation);
        }
        if (ValorP217 == 5)
        {
            Instantiate(P8_Q_P, new Vector2(PosX217, myPosY + Intersecciones * 217), transform.rotation);
        }
        int ValorP218 = Random.Range(0, 6);
        float PosX218 = Random.Range(-2.6f, 2.6f);
        if (ValorP218 == 0)
        {
            Instantiate(P8_M, new Vector2(PosX218, myPosY + Intersecciones * 218), transform.rotation);
        }
        if (ValorP218 == 1)
        {
            Instantiate(P8_Q, new Vector2(PosX218, myPosY + Intersecciones * 218), transform.rotation);
        }
        if (ValorP218 == 2)
        {
            Instantiate(P8_M_SS, new Vector2(PosX218, myPosY + Intersecciones * 218), transform.rotation);
        }
        if (ValorP218 == 3)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX218, myPosY + Intersecciones * 218), transform.rotation);
        }
        if (ValorP218 == 4)
        {
            Instantiate(P8_M_P, new Vector2(PosX218, myPosY + Intersecciones * 218), transform.rotation);
        }
        if (ValorP218 == 5)
        {
            Instantiate(P8_Q_P, new Vector2(PosX218, myPosY + Intersecciones * 218), transform.rotation);
        }
        int ValorP219 = Random.Range(0, 6);
        float PosX219 = Random.Range(-2.6f, 2.6f);
        if (ValorP219 == 0)
        {
            Instantiate(P8_M, new Vector2(PosX219, myPosY + Intersecciones * 219), transform.rotation);
        }
        if (ValorP219 == 1)
        {
            Instantiate(P8_Q, new Vector2(PosX219, myPosY + Intersecciones * 219), transform.rotation);
        }
        if (ValorP219 == 2)
        {
            Instantiate(P8_M_SS, new Vector2(PosX219, myPosY + Intersecciones * 219), transform.rotation);
        }
        if (ValorP219 == 3)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX219, myPosY + Intersecciones * 219), transform.rotation);
        }
        if (ValorP219 == 4)
        {
            Instantiate(P8_M_P, new Vector2(PosX219, myPosY + Intersecciones * 219), transform.rotation);
        }
        if (ValorP219 == 5)
        {
            Instantiate(P8_Q_P, new Vector2(PosX219, myPosY + Intersecciones * 219), transform.rotation);
        }
        int ValorP220 = Random.Range(0, 6);
        float PosX220 = Random.Range(-2.6f, 2.6f);
        if (ValorP220 == 0)
        {
            Instantiate(P8_M, new Vector2(PosX220, myPosY + Intersecciones * 220), transform.rotation);
        }
        if (ValorP220 == 1)
        {
            Instantiate(P8_Q, new Vector2(PosX220, myPosY + Intersecciones * 220), transform.rotation);
        }
        if (ValorP220 == 2)
        {
            Instantiate(P8_M_SS, new Vector2(PosX220, myPosY + Intersecciones * 220), transform.rotation);
        }
        if (ValorP220 == 3)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX220, myPosY + Intersecciones * 220), transform.rotation);
        }
        if (ValorP220 == 4)
        {
            Instantiate(P8_M_P, new Vector2(PosX220, myPosY + Intersecciones * 220), transform.rotation);
        }
        if (ValorP220 == 5)
        {
            Instantiate(P8_Q_P, new Vector2(PosX220, myPosY + Intersecciones * 220), transform.rotation);
        }
        int ValorP221 = Random.Range(0, 6);
        float PosX221 = Random.Range(-2.6f, 2.6f);
        if (ValorP221 == 0)
        {
            Instantiate(P8_M, new Vector2(PosX221, myPosY + Intersecciones * 221), transform.rotation);
        }
        if (ValorP221 == 1)
        {
            Instantiate(P8_Q, new Vector2(PosX221, myPosY + Intersecciones * 221), transform.rotation);
        }
        if (ValorP221 == 2)
        {
            Instantiate(P8_M_SS, new Vector2(PosX221, myPosY + Intersecciones * 221), transform.rotation);
        }
        if (ValorP221 == 3)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX221, myPosY + Intersecciones * 221), transform.rotation);
        }
        if (ValorP221 == 4)
        {
            Instantiate(P8_M_P, new Vector2(PosX221, myPosY + Intersecciones * 221), transform.rotation);
        }
        if (ValorP221 == 5)
        {
            Instantiate(P8_Q_P, new Vector2(PosX221, myPosY + Intersecciones * 221), transform.rotation);
        }
        int ValorP222 = Random.Range(0, 6);
        float PosX222 = Random.Range(-2.6f, 2.6f);
        if (ValorP222 == 0)
        {
            Instantiate(P8_M, new Vector2(PosX222, myPosY + Intersecciones * 222), transform.rotation);
        }
        if (ValorP222 == 1)
        {
            Instantiate(P8_Q, new Vector2(PosX222, myPosY + Intersecciones * 222), transform.rotation);
        }
        if (ValorP222 == 2)
        {
            Instantiate(P8_M_SS, new Vector2(PosX222, myPosY + Intersecciones * 222), transform.rotation);
        }
        if (ValorP222 == 3)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX222, myPosY + Intersecciones * 222), transform.rotation);
        }
        if (ValorP222 == 4)
        {
            Instantiate(P8_M_P, new Vector2(PosX222, myPosY + Intersecciones * 222), transform.rotation);
        }
        if (ValorP222 == 5)
        {
            Instantiate(P8_Q_P, new Vector2(PosX222, myPosY + Intersecciones * 222), transform.rotation);
        }
        int ValorP223 = Random.Range(0, 6);
        float PosX223 = Random.Range(-2.6f, 2.6f);
        if (ValorP223 == 0)
        {
            Instantiate(P8_M, new Vector2(PosX223, myPosY + Intersecciones * 223), transform.rotation);
        }
        if (ValorP223 == 1)
        {
            Instantiate(P8_Q, new Vector2(PosX223, myPosY + Intersecciones * 223), transform.rotation);
        }
        if (ValorP223 == 2)
        {
            Instantiate(P8_M_SS, new Vector2(PosX223, myPosY + Intersecciones * 223), transform.rotation);
        }
        if (ValorP223 == 3)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX223, myPosY + Intersecciones * 223), transform.rotation);
        }
        if (ValorP223 == 4)
        {
            Instantiate(P8_M_P, new Vector2(PosX223, myPosY + Intersecciones * 223), transform.rotation);
        }
        if (ValorP223 == 5)
        {
            Instantiate(P8_Q_P, new Vector2(PosX223, myPosY + Intersecciones * 223), transform.rotation);
        }
        int ValorP224 = Random.Range(0, 6);
        float PosX224 = Random.Range(-2.6f, 2.6f);
        if (ValorP224 == 0)
        {
            Instantiate(P8_M, new Vector2(PosX224, myPosY + Intersecciones * 224), transform.rotation);
        }
        if (ValorP224 == 1)
        {
            Instantiate(P8_Q, new Vector2(PosX224, myPosY + Intersecciones * 224), transform.rotation);
        }
        if (ValorP224 == 2)
        {
            Instantiate(P8_M_SS, new Vector2(PosX224, myPosY + Intersecciones * 224), transform.rotation);
        }
        if (ValorP224 == 3)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX224, myPosY + Intersecciones * 224), transform.rotation);
        }
        if (ValorP224 == 4)
        {
            Instantiate(P8_M_P, new Vector2(PosX224, myPosY + Intersecciones * 224), transform.rotation);
        }
        if (ValorP224 == 5)
        {
            Instantiate(P8_Q_P, new Vector2(PosX224, myPosY + Intersecciones * 224), transform.rotation);
        }
        int ValorP225 = Random.Range(0, 6);
        float PosX225 = Random.Range(-2.6f, 2.6f);
        if (ValorP225 == 0)
        {
            Instantiate(P8_M, new Vector2(PosX225, myPosY + Intersecciones * 225), transform.rotation);
        }
        if (ValorP225 == 1)
        {
            Instantiate(P8_Q, new Vector2(PosX225, myPosY + Intersecciones * 225), transform.rotation);
        }
        if (ValorP225 == 2)
        {
            Instantiate(P8_M_SS, new Vector2(PosX225, myPosY + Intersecciones * 225), transform.rotation);
        }
        if (ValorP225 == 3)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX225, myPosY + Intersecciones * 225), transform.rotation);
        }
        if (ValorP225 == 4)
        {
            Instantiate(P8_M_P, new Vector2(PosX225, myPosY + Intersecciones * 225), transform.rotation);
        }
        if (ValorP225 == 5)
        {
            Instantiate(P8_Q_P, new Vector2(PosX225, myPosY + Intersecciones * 225), transform.rotation);
        }
        int ValorP226 = Random.Range(0, 6);
        float PosX226 = Random.Range(-2.6f, 2.6f);
        if (ValorP226 == 0)
        {
            Instantiate(P8_M, new Vector2(PosX226, myPosY + Intersecciones * 226), transform.rotation);
        }
        if (ValorP226 == 1)
        {
            Instantiate(P8_Q, new Vector2(PosX226, myPosY + Intersecciones * 226), transform.rotation);
        }
        if (ValorP226 == 2)
        {
            Instantiate(P8_M_SS, new Vector2(PosX226, myPosY + Intersecciones * 226), transform.rotation);
        }
        if (ValorP226 == 3)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX226, myPosY + Intersecciones * 226), transform.rotation);
        }
        if (ValorP226 == 4)
        {
            Instantiate(P8_M_P, new Vector2(PosX226, myPosY + Intersecciones * 226), transform.rotation);
        }
        if (ValorP226 == 5)
        {
            Instantiate(P8_Q_P, new Vector2(PosX226, myPosY + Intersecciones * 226), transform.rotation);
        }
        int ValorP227 = Random.Range(0, 6);
        float PosX227 = Random.Range(-2.6f, 2.6f);
        if (ValorP227 == 0)
        {
            Instantiate(P8_M, new Vector2(PosX227, myPosY + Intersecciones * 227), transform.rotation);
        }
        if (ValorP227 == 1)
        {
            Instantiate(P8_Q, new Vector2(PosX227, myPosY + Intersecciones * 227), transform.rotation);
        }
        if (ValorP227 == 2)
        {
            Instantiate(P8_M_SS, new Vector2(PosX227, myPosY + Intersecciones * 227), transform.rotation);
        }
        if (ValorP227 == 3)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX227, myPosY + Intersecciones * 227), transform.rotation);
        }
        if (ValorP227 == 4)
        {
            Instantiate(P8_M_P, new Vector2(PosX227, myPosY + Intersecciones * 227), transform.rotation);
        }
        if (ValorP227 == 5)
        {
            Instantiate(P8_Q_P, new Vector2(PosX227, myPosY + Intersecciones * 227), transform.rotation);
        }
        int ValorP228 = Random.Range(0, 6);
        float PosX228 = Random.Range(-2.6f, 2.6f);
        if (ValorP228 == 0)
        {
            Instantiate(P8_M, new Vector2(PosX228, myPosY + Intersecciones * 228), transform.rotation);
        }
        if (ValorP228 == 1)
        {
            Instantiate(P8_Q, new Vector2(PosX228, myPosY + Intersecciones * 228), transform.rotation);
        }
        if (ValorP228 == 2)
        {
            Instantiate(P8_M_SS, new Vector2(PosX228, myPosY + Intersecciones * 228), transform.rotation);
        }
        if (ValorP228 == 3)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX228, myPosY + Intersecciones * 228), transform.rotation);
        }
        if (ValorP228 == 4)
        {
            Instantiate(P8_M_P, new Vector2(PosX228, myPosY + Intersecciones * 228), transform.rotation);
        }
        if (ValorP228 == 5)
        {
            Instantiate(P8_Q_P, new Vector2(PosX228, myPosY + Intersecciones * 228), transform.rotation);
        }
        int ValorP229 = Random.Range(0, 6);
        float PosX229 = Random.Range(-2.6f, 2.6f);
        if (ValorP229 == 0)
        {
            Instantiate(P8_M, new Vector2(PosX229, myPosY + Intersecciones * 229), transform.rotation);
        }
        if (ValorP229 == 1)
        {
            Instantiate(P8_Q, new Vector2(PosX229, myPosY + Intersecciones * 229), transform.rotation);
        }
        if (ValorP229 == 2)
        {
            Instantiate(P8_M_SS, new Vector2(PosX229, myPosY + Intersecciones * 229), transform.rotation);
        }
        if (ValorP229 == 3)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX229, myPosY + Intersecciones * 229), transform.rotation);
        }
        if (ValorP229 == 4)
        {
            Instantiate(P8_M_P, new Vector2(PosX229, myPosY + Intersecciones * 229), transform.rotation);
        }
        if (ValorP229 == 5)
        {
            Instantiate(P8_Q_P, new Vector2(PosX229, myPosY + Intersecciones * 229), transform.rotation);
        }
        int ValorP230 = Random.Range(0, 6);
        float PosX230 = Random.Range(-2.6f, 2.6f);
        if (ValorP230 == 0)
        {
            Instantiate(P8_M, new Vector2(PosX230, myPosY + Intersecciones * 230), transform.rotation);
        }
        if (ValorP230 == 1)
        {
            Instantiate(P8_Q, new Vector2(PosX230, myPosY + Intersecciones * 230), transform.rotation);
        }
        if (ValorP230 == 2)
        {
            Instantiate(P8_M_SS, new Vector2(PosX230, myPosY + Intersecciones * 230), transform.rotation);
        }
        if (ValorP230 == 3)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX230, myPosY + Intersecciones * 230), transform.rotation);
        }
        if (ValorP230 == 4)
        {
            Instantiate(P8_M_P, new Vector2(PosX230, myPosY + Intersecciones * 230), transform.rotation);
        }
        if (ValorP230 == 5)
        {
            Instantiate(P8_Q_P, new Vector2(PosX230, myPosY + Intersecciones * 230), transform.rotation);
        }
        int ValorP231 = Random.Range(0, 12);
        float PosX231 = Random.Range(-2.6f, 2.6f);
        if (ValorP231 == 0)
        {
            Instantiate(P8_M, new Vector2(PosX231, myPosY + Intersecciones * 231), transform.rotation);
        }
        if (ValorP231 == 2)
        {
            Instantiate(P8_Q, new Vector2(PosX231, myPosY + Intersecciones * 231), transform.rotation);
        }
        if (ValorP231 == 4)
        {
            Instantiate(P8_M_SS, new Vector2(PosX231, myPosY + Intersecciones * 231), transform.rotation);
        }
        if (ValorP231 == 6)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX231, myPosY + Intersecciones * 231), transform.rotation);
        }
        if (ValorP231 == 8)
        {
            Instantiate(P8_M_P, new Vector2(PosX231, myPosY + Intersecciones * 231), transform.rotation);
        }
        if (ValorP231 == 10)
        {
            Instantiate(P8_Q_P, new Vector2(PosX231, myPosY + Intersecciones * 231), transform.rotation);
        }
        if (ValorP231 == 1)
        {
            Instantiate(P9_M, new Vector2(PosX231, myPosY + Intersecciones * 231), transform.rotation);
        }
        if (ValorP231 == 3)
        {
            Instantiate(P9_Q, new Vector2(PosX231, myPosY + Intersecciones * 231), transform.rotation);
        }
        if (ValorP231 == 5)
        {
            Instantiate(P9_M_SS, new Vector2(PosX231, myPosY + Intersecciones * 231), transform.rotation);
        }
        if (ValorP231 == 7)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX231, myPosY + Intersecciones * 231), transform.rotation);
        }
        if (ValorP231 == 9)
        {
            Instantiate(P9_M_P, new Vector2(PosX231, myPosY + Intersecciones * 231), transform.rotation);
        }
        if (ValorP231 == 11)
        {
            Instantiate(P9_Q_P, new Vector2(PosX231, myPosY + Intersecciones * 231), transform.rotation);
        }
        int ValorP232 = Random.Range(0, 12);
        float PosX232 = Random.Range(-2.6f, 2.6f);
        if (ValorP232 == 0)
        {
            Instantiate(P8_M, new Vector2(PosX232, myPosY + Intersecciones * 232), transform.rotation);
        }
        if (ValorP232 == 2)
        {
            Instantiate(P8_Q, new Vector2(PosX232, myPosY + Intersecciones * 232), transform.rotation);
        }
        if (ValorP232 == 4)
        {
            Instantiate(P8_M_SS, new Vector2(PosX232, myPosY + Intersecciones * 232), transform.rotation);
        }
        if (ValorP232 == 6)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX232, myPosY + Intersecciones * 232), transform.rotation);
        }
        if (ValorP232 == 8)
        {
            Instantiate(P8_M_P, new Vector2(PosX232, myPosY + Intersecciones * 232), transform.rotation);
        }
        if (ValorP232 == 10)
        {
            Instantiate(P8_Q_P, new Vector2(PosX232, myPosY + Intersecciones * 232), transform.rotation);
        }
        if (ValorP232 == 1)
        {
            Instantiate(P9_M, new Vector2(PosX232, myPosY + Intersecciones * 232), transform.rotation);
        }
        if (ValorP232 == 3)
        {
            Instantiate(P9_Q, new Vector2(PosX232, myPosY + Intersecciones * 232), transform.rotation);
        }
        if (ValorP232 == 5)
        {
            Instantiate(P9_M_SS, new Vector2(PosX232, myPosY + Intersecciones * 232), transform.rotation);
        }
        if (ValorP232 == 7)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX232, myPosY + Intersecciones * 232), transform.rotation);
        }
        if (ValorP232 == 9)
        {
            Instantiate(P9_M_P, new Vector2(PosX232, myPosY + Intersecciones * 232), transform.rotation);
        }
        if (ValorP232 == 11)
        {
            Instantiate(P9_Q_P, new Vector2(PosX232, myPosY + Intersecciones * 232), transform.rotation);
        }
        int ValorP233 = Random.Range(0, 12);
        float PosX233 = Random.Range(-2.6f, 2.6f);
        if (ValorP233 == 0)
        {
            Instantiate(P8_M, new Vector2(PosX233, myPosY + Intersecciones * 233), transform.rotation);
        }
        if (ValorP233 == 2)
        {
            Instantiate(P8_Q, new Vector2(PosX233, myPosY + Intersecciones * 233), transform.rotation);
        }
        if (ValorP233 == 4)
        {
            Instantiate(P8_M_SS, new Vector2(PosX233, myPosY + Intersecciones * 233), transform.rotation);
        }
        if (ValorP233 == 6)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX233, myPosY + Intersecciones * 233), transform.rotation);
        }
        if (ValorP233 == 8)
        {
            Instantiate(P8_M_P, new Vector2(PosX233, myPosY + Intersecciones * 233), transform.rotation);
        }
        if (ValorP233 == 10)
        {
            Instantiate(P8_Q_P, new Vector2(PosX233, myPosY + Intersecciones * 233), transform.rotation);
        }
        if (ValorP233 == 1)
        {
            Instantiate(P9_M, new Vector2(PosX233, myPosY + Intersecciones * 233), transform.rotation);
        }
        if (ValorP233 == 3)
        {
            Instantiate(P9_Q, new Vector2(PosX233, myPosY + Intersecciones * 233), transform.rotation);
        }
        if (ValorP233 == 5)
        {
            Instantiate(P9_M_SS, new Vector2(PosX233, myPosY + Intersecciones * 233), transform.rotation);
        }
        if (ValorP233 == 7)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX233, myPosY + Intersecciones * 233), transform.rotation);
        }
        if (ValorP233 == 9)
        {
            Instantiate(P9_M_P, new Vector2(PosX233, myPosY + Intersecciones * 233), transform.rotation);
        }
        if (ValorP233 == 11)
        {
            Instantiate(P9_Q_P, new Vector2(PosX233, myPosY + Intersecciones * 233), transform.rotation);
        }
        int ValorP234 = Random.Range(0, 12);
        float PosX234 = Random.Range(-2.6f, 2.6f);
        if (ValorP234 == 0)
        {
            Instantiate(P8_M, new Vector2(PosX234, myPosY + Intersecciones * 234), transform.rotation);
        }
        if (ValorP234 == 2)
        {
            Instantiate(P8_Q, new Vector2(PosX234, myPosY + Intersecciones * 234), transform.rotation);
        }
        if (ValorP234 == 4)
        {
            Instantiate(P8_M_SS, new Vector2(PosX234, myPosY + Intersecciones * 234), transform.rotation);
        }
        if (ValorP234 == 6)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX234, myPosY + Intersecciones * 234), transform.rotation);
        }
        if (ValorP234 == 8)
        {
            Instantiate(P8_M_P, new Vector2(PosX234, myPosY + Intersecciones * 234), transform.rotation);
        }
        if (ValorP234 == 10)
        {
            Instantiate(P8_Q_P, new Vector2(PosX234, myPosY + Intersecciones * 234), transform.rotation);
        }
        if (ValorP234 == 1)
        {
            Instantiate(P9_M, new Vector2(PosX234, myPosY + Intersecciones * 234), transform.rotation);
        }
        if (ValorP234 == 3)
        {
            Instantiate(P9_Q, new Vector2(PosX234, myPosY + Intersecciones * 234), transform.rotation);
        }
        if (ValorP234 == 5)
        {
            Instantiate(P9_M_SS, new Vector2(PosX234, myPosY + Intersecciones * 234), transform.rotation);
        }
        if (ValorP234 == 7)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX234, myPosY + Intersecciones * 234), transform.rotation);
        }
        if (ValorP234 == 9)
        {
            Instantiate(P9_M_P, new Vector2(PosX234, myPosY + Intersecciones * 234), transform.rotation);
        }
        if (ValorP234 == 11)
        {
            Instantiate(P9_Q_P, new Vector2(PosX234, myPosY + Intersecciones * 234), transform.rotation);
        }
        int ValorP235 = Random.Range(0, 12);
        float PosX235 = Random.Range(-2.6f, 2.6f);
        if (ValorP235 == 0)
        {
            Instantiate(P8_M, new Vector2(PosX235, myPosY + Intersecciones * 235), transform.rotation);
        }
        if (ValorP235 == 2)
        {
            Instantiate(P8_Q, new Vector2(PosX235, myPosY + Intersecciones * 235), transform.rotation);
        }
        if (ValorP235 == 4)
        {
            Instantiate(P8_M_SS, new Vector2(PosX235, myPosY + Intersecciones * 235), transform.rotation);
        }
        if (ValorP235 == 6)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX235, myPosY + Intersecciones * 235), transform.rotation);
        }
        if (ValorP235 == 8)
        {
            Instantiate(P8_M_P, new Vector2(PosX235, myPosY + Intersecciones * 235), transform.rotation);
        }
        if (ValorP235 == 10)
        {
            Instantiate(P8_Q_P, new Vector2(PosX235, myPosY + Intersecciones * 235), transform.rotation);
        }
        if (ValorP235 == 1)
        {
            Instantiate(P9_M, new Vector2(PosX235, myPosY + Intersecciones * 235), transform.rotation);
        }
        if (ValorP235 == 3)
        {
            Instantiate(P9_Q, new Vector2(PosX235, myPosY + Intersecciones * 235), transform.rotation);
        }
        if (ValorP235 == 5)
        {
            Instantiate(P9_M_SS, new Vector2(PosX235, myPosY + Intersecciones * 235), transform.rotation);
        }
        if (ValorP235 == 7)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX235, myPosY + Intersecciones * 235), transform.rotation);
        }
        if (ValorP235 == 9)
        {
            Instantiate(P9_M_P, new Vector2(PosX235, myPosY + Intersecciones * 235), transform.rotation);
        }
        if (ValorP235 == 11)
        {
            Instantiate(P9_Q_P, new Vector2(PosX235, myPosY + Intersecciones * 235), transform.rotation);
        }
        int ValorP236 = Random.Range(0, 12);
        float PosX236 = Random.Range(-2.6f, 2.6f);
        if (ValorP236 == 0)
        {
            Instantiate(P8_M, new Vector2(PosX236, myPosY + Intersecciones * 236), transform.rotation);
        }
        if (ValorP236 == 2)
        {
            Instantiate(P8_Q, new Vector2(PosX236, myPosY + Intersecciones * 236), transform.rotation);
        }
        if (ValorP236 == 4)
        {
            Instantiate(P8_M_SS, new Vector2(PosX236, myPosY + Intersecciones * 236), transform.rotation);
        }
        if (ValorP236 == 6)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX236, myPosY + Intersecciones * 236), transform.rotation);
        }
        if (ValorP236 == 8)
        {
            Instantiate(P8_M_P, new Vector2(PosX236, myPosY + Intersecciones * 236), transform.rotation);
        }
        if (ValorP236 == 10)
        {
            Instantiate(P8_Q_P, new Vector2(PosX236, myPosY + Intersecciones * 236), transform.rotation);
        }
        if (ValorP236 == 1)
        {
            Instantiate(P9_M, new Vector2(PosX236, myPosY + Intersecciones * 236), transform.rotation);
        }
        if (ValorP236 == 3)
        {
            Instantiate(P9_Q, new Vector2(PosX236, myPosY + Intersecciones * 236), transform.rotation);
        }
        if (ValorP236 == 5)
        {
            Instantiate(P9_M_SS, new Vector2(PosX236, myPosY + Intersecciones * 236), transform.rotation);
        }
        if (ValorP236 == 7)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX236, myPosY + Intersecciones * 236), transform.rotation);
        }
        if (ValorP236 == 9)
        {
            Instantiate(P9_M_P, new Vector2(PosX236, myPosY + Intersecciones * 236), transform.rotation);
        }
        if (ValorP236 == 11)
        {
            Instantiate(P9_Q_P, new Vector2(PosX236, myPosY + Intersecciones * 236), transform.rotation);
        }
        int ValorP237 = Random.Range(0, 12);
        float PosX237 = Random.Range(-2.6f, 2.6f);
        if (ValorP237 == 0)
        {
            Instantiate(P8_M, new Vector2(PosX237, myPosY + Intersecciones * 237), transform.rotation);
        }
        if (ValorP237 == 2)
        {
            Instantiate(P8_Q, new Vector2(PosX237, myPosY + Intersecciones * 237), transform.rotation);
        }
        if (ValorP237 == 4)
        {
            Instantiate(P8_M_SS, new Vector2(PosX237, myPosY + Intersecciones * 237), transform.rotation);
        }
        if (ValorP237 == 6)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX237, myPosY + Intersecciones * 237), transform.rotation);
        }
        if (ValorP237 == 8)
        {
            Instantiate(P8_M_P, new Vector2(PosX237, myPosY + Intersecciones * 237), transform.rotation);
        }
        if (ValorP237 == 10)
        {
            Instantiate(P8_Q_P, new Vector2(PosX237, myPosY + Intersecciones * 237), transform.rotation);
        }
        if (ValorP237 == 1)
        {
            Instantiate(P9_M, new Vector2(PosX237, myPosY + Intersecciones * 237), transform.rotation);
        }
        if (ValorP237 == 3)
        {
            Instantiate(P9_Q, new Vector2(PosX237, myPosY + Intersecciones * 237), transform.rotation);
        }
        if (ValorP237 == 5)
        {
            Instantiate(P9_M_SS, new Vector2(PosX237, myPosY + Intersecciones * 237), transform.rotation);
        }
        if (ValorP237 == 7)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX237, myPosY + Intersecciones * 237), transform.rotation);
        }
        if (ValorP237 == 9)
        {
            Instantiate(P9_M_P, new Vector2(PosX237, myPosY + Intersecciones * 237), transform.rotation);
        }
        if (ValorP237 == 11)
        {
            Instantiate(P9_Q_P, new Vector2(PosX237, myPosY + Intersecciones * 237), transform.rotation);
        }
        int ValorP238 = Random.Range(0, 12);
        float PosX238 = Random.Range(-2.6f, 2.6f);
        if (ValorP238 == 0)
        {
            Instantiate(P8_M, new Vector2(PosX238, myPosY + Intersecciones * 238), transform.rotation);
        }
        if (ValorP238 == 2)
        {
            Instantiate(P8_Q, new Vector2(PosX238, myPosY + Intersecciones * 238), transform.rotation);
        }
        if (ValorP238 == 4)
        {
            Instantiate(P8_M_SS, new Vector2(PosX238, myPosY + Intersecciones * 238), transform.rotation);
        }
        if (ValorP238 == 6)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX238, myPosY + Intersecciones * 238), transform.rotation);
        }
        if (ValorP238 == 8)
        {
            Instantiate(P8_M_P, new Vector2(PosX238, myPosY + Intersecciones * 238), transform.rotation);
        }
        if (ValorP238 == 10)
        {
            Instantiate(P8_Q_P, new Vector2(PosX238, myPosY + Intersecciones * 238), transform.rotation);
        }
        if (ValorP238 == 1)
        {
            Instantiate(P9_M, new Vector2(PosX238, myPosY + Intersecciones * 238), transform.rotation);
        }
        if (ValorP238 == 3)
        {
            Instantiate(P9_Q, new Vector2(PosX238, myPosY + Intersecciones * 238), transform.rotation);
        }
        if (ValorP238 == 5)
        {
            Instantiate(P9_M_SS, new Vector2(PosX238, myPosY + Intersecciones * 238), transform.rotation);
        }
        if (ValorP238 == 7)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX238, myPosY + Intersecciones * 238), transform.rotation);
        }
        if (ValorP238 == 9)
        {
            Instantiate(P9_M_P, new Vector2(PosX238, myPosY + Intersecciones * 238), transform.rotation);
        }
        if (ValorP238 == 11)
        {
            Instantiate(P9_Q_P, new Vector2(PosX238, myPosY + Intersecciones * 238), transform.rotation);
        }
        int ValorP239 = Random.Range(0, 12);
        float PosX239 = Random.Range(-2.6f, 2.6f);
        if (ValorP239 == 0)
        {
            Instantiate(P8_M, new Vector2(PosX239, myPosY + Intersecciones * 239), transform.rotation);
        }
        if (ValorP239 == 2)
        {
            Instantiate(P8_Q, new Vector2(PosX239, myPosY + Intersecciones * 239), transform.rotation);
        }
        if (ValorP239 == 4)
        {
            Instantiate(P8_M_SS, new Vector2(PosX239, myPosY + Intersecciones * 239), transform.rotation);
        }
        if (ValorP239 == 6)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX239, myPosY + Intersecciones * 239), transform.rotation);
        }
        if (ValorP239 == 8)
        {
            Instantiate(P8_M_P, new Vector2(PosX239, myPosY + Intersecciones * 239), transform.rotation);
        }
        if (ValorP239 == 10)
        {
            Instantiate(P8_Q_P, new Vector2(PosX239, myPosY + Intersecciones * 239), transform.rotation);
        }
        if (ValorP239 == 1)
        {
            Instantiate(P9_M, new Vector2(PosX239, myPosY + Intersecciones * 239), transform.rotation);
        }
        if (ValorP239 == 3)
        {
            Instantiate(P9_Q, new Vector2(PosX239, myPosY + Intersecciones * 239), transform.rotation);
        }
        if (ValorP239 == 5)
        {
            Instantiate(P9_M_SS, new Vector2(PosX239, myPosY + Intersecciones * 239), transform.rotation);
        }
        if (ValorP239 == 7)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX239, myPosY + Intersecciones * 239), transform.rotation);
        }
        if (ValorP239 == 9)
        {
            Instantiate(P9_M_P, new Vector2(PosX239, myPosY + Intersecciones * 239), transform.rotation);
        }
        if (ValorP239 == 11)
        {
            Instantiate(P9_Q_P, new Vector2(PosX239, myPosY + Intersecciones * 239), transform.rotation);
        }
        int ValorP240 = Random.Range(0, 12);
        float PosX240 = Random.Range(-2.6f, 2.6f);
        if (ValorP240 == 0)
        {
            Instantiate(P8_M, new Vector2(PosX240, myPosY + Intersecciones * 240), transform.rotation);
        }
        if (ValorP240 == 2)
        {
            Instantiate(P8_Q, new Vector2(PosX240, myPosY + Intersecciones * 240), transform.rotation);
        }
        if (ValorP240 == 4)
        {
            Instantiate(P8_M_SS, new Vector2(PosX240, myPosY + Intersecciones * 240), transform.rotation);
        }
        if (ValorP240 == 6)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX240, myPosY + Intersecciones * 240), transform.rotation);
        }
        if (ValorP240 == 8)
        {
            Instantiate(P8_M_P, new Vector2(PosX240, myPosY + Intersecciones * 240), transform.rotation);
        }
        if (ValorP240 == 10)
        {
            Instantiate(P8_Q_P, new Vector2(PosX240, myPosY + Intersecciones * 240), transform.rotation);
        }
        if (ValorP240 == 1)
        {
            Instantiate(P9_M, new Vector2(PosX240, myPosY + Intersecciones * 240), transform.rotation);
        }
        if (ValorP240 == 3)
        {
            Instantiate(P9_Q, new Vector2(PosX240, myPosY + Intersecciones * 240), transform.rotation);
        }
        if (ValorP240 == 5)
        {
            Instantiate(P9_M_SS, new Vector2(PosX240, myPosY + Intersecciones * 240), transform.rotation);
        }
        if (ValorP240 == 7)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX240, myPosY + Intersecciones * 240), transform.rotation);
        }
        if (ValorP240 == 9)
        {
            Instantiate(P9_M_P, new Vector2(PosX240, myPosY + Intersecciones * 240), transform.rotation);
        }
        if (ValorP240 == 11)
        {
            Instantiate(P9_Q_P, new Vector2(PosX240, myPosY + Intersecciones * 240), transform.rotation);
        }
        int ValorP241 = Random.Range(0, 12);
        float PosX241 = Random.Range(-2.6f, 2.6f);
        if (ValorP241 == 0)
        {
            Instantiate(P8_M, new Vector2(PosX241, myPosY + Intersecciones * 241), transform.rotation);
        }
        if (ValorP241 == 2)
        {
            Instantiate(P8_Q, new Vector2(PosX241, myPosY + Intersecciones * 241), transform.rotation);
        }
        if (ValorP241 == 4)
        {
            Instantiate(P8_M_SS, new Vector2(PosX241, myPosY + Intersecciones * 241), transform.rotation);
        }
        if (ValorP241 == 6)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX241, myPosY + Intersecciones * 241), transform.rotation);
        }
        if (ValorP241 == 8)
        {
            Instantiate(P8_M_P, new Vector2(PosX241, myPosY + Intersecciones * 241), transform.rotation);
        }
        if (ValorP241 == 10)
        {
            Instantiate(P8_Q_P, new Vector2(PosX241, myPosY + Intersecciones * 241), transform.rotation);
        }
        if (ValorP241 == 1)
        {
            Instantiate(P9_M, new Vector2(PosX241, myPosY + Intersecciones * 241), transform.rotation);
        }
        if (ValorP241 == 3)
        {
            Instantiate(P9_Q, new Vector2(PosX241, myPosY + Intersecciones * 241), transform.rotation);
        }
        if (ValorP241 == 5)
        {
            Instantiate(P9_M_SS, new Vector2(PosX241, myPosY + Intersecciones * 241), transform.rotation);
        }
        if (ValorP241 == 7)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX241, myPosY + Intersecciones * 241), transform.rotation);
        }
        if (ValorP241 == 9)
        {
            Instantiate(P9_M_P, new Vector2(PosX241, myPosY + Intersecciones * 241), transform.rotation);
        }
        if (ValorP241 == 11)
        {
            Instantiate(P9_Q_P, new Vector2(PosX241, myPosY + Intersecciones * 241), transform.rotation);
        }
        int ValorP242 = Random.Range(0, 12);
        float PosX242 = Random.Range(-2.6f, 2.6f);
        if (ValorP242 == 0)
        {
            Instantiate(P8_M, new Vector2(PosX242, myPosY + Intersecciones * 242), transform.rotation);
        }
        if (ValorP242 == 2)
        {
            Instantiate(P8_Q, new Vector2(PosX242, myPosY + Intersecciones * 242), transform.rotation);
        }
        if (ValorP242 == 4)
        {
            Instantiate(P8_M_SS, new Vector2(PosX242, myPosY + Intersecciones * 242), transform.rotation);
        }
        if (ValorP242 == 6)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX242, myPosY + Intersecciones * 242), transform.rotation);
        }
        if (ValorP242 == 8)
        {
            Instantiate(P8_M_P, new Vector2(PosX242, myPosY + Intersecciones * 242), transform.rotation);
        }
        if (ValorP242 == 10)
        {
            Instantiate(P8_Q_P, new Vector2(PosX242, myPosY + Intersecciones * 242), transform.rotation);
        }
        if (ValorP242 == 1)
        {
            Instantiate(P9_M, new Vector2(PosX242, myPosY + Intersecciones * 242), transform.rotation);
        }
        if (ValorP242 == 3)
        {
            Instantiate(P9_Q, new Vector2(PosX242, myPosY + Intersecciones * 242), transform.rotation);
        }
        if (ValorP242 == 5)
        {
            Instantiate(P9_M_SS, new Vector2(PosX242, myPosY + Intersecciones * 242), transform.rotation);
        }
        if (ValorP242 == 7)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX242, myPosY + Intersecciones * 242), transform.rotation);
        }
        if (ValorP242 == 9)
        {
            Instantiate(P9_M_P, new Vector2(PosX242, myPosY + Intersecciones * 242), transform.rotation);
        }
        if (ValorP242 == 11)
        {
            Instantiate(P9_Q_P, new Vector2(PosX242, myPosY + Intersecciones * 242), transform.rotation);
        }
        int ValorP243 = Random.Range(0, 12);
        float PosX243 = Random.Range(-2.6f, 2.6f);
        if (ValorP243 == 0)
        {
            Instantiate(P8_M, new Vector2(PosX243, myPosY + Intersecciones * 243), transform.rotation);
        }
        if (ValorP243 == 2)
        {
            Instantiate(P8_Q, new Vector2(PosX243, myPosY + Intersecciones * 243), transform.rotation);
        }
        if (ValorP243 == 4)
        {
            Instantiate(P8_M_SS, new Vector2(PosX243, myPosY + Intersecciones * 243), transform.rotation);
        }
        if (ValorP243 == 6)
        {
            Instantiate(P8_Q_SS, new Vector2(PosX243, myPosY + Intersecciones * 243), transform.rotation);
        }
        if (ValorP243 == 8)
        {
            Instantiate(P8_M_P, new Vector2(PosX243, myPosY + Intersecciones * 243), transform.rotation);
        }
        if (ValorP243 == 10)
        {
            Instantiate(P8_Q_P, new Vector2(PosX243, myPosY + Intersecciones * 243), transform.rotation);
        }
        if (ValorP243 == 1)
        {
            Instantiate(P9_M, new Vector2(PosX243, myPosY + Intersecciones * 243), transform.rotation);
        }
        if (ValorP243 == 3)
        {
            Instantiate(P9_Q, new Vector2(PosX243, myPosY + Intersecciones * 243), transform.rotation);
        }
        if (ValorP243 == 5)
        {
            Instantiate(P9_M_SS, new Vector2(PosX243, myPosY + Intersecciones * 243), transform.rotation);
        }
        if (ValorP243 == 7)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX243, myPosY + Intersecciones * 243), transform.rotation);
        }
        if (ValorP243 == 9)
        {
            Instantiate(P9_M_P, new Vector2(PosX243, myPosY + Intersecciones * 243), transform.rotation);
        }
        if (ValorP243 == 11)
        {
            Instantiate(P9_Q_P, new Vector2(PosX243, myPosY + Intersecciones * 243), transform.rotation);
        }
        int ValorP244 = Random.Range(0,6);
        float PosX244 = Random.Range(-2.6f, 2.6f);
        if (ValorP244 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX244, myPosY + Intersecciones * 244), transform.rotation);
        }
        if (ValorP244 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX244, myPosY + Intersecciones * 244), transform.rotation);
        }
        if (ValorP244 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX244, myPosY + Intersecciones * 244), transform.rotation);
        }
        if (ValorP244 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX244, myPosY + Intersecciones * 244), transform.rotation);
        }
        if (ValorP244 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX244, myPosY + Intersecciones * 244), transform.rotation);
        }
        if (ValorP244 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX244, myPosY + Intersecciones * 244), transform.rotation);
        }
        int ValorP245 = Random.Range(0, 6);
        float PosX245 = Random.Range(-2.6f, 2.6f);
        if (ValorP245 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX245, myPosY + Intersecciones * 245), transform.rotation);
        }
        if (ValorP245 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX245, myPosY + Intersecciones * 245), transform.rotation);
        }
        if (ValorP245 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX245, myPosY + Intersecciones * 245), transform.rotation);
        }
        if (ValorP245 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX245, myPosY + Intersecciones * 245), transform.rotation);
        }
        if (ValorP245 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX245, myPosY + Intersecciones * 245), transform.rotation);
        }
        if (ValorP245 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX245, myPosY + Intersecciones * 245), transform.rotation);
        }
        int ValorP246 = Random.Range(0, 6);
        float PosX246 = Random.Range(-2.6f, 2.6f);
        if (ValorP246 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX246, myPosY + Intersecciones * 246), transform.rotation);
        }
        if (ValorP246 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX246, myPosY + Intersecciones * 246), transform.rotation);
        }
        if (ValorP246 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX246, myPosY + Intersecciones * 246), transform.rotation);
        }
        if (ValorP246 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX246, myPosY + Intersecciones * 246), transform.rotation);
        }
        if (ValorP246 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX246, myPosY + Intersecciones * 246), transform.rotation);
        }
        if (ValorP246 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX246, myPosY + Intersecciones * 246), transform.rotation);
        }
        int ValorP247 = Random.Range(0, 6);
        float PosX247 = Random.Range(-2.6f, 2.6f);
        if (ValorP247 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX247, myPosY + Intersecciones * 247), transform.rotation);
        }
        if (ValorP247 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX247, myPosY + Intersecciones * 247), transform.rotation);
        }
        if (ValorP247 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX247, myPosY + Intersecciones * 247), transform.rotation);
        }
        if (ValorP247 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX247, myPosY + Intersecciones * 247), transform.rotation);
        }
        if (ValorP247 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX247, myPosY + Intersecciones * 247), transform.rotation);
        }
        if (ValorP247 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX247, myPosY + Intersecciones * 247), transform.rotation);
        }
        int ValorP248 = Random.Range(0, 6);
        float PosX248 = Random.Range(-2.6f, 2.6f);
        if (ValorP248 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX248, myPosY + Intersecciones * 248), transform.rotation);
        }
        if (ValorP248 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX248, myPosY + Intersecciones * 248), transform.rotation);
        }
        if (ValorP248 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX248, myPosY + Intersecciones * 248), transform.rotation);
        }
        if (ValorP248 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX248, myPosY + Intersecciones * 248), transform.rotation);
        }
        if (ValorP248 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX248, myPosY + Intersecciones * 248), transform.rotation);
        }
        if (ValorP248 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX248, myPosY + Intersecciones * 248), transform.rotation);
        }
        int ValorP249 = Random.Range(0, 6);
        float PosX249 = Random.Range(-2.6f, 2.6f);
        if (ValorP249 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX249, myPosY + Intersecciones * 249), transform.rotation);
        }
        if (ValorP249 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX249, myPosY + Intersecciones * 249), transform.rotation);
        }
        if (ValorP249 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX249, myPosY + Intersecciones * 249), transform.rotation);
        }
        if (ValorP249 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX249, myPosY + Intersecciones * 249), transform.rotation);
        }
        if (ValorP249 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX249, myPosY + Intersecciones * 249), transform.rotation);
        }
        if (ValorP249 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX249, myPosY + Intersecciones * 249), transform.rotation);
        }
        int ValorP250 = Random.Range(0, 6);
        float PosX250 = Random.Range(-2.6f, 2.6f);
        if (ValorP250 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX250, myPosY + Intersecciones * 250), transform.rotation);
        }
        if (ValorP250 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX250, myPosY + Intersecciones * 250), transform.rotation);
        }
        if (ValorP250 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX250, myPosY + Intersecciones * 250), transform.rotation);
        }
        if (ValorP250 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX250, myPosY + Intersecciones * 250), transform.rotation);
        }
        if (ValorP250 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX250, myPosY + Intersecciones * 250), transform.rotation);
        }
        if (ValorP250 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX250, myPosY + Intersecciones * 250), transform.rotation);
        }
        int ValorP251 = Random.Range(0, 6);
        float PosX251 = Random.Range(-2.6f, 2.6f);
        if (ValorP251 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX251, myPosY + Intersecciones * 251), transform.rotation);
        }
        if (ValorP251 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX251, myPosY + Intersecciones * 251), transform.rotation);
        }
        if (ValorP251 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX251, myPosY + Intersecciones * 251), transform.rotation);
        }
        if (ValorP251 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX251, myPosY + Intersecciones * 251), transform.rotation);
        }
        if (ValorP251 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX251, myPosY + Intersecciones * 251), transform.rotation);
        }
        if (ValorP251 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX251, myPosY + Intersecciones * 251), transform.rotation);
        }
        int ValorP252 = Random.Range(0, 6);
        float PosX252 = Random.Range(-2.6f, 2.6f);
        if (ValorP252 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX252, myPosY + Intersecciones * 252), transform.rotation);
        }
        if (ValorP252 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX252, myPosY + Intersecciones * 252), transform.rotation);
        }
        if (ValorP252 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX252, myPosY + Intersecciones * 252), transform.rotation);
        }
        if (ValorP252 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX252, myPosY + Intersecciones * 252), transform.rotation);
        }
        if (ValorP252 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX252, myPosY + Intersecciones * 252), transform.rotation);
        }
        if (ValorP252 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX252, myPosY + Intersecciones * 252), transform.rotation);
        }
        int ValorP253 = Random.Range(0, 6);
        float PosX253 = Random.Range(-2.6f, 2.6f);
        if (ValorP253 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX253, myPosY + Intersecciones * 253), transform.rotation);
        }
        if (ValorP253 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX253, myPosY + Intersecciones * 253), transform.rotation);
        }
        if (ValorP253 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX253, myPosY + Intersecciones * 253), transform.rotation);
        }
        if (ValorP253 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX253, myPosY + Intersecciones * 253), transform.rotation);
        }
        if (ValorP253 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX253, myPosY + Intersecciones * 253), transform.rotation);
        }
        if (ValorP253 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX253, myPosY + Intersecciones * 253), transform.rotation);
        }
        int ValorP254 = Random.Range(0, 6);
        float PosX254 = Random.Range(-2.6f, 2.6f);
        if (ValorP254 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX254, myPosY + Intersecciones * 254), transform.rotation);
        }
        if (ValorP254 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX254, myPosY + Intersecciones * 254), transform.rotation);
        }
        if (ValorP254 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX254, myPosY + Intersecciones * 254), transform.rotation);
        }
        if (ValorP254 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX254, myPosY + Intersecciones * 254), transform.rotation);
        }
        if (ValorP254 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX254, myPosY + Intersecciones * 254), transform.rotation);
        }
        if (ValorP254 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX254, myPosY + Intersecciones * 254), transform.rotation);
        }
        int ValorP255 = Random.Range(0, 6);
        float PosX255 = Random.Range(-2.6f, 2.6f);
        if (ValorP255 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX255, myPosY + Intersecciones * 255), transform.rotation);
        }
        if (ValorP255 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX255, myPosY + Intersecciones * 255), transform.rotation);
        }
        if (ValorP255 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX255, myPosY + Intersecciones * 255), transform.rotation);
        }
        if (ValorP255 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX255, myPosY + Intersecciones * 255), transform.rotation);
        }
        if (ValorP255 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX255, myPosY + Intersecciones * 255), transform.rotation);
        }
        if (ValorP255 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX255, myPosY + Intersecciones * 255), transform.rotation);
        }
        int ValorP256 = Random.Range(0, 6);
        float PosX256 = Random.Range(-2.6f, 2.6f);
        if (ValorP256 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX256, myPosY + Intersecciones * 256), transform.rotation);
        }
        if (ValorP256 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX256, myPosY + Intersecciones * 256), transform.rotation);
        }
        if (ValorP256 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX256, myPosY + Intersecciones * 256), transform.rotation);
        }
        if (ValorP256 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX256, myPosY + Intersecciones * 256), transform.rotation);
        }
        if (ValorP256 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX256, myPosY + Intersecciones * 256), transform.rotation);
        }
        if (ValorP256 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX256, myPosY + Intersecciones * 256), transform.rotation);
        }
        int ValorP257 = Random.Range(0, 6);
        float PosX257 = Random.Range(-2.6f, 2.6f);
        if (ValorP257 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX257, myPosY + Intersecciones * 257), transform.rotation);
        }
        if (ValorP257 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX257, myPosY + Intersecciones * 257), transform.rotation);
        }
        if (ValorP257 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX257, myPosY + Intersecciones * 257), transform.rotation);
        }
        if (ValorP257 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX257, myPosY + Intersecciones * 257), transform.rotation);
        }
        if (ValorP257 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX257, myPosY + Intersecciones * 257), transform.rotation);
        }
        if (ValorP257 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX257, myPosY + Intersecciones * 257), transform.rotation);
        }
        int ValorP258 = Random.Range(0, 6);
        float PosX258 = Random.Range(-2.6f, 2.6f);
        if (ValorP258 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX258, myPosY + Intersecciones * 258), transform.rotation);
        }
        if (ValorP258 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX258, myPosY + Intersecciones * 258), transform.rotation);
        }
        if (ValorP258 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX258, myPosY + Intersecciones * 258), transform.rotation);
        }
        if (ValorP258 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX258, myPosY + Intersecciones * 258), transform.rotation);
        }
        if (ValorP258 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX258, myPosY + Intersecciones * 258), transform.rotation);
        }
        if (ValorP258 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX258, myPosY + Intersecciones * 258), transform.rotation);
        }
        int ValorP259 = Random.Range(0, 6);
        float PosX259 = Random.Range(-2.6f, 2.6f);
        if (ValorP259 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX259, myPosY + Intersecciones * 259), transform.rotation);
        }
        if (ValorP259 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX259, myPosY + Intersecciones * 259), transform.rotation);
        }
        if (ValorP259 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX259, myPosY + Intersecciones * 259), transform.rotation);
        }
        if (ValorP259 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX259, myPosY + Intersecciones * 259), transform.rotation);
        }
        if (ValorP259 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX259, myPosY + Intersecciones * 259), transform.rotation);
        }
        if (ValorP259 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX259, myPosY + Intersecciones * 259), transform.rotation);
        }
        int ValorP260 = Random.Range(0, 6);
        float PosX260 = Random.Range(-2.6f, 2.6f);
        if (ValorP260 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX260, myPosY + Intersecciones * 260), transform.rotation);
        }
        if (ValorP260 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX260, myPosY + Intersecciones * 260), transform.rotation);
        }
        if (ValorP260 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX260, myPosY + Intersecciones * 260), transform.rotation);
        }
        if (ValorP260 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX260, myPosY + Intersecciones * 260), transform.rotation);
        }
        if (ValorP260 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX260, myPosY + Intersecciones * 260), transform.rotation);
        }
        if (ValorP260 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX260, myPosY + Intersecciones * 260), transform.rotation);
        }
        int ValorP261 = Random.Range(0, 6);
        float PosX261 = Random.Range(-2.6f, 2.6f);
        if (ValorP261 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX261, myPosY + Intersecciones * 261), transform.rotation);
        }
        if (ValorP261 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX261, myPosY + Intersecciones * 261), transform.rotation);
        }
        if (ValorP261 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX261, myPosY + Intersecciones * 261), transform.rotation);
        }
        if (ValorP261 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX261, myPosY + Intersecciones * 261), transform.rotation);
        }
        if (ValorP261 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX261, myPosY + Intersecciones * 261), transform.rotation);
        }
        if (ValorP261 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX261, myPosY + Intersecciones * 261), transform.rotation);
        }
        int ValorP262 = Random.Range(0, 6);
        float PosX262 = Random.Range(-2.6f, 2.6f);
        if (ValorP262 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX262, myPosY + Intersecciones * 262), transform.rotation);
        }
        if (ValorP262 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX262, myPosY + Intersecciones * 262), transform.rotation);
        }
        if (ValorP262 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX262, myPosY + Intersecciones * 262), transform.rotation);
        }
        if (ValorP262 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX262, myPosY + Intersecciones * 262), transform.rotation);
        }
        if (ValorP262 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX262, myPosY + Intersecciones * 262), transform.rotation);
        }
        if (ValorP262 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX262, myPosY + Intersecciones * 262), transform.rotation);
        }
        int ValorP263 = Random.Range(0, 6);
        float PosX263 = Random.Range(-2.6f, 2.6f);
        if (ValorP263 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX263, myPosY + Intersecciones * 263), transform.rotation);
        }
        if (ValorP263 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX263, myPosY + Intersecciones * 263), transform.rotation);
        }
        if (ValorP263 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX263, myPosY + Intersecciones * 263), transform.rotation);
        }
        if (ValorP263 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX263, myPosY + Intersecciones * 263), transform.rotation);
        }
        if (ValorP263 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX263, myPosY + Intersecciones * 263), transform.rotation);
        }
        if (ValorP263 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX263, myPosY + Intersecciones * 263), transform.rotation);
        }
        int ValorP264 = Random.Range(0, 6);
        float PosX264 = Random.Range(-2.6f, 2.6f);
        if (ValorP264 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX264, myPosY + Intersecciones * 264), transform.rotation);
        }
        if (ValorP264 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX264, myPosY + Intersecciones * 264), transform.rotation);
        }
        if (ValorP264 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX264, myPosY + Intersecciones * 264), transform.rotation);
        }
        if (ValorP264 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX264, myPosY + Intersecciones * 264), transform.rotation);
        }
        if (ValorP264 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX264, myPosY + Intersecciones * 264), transform.rotation);
        }
        if (ValorP264 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX264, myPosY + Intersecciones * 264), transform.rotation);
        }
        int ValorP265 = Random.Range(0, 6);
        float PosX265 = Random.Range(-2.6f, 2.6f);
        if (ValorP265 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX265, myPosY + Intersecciones * 265), transform.rotation);
        }
        if (ValorP265 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX265, myPosY + Intersecciones * 265), transform.rotation);
        }
        if (ValorP265 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX265, myPosY + Intersecciones * 265), transform.rotation);
        }
        if (ValorP265 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX265, myPosY + Intersecciones * 265), transform.rotation);
        }
        if (ValorP265 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX265, myPosY + Intersecciones * 265), transform.rotation);
        }
        if (ValorP265 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX265, myPosY + Intersecciones * 265), transform.rotation);
        }
        int ValorP266 = Random.Range(0, 6);
        float PosX266 = Random.Range(-2.6f, 2.6f);
        if (ValorP266 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX266, myPosY + Intersecciones * 266), transform.rotation);
        }
        if (ValorP266 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX266, myPosY + Intersecciones * 266), transform.rotation);
        }
        if (ValorP266 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX266, myPosY + Intersecciones * 266), transform.rotation);
        }
        if (ValorP266 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX266, myPosY + Intersecciones * 266), transform.rotation);
        }
        if (ValorP266 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX266, myPosY + Intersecciones * 266), transform.rotation);
        }
        if (ValorP266 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX266, myPosY + Intersecciones * 266), transform.rotation);
        }
        int ValorP267 = Random.Range(0, 6);
        float PosX267 = Random.Range(-2.6f, 2.6f);
        if (ValorP267 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX267, myPosY + Intersecciones * 267), transform.rotation);
        }
        if (ValorP267 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX267, myPosY + Intersecciones * 267), transform.rotation);
        }
        if (ValorP267 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX267, myPosY + Intersecciones * 267), transform.rotation);
        }
        if (ValorP267 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX267, myPosY + Intersecciones * 267), transform.rotation);
        }
        if (ValorP267 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX267, myPosY + Intersecciones * 267), transform.rotation);
        }
        if (ValorP267 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX267, myPosY + Intersecciones * 267), transform.rotation);
        }
        int ValorP268 = Random.Range(0, 6);
        float PosX268 = Random.Range(-2.6f, 2.6f);
        if (ValorP268 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX268, myPosY + Intersecciones * 268), transform.rotation);
        }
        if (ValorP268 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX268, myPosY + Intersecciones * 268), transform.rotation);
        }
        if (ValorP268 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX268, myPosY + Intersecciones * 268), transform.rotation);
        }
        if (ValorP268 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX268, myPosY + Intersecciones * 268), transform.rotation);
        }
        if (ValorP268 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX268, myPosY + Intersecciones * 268), transform.rotation);
        }
        if (ValorP268 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX268, myPosY + Intersecciones * 268), transform.rotation);
        }
        int ValorP269 = Random.Range(0, 6);
        float PosX269 = Random.Range(-2.6f, 2.6f);
        if (ValorP269 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX269, myPosY + Intersecciones * 269), transform.rotation);
        }
        if (ValorP269 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX269, myPosY + Intersecciones * 269), transform.rotation);
        }
        if (ValorP269 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX269, myPosY + Intersecciones * 269), transform.rotation);
        }
        if (ValorP269 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX269, myPosY + Intersecciones * 269), transform.rotation);
        }
        if (ValorP269 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX269, myPosY + Intersecciones * 269), transform.rotation);
        }
        if (ValorP269 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX269, myPosY + Intersecciones * 269), transform.rotation);
        }
        int ValorP270 = Random.Range(0, 6);
        float PosX270 = Random.Range(-2.6f, 2.6f);
        if (ValorP270 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX270, myPosY + Intersecciones * 270), transform.rotation);
        }
        if (ValorP270 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX270, myPosY + Intersecciones * 270), transform.rotation);
        }
        if (ValorP270 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX270, myPosY + Intersecciones * 270), transform.rotation);
        }
        if (ValorP270 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX270, myPosY + Intersecciones * 270), transform.rotation);
        }
        if (ValorP270 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX270, myPosY + Intersecciones * 270), transform.rotation);
        }
        if (ValorP270 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX270, myPosY + Intersecciones * 270), transform.rotation);
        }
        int ValorP271 = Random.Range(0, 6);
        float PosX271 = Random.Range(-2.6f, 2.6f);
        if (ValorP271 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX271, myPosY + Intersecciones * 271), transform.rotation);
        }
        if (ValorP271 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX271, myPosY + Intersecciones * 271), transform.rotation);
        }
        if (ValorP271 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX271, myPosY + Intersecciones * 271), transform.rotation);
        }
        if (ValorP271 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX271, myPosY + Intersecciones * 271), transform.rotation);
        }
        if (ValorP271 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX271, myPosY + Intersecciones * 271), transform.rotation);
        }
        if (ValorP271 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX271, myPosY + Intersecciones * 271), transform.rotation);
        }
        int ValorP272 = Random.Range(0, 6);
        float PosX272 = Random.Range(-2.6f, 2.6f);
        if (ValorP272 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX272, myPosY + Intersecciones * 272), transform.rotation);
        }
        if (ValorP272 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX272, myPosY + Intersecciones * 272), transform.rotation);
        }
        if (ValorP272 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX272, myPosY + Intersecciones * 272), transform.rotation);
        }
        if (ValorP272 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX272, myPosY + Intersecciones * 272), transform.rotation);
        }
        if (ValorP272 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX272, myPosY + Intersecciones * 272), transform.rotation);
        }
        if (ValorP272 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX272, myPosY + Intersecciones * 272), transform.rotation);
        }
        int ValorP273 = Random.Range(0, 6);
        float PosX273 = Random.Range(-2.6f, 2.6f);
        if (ValorP273 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX273, myPosY + Intersecciones * 273), transform.rotation);
        }
        if (ValorP273 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX273, myPosY + Intersecciones * 273), transform.rotation);
        }
        if (ValorP273 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX273, myPosY + Intersecciones * 273), transform.rotation);
        }
        if (ValorP273 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX273, myPosY + Intersecciones * 273), transform.rotation);
        }
        if (ValorP273 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX273, myPosY + Intersecciones * 273), transform.rotation);
        }
        if (ValorP273 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX273, myPosY + Intersecciones * 273), transform.rotation);
        }
        int ValorP274 = Random.Range(0, 6);
        float PosX274 = Random.Range(-2.6f, 2.6f);
        if (ValorP274 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX274, myPosY + Intersecciones * 274), transform.rotation);
        }
        if (ValorP274 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX274, myPosY + Intersecciones * 274), transform.rotation);
        }
        if (ValorP274 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX274, myPosY + Intersecciones * 274), transform.rotation);
        }
        if (ValorP274 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX274, myPosY + Intersecciones * 274), transform.rotation);
        }
        if (ValorP274 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX274, myPosY + Intersecciones * 274), transform.rotation);
        }
        if (ValorP274 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX274, myPosY + Intersecciones * 274), transform.rotation);
        }
        int ValorP275 = Random.Range(0, 6);
        float PosX275 = Random.Range(-2.6f, 2.6f);
        if (ValorP275 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX275, myPosY + Intersecciones * 275), transform.rotation);
        }
        if (ValorP275 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX275, myPosY + Intersecciones * 275), transform.rotation);
        }
        if (ValorP275 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX275, myPosY + Intersecciones * 275), transform.rotation);
        }
        if (ValorP275 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX275, myPosY + Intersecciones * 275), transform.rotation);
        }
        if (ValorP275 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX275, myPosY + Intersecciones * 275), transform.rotation);
        }
        if (ValorP275 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX275, myPosY + Intersecciones * 275), transform.rotation);
        }
        int ValorP276 = Random.Range(0, 6);
        float PosX276 = Random.Range(-2.6f, 2.6f);
        if (ValorP276 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX276, myPosY + Intersecciones * 276), transform.rotation);
        }
        if (ValorP276 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX276, myPosY + Intersecciones * 276), transform.rotation);
        }
        if (ValorP276 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX276, myPosY + Intersecciones * 276), transform.rotation);
        }
        if (ValorP276 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX276, myPosY + Intersecciones * 276), transform.rotation);
        }
        if (ValorP276 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX276, myPosY + Intersecciones * 276), transform.rotation);
        }
        if (ValorP276 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX276, myPosY + Intersecciones * 276), transform.rotation);
        }
        int ValorP277 = Random.Range(0, 6);
        float PosX277 = Random.Range(-2.6f, 2.6f);
        if (ValorP277 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX277, myPosY + Intersecciones * 277), transform.rotation);
        }
        if (ValorP277 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX277, myPosY + Intersecciones * 277), transform.rotation);
        }
        if (ValorP277 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX277, myPosY + Intersecciones * 277), transform.rotation);
        }
        if (ValorP277 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX277, myPosY + Intersecciones * 277), transform.rotation);
        }
        if (ValorP277 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX277, myPosY + Intersecciones * 277), transform.rotation);
        }
        if (ValorP277 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX277, myPosY + Intersecciones * 277), transform.rotation);
        }
        int ValorP278 = Random.Range(0, 6);
        float PosX278 = Random.Range(-2.6f, 2.6f);
        if (ValorP278 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX278, myPosY + Intersecciones * 278), transform.rotation);
        }
        if (ValorP278 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX278, myPosY + Intersecciones * 278), transform.rotation);
        }
        if (ValorP278 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX278, myPosY + Intersecciones * 278), transform.rotation);
        }
        if (ValorP278 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX278, myPosY + Intersecciones * 278), transform.rotation);
        }
        if (ValorP278 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX278, myPosY + Intersecciones * 278), transform.rotation);
        }
        if (ValorP278 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX278, myPosY + Intersecciones * 278), transform.rotation);
        }
        int ValorP279 = Random.Range(0, 6);
        float PosX279 = Random.Range(-2.6f, 2.6f);
        if (ValorP279 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX279, myPosY + Intersecciones * 279), transform.rotation);
        }
        if (ValorP279 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX279, myPosY + Intersecciones * 279), transform.rotation);
        }
        if (ValorP279 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX279, myPosY + Intersecciones * 279), transform.rotation);
        }
        if (ValorP279 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX279, myPosY + Intersecciones * 279), transform.rotation);
        }
        if (ValorP279 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX279, myPosY + Intersecciones * 279), transform.rotation);
        }
        if (ValorP279 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX279, myPosY + Intersecciones * 279), transform.rotation);
        }
        int ValorP280 = Random.Range(0, 6);
        float PosX280 = Random.Range(-2.6f, 2.6f);
        if (ValorP280 == 0)
        {
            Instantiate(P9_M, new Vector2(PosX280, myPosY + Intersecciones * 280), transform.rotation);
        }
        if (ValorP280 == 1)
        {
            Instantiate(P9_Q, new Vector2(PosX280, myPosY + Intersecciones * 280), transform.rotation);
        }
        if (ValorP280 == 2)
        {
            Instantiate(P9_M_SS, new Vector2(PosX280, myPosY + Intersecciones * 280), transform.rotation);
        }
        if (ValorP280 == 3)
        {
            Instantiate(P9_Q_SS, new Vector2(PosX280, myPosY + Intersecciones * 280), transform.rotation);
        }
        if (ValorP280 == 4)
        {
            Instantiate(P9_M_P, new Vector2(PosX280, myPosY + Intersecciones * 280), transform.rotation);
        }
        if (ValorP280 == 5)
        {
            Instantiate(P9_Q_P, new Vector2(PosX280, myPosY + Intersecciones * 280), transform.rotation);
        }
        #endregion
    }
}