using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopHareket : MonoBehaviour
{
    [SerializeField]
    private Top top;

    [SerializeField]
    private float topHizi;

    void Update()
    {
        TopHareketiniAyarlama();
    }

    void TopHareketiniAyarlama()
    {
        transform.position += top.TopunYonunuGeriDondur() * topHizi * Time.deltaTime;
    }
}
