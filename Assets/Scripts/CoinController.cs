using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    [SerializeField]
    private int rotationSpeed = 500; // D�nme h�z�

    void Update()
    {
        // Nesneyi kendi ekseni etraf�nda d�nd�rme
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
