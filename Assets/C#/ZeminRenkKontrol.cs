using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminRenkKontrol : MonoBehaviour
{
    [SerializeField] private Material zeminMaterial;

    [SerializeField] private Color[] renkler;

    int renkSayisi = 0;

    [SerializeField] private float degisken;

    [SerializeField] private float zaman;

    float anlikZaman;

    void Update()
    {
        RenkDegişmeZamani();
        ZeminRenkKontrolEdelim(); 
    }

    void RenkDegişmeZamani()
    {
        if(anlikZaman <= 0)
        {
            RenkDegeriniKontrolEtmek();
            anlikZaman = zaman;
        }
        else
        {
            anlikZaman -= Time.deltaTime;
        }
    }


    void RenkDegeriniKontrolEtmek()
    {
        renkSayisi++;

        if(renkSayisi >= renkler.Length)
        {
            renkSayisi = 0;
        }
    }

    void ZeminRenkKontrolEdelim()
    {
        zeminMaterial.color = Color.Lerp(zeminMaterial.color, renkler[renkSayisi], degisken * Time.deltaTime);
    }

    void OnDestroy()
    {
        zeminMaterial.color = renkler[1];
    }
}
