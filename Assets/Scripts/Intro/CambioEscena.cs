using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    public GameObject Cambio;
    private void Update()
    {
        if (Cambio.activeInHierarchy)
        {
            SceneManager.LoadScene(2);
        }
       
    }
}