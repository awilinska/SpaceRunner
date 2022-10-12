using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanUp : MonoBehaviour
{
    public float clean;
    void Start()
    {
        Destroy(gameObject, clean);
    }
}
