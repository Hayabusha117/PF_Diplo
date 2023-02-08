using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WeaponManager : MonoBehaviour
{
    public GameObject[] Weapons;
    public GameObject Disparos;
    public GameObject Knife;
    public Sprite rifle;
    public Sprite spriteKnife;
    public Image imgWeapon;
  


    // Start is called before the first frame update
    void Start()
    {
        ClearWeapons();
        Weapons[0].SetActive(true);
        Knife.SetActive(false);
        imgWeapon.sprite = rifle;
        
      
  

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (Weapons[0].activeInHierarchy) // activacion cuchillo
            {
                Weapons[0].SetActive(false);
                Disparos.SetActive(false);
                Weapons[1].SetActive(true);
                Knife.SetActive(true);
                imgWeapon.sprite = spriteKnife;
               


            }
            else
            {
                if (Weapons[1].activeInHierarchy) // activacion rifle
                {
                    Weapons[1].SetActive(false);
                    Disparos.SetActive(true);
                    Weapons[0].SetActive(true);
                    Knife.SetActive(false);
                    imgWeapon.sprite = rifle;
                }
            }

        }
        
    }


    private void ClearWeapons()
    {
        for (int i = 0; i < Weapons.Length; i++)
        {
            Weapons[i].SetActive(false);
        }
    }

}
