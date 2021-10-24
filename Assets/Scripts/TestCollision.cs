using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour
{
    /**
     * 충돌 조건
     * 1. 나한테 Rigibody 있어야 한다. (IsKinematic : off)
     * 2. 나한테 Collider가 있어야 한다 (IsTrigger : off)
     * 3. 상대한테 Collider가 있어야 한다 (IsTrigger: off)
     */
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision !");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger !");
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
