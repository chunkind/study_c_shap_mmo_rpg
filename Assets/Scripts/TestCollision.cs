using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour
{
    /**
     * OnCollisionEnter �߻� ����
     * 1. �� Ȥ�� ������� Rigibody �־�� �Ѵ�. (IsKinematic : off)
     * 2. ������ Collider�� �־�� �Ѵ� (IsTrigger : off)
     * 3. ������� Collider�� �־�� �Ѵ� (IsTrigger: off)
     */
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision @ {collision.gameObject.name} !");
    }

    /**
     * OnTriggerEnter �߻� ����
     * 1. �� �� Collider�� �־�� �Ѵ�.
     * 2. �� �� �ϳ��� isTrigger : On
     * 3. �� �� �ϳ��� RigidBody�� �־�� �Ѵ�.
     */
    private void OnTriggerEnter(Collider other)
    {
        
        Debug.Log("Trigger @ {other.gameObject.name} !");
    }

    void Start()
    {
        
    }

    void Update()
    {
        

        Vector3 look = transform.TransformDirection(Vector3.forward);
        Debug.DrawRay(transform.position + Vector3.up, look * 10, Color.red);

        //raycast ���� �տ� �ѹ�ü��
        /*RaycastHit hit;
        if (Physics.Raycast(transform.position + Vector3.up, look, out hit, 10))
        {
            Debug.Log("Raycast {hit.collider.gameObject.name} !");
        }*/


        //raycast ��繰ü
        RaycastHit[] hits;
        hits = Physics.RaycastAll(transform.position + Vector3.up, look, 10);
        foreach(RaycastHit h in hits)
        {
            Debug.Log($"Raycast {h.collider.gameObject.name}");
        }

        
    }
}
