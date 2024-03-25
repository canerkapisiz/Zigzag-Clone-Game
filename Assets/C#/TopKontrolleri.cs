using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopKontrolleri : MonoBehaviour
{
    [HideInInspector]public Vector3 topYon;
    public Rigidbody rb;

    public GameObject panel;
    public Text skorText;

    void Start()
    {
        //Oyun ilk başladığında topumuz sola doğru gitsin istiyoruz
        
    }

    void Update()
    {
        TopaYonVeriyoruz();

        if (panel.activeSelf)
        {
            if(PlayerPrefs.GetInt("Skor") > PlayerPrefs.GetInt("YüksekSkorcu"))
            {
                PlayerPrefs.SetInt("YüksekSkorcu", PlayerPrefs.GetInt("Skor"));
                skorText.text = "Yüksek Skor: " + PlayerPrefs.GetInt("YüksekSkorcu").ToString();
            }
            else
            {
                skorText.text = "Yüksek Skor: " + PlayerPrefs.GetInt("YüksekSkorcu").ToString();
            }
            
        }
    }

    void TopaYonVeriyoruz() //HandleBallInputs
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Her ekrana tıklandığında yön değiştirecek
            TopHangiYonde();
        }
    }

    void TopHangiYonde()  // ChangeBallDirection
    {
        // Top Sola gitdiyor mu gitmiyor mu onu kontrol ettik
        if(topYon.x == -1)
        {
            topYon = Vector3.forward;
        }
        else
        {
            topYon = Vector3.left;
        }
    }

    public void OyunBasla()
    {
        panel.SetActive(false);
        RbAYarlari();
        topYon = Vector3.left;
        PlayerPrefs.SetInt("Skor", 0);
    }

    public void RbAYarlari()
    {
        rb.isKinematic = false;
        rb.useGravity = true;    }
}
