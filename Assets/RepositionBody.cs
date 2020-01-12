using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepositionBody : MonoBehaviour
{

    [SerializeField] private Transform anchor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = anchor.position + (Vector3.down * 1.65f) + (Vector3.back * 0.1f);
    }
}
