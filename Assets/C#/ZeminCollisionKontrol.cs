using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminCollisionKontrol : MonoBehaviour
{
    [SerializeField] private Zemin zemin;

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Top"))
        {
            zemin.ZeminRbDegeri();
        }
    }
}
