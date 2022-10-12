// Script for cleaning up objects, that is already behind the visible scene. Objects are destroyed after selected time (in seconds).

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
