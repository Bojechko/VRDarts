using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] public int score = 5;
    [SerializeField] private float timeUntilDisappear = 1f;
    
    
    public static event Action AddScore;

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IDart dart))
        {
            dart.GetComponent<Rigidbody>().isKinematic = true;

            if (AddScore != null)
            {
                for (int i = 0; i < score; i++)
                {
                    AddScore();
                }
            }
        }
    }
}
