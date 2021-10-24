using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour
{
    /**
     * �浹 ����
     * 1. ������ Rigibody �־�� �Ѵ�. (IsKinematic : off)
     * 2. ������ Collider�� �־�� �Ѵ� (IsTrigger : off)
     * 3. ������� Collider�� �־�� �Ѵ� (IsTrigger: off)
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
