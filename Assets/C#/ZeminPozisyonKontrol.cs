using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminPozisyonKontrol : MonoBehaviour
{
    private ZeminSpKontrol zeminSpKontrol;

    private Rigidbody rb;

    [SerializeField] private float bitisYDegeri;

    private int kupYon;

    void Start()
    {
        zeminSpKontrol = FindObjectOfType<ZeminSpKontrol>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        KupYDegerKontrolEtme();
    }

    void KupYDegerKontrolEtme()
    {
        if(transform.position.y <= bitisYDegeri)
        {
            PlayerPrefs.SetInt("Skor", PlayerPrefs.GetInt("Skor") + 10);
            RbYenidenDuzeltme();

            kupYon = Random.Range(0, 2);

            if(kupYon == 0)
            {
                transform.position = new Vector3(zeminSpKontrol.referansKupObje.transform.position.x - 1f, zeminSpKontrol.referansKupObje.transform.position.y, zeminSpKontrol.referansKupObje.transform.position.z);
            }
            else
            {
                transform.position = new Vector3(zeminSpKontrol.referansKupObje.transform.position.x, zeminSpKontrol.referansKupObje.transform.position.y, zeminSpKontrol.referansKupObje.transform.position.z + 1f);
            }
            zeminSpKontrol.referansKupObje = gameObject;
        }
    }

    void RbYenidenDuzeltme()
    {
        rb.isKinematic = true;
        rb.useGravity = false;
    }
}
