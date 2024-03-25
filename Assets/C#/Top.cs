using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Top : MonoBehaviour
{
    [SerializeField]
    private TopKontrolleri topKontrolleri;

    private Rigidbody rb;

    public Vector3 TopunYonunuGeriDondur()
    {
        return topKontrolleri.topYon;
    }

    private void Update()
    {
        if (transform.position.y <= -10)
        {
            SceneManager.LoadScene(0);
        }
    }
}
