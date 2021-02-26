using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyMace : MonoBehaviour
{

        [SerializeField] private float amplitude = 2;
       

    private Vector3 startPos;

    void Start()
    {
      
        startPos = transform.position;
    }

    void Update()
    {
    
        transform.position = startPos + amplitude * new Vector3(0f, Mathf.Sin(Time.time), 0f);
    }
}
