using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboarding : MonoBehaviour
{
    private Camera cam;

    private void Awake()
    {
        cam = Camera.main;

        transform.forward = cam.transform.forward;
    }

    private void Update()
    {
        transform.forward = cam.transform.forward;
    }
}
