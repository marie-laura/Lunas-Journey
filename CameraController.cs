using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    
    [SerializeField] private Transform cat;

    // Update is called once per frame
    private void Update()
    {
        transform.position = new Vector3(cat.position.x, cat.position.y, transform.position.z);
    }
}
