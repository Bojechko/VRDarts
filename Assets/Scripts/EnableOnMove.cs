using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableOnMove : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbody;
    private Vector3 freezPos = Vector3.zero;

    private void OnTriggerEnter(Collider other)
    {
        freezPos = rigidbody.position;
    }

    private void Update()
    {
        if ((rigidbody.isKinematic == true) &&(rigidbody.position != freezPos))
        {
            rigidbody.isKinematic = false;
        }
    }
}
