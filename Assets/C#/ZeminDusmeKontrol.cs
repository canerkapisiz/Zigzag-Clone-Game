using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminDusmeKontrol : MonoBehaviour
{
    private Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public IEnumerator RbAyarlari()
    {
        yield return new WaitForSeconds(0.75f);
        rb.isKinematic = false;
        rb.useGravity = true;
    }
}
