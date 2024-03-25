using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zemin : MonoBehaviour
{
    [SerializeField] private ZeminDusmeKontrol zeminDusmeKontrol;

    public void ZeminRbDegeri()
    {
        StartCoroutine(zeminDusmeKontrol.RbAyarlari());
    } 
}
