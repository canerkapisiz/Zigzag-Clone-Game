using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminSpKontrol : MonoBehaviour
{
    public GameObject referansKupObje;

    [SerializeField] private GameObject kupPrefab;

    private GameObject yeniKupObje;

    private int kupDegisken;

    void Start()
    {
        Dongu();
    }

    void Dongu()
    {
        for (int i = 0; i < 75; i++)
        {
            YeniKupObjeOlustur();
        }
    }

    void YeniKupObjeOlustur()
    {
        kupDegisken = Random.Range(0, 2);

        if(kupDegisken == 0)
        {
            yeniKupObje = Instantiate(kupPrefab, new Vector3(referansKupObje.transform.position.x - 1f, referansKupObje.transform.position.y, referansKupObje.transform.position.z),Quaternion.identity);
            referansKupObje = yeniKupObje;
        }
        else
        {
            yeniKupObje = Instantiate(kupPrefab, new Vector3(referansKupObje.transform.position.x, referansKupObje.transform.position.y, referansKupObje.transform.position.z + 1f), Quaternion.identity);
            referansKupObje = yeniKupObje;
        }
    }
}
