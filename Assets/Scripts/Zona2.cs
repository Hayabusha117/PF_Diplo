using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zona2 : MonoBehaviour
{
 
    public GameObject spawn02;
    public GameObject spawn03;



    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            if(spawn02.activeInHierarchy == false)
            {
                spawn02.SetActive(true);
                spawn03.SetActive(true);

            }

        }
    }

   


}