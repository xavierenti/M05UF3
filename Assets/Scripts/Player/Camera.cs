using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private Vector3 offset = new Vector3(0, 0, -10);
    private float smothTime = 0.25f;
    private Vector3 velocity = Vector3.zero;

    [SerializeField] private Transform target;
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 targetPosirion = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosirion, ref velocity, smothTime);

    }
}
