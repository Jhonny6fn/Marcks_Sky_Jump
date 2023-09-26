using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolverMenu : MonoBehaviour
{
    public void VolverAlMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}