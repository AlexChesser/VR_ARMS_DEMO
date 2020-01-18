using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepositionBody : MonoBehaviour
{

    [SerializeField] private Transform anchor;
    [SerializeField] private float down;
    [SerializeField] private float back;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = anchor.position + (Vector3.down * down) + (Vector3.back * back);
    }
}
