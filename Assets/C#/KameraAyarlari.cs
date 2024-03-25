using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraAyarlari : MonoBehaviour
{
    [SerializeField] private Transform top;

    Vector3 aralarindakiMefase;

    [SerializeField] private float deger;

    Vector3 yeniPozisyon;

    void Start()
    {
        aralarindakiMefase = transform.position - top.position;
    }

    void LateUpdate()
    {
        KameraTakip();
    }

    void KameraTakip()
    {
        yeniPozisyon = Vector3.Lerp(transform.position,top.position+aralarindakiMefase,deger * Time.deltaTime);
        transform.position = yeniPozisyon;
    }
}
