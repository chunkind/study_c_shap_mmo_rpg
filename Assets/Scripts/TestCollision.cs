using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour
{
    /**
     * OnCollisionEnter 발생 조건
     * 1. 나 혹은 상대한테 Rigibody 있어야 한다. (IsKinematic : off)
     * 2. 나한테 Collider가 있어야 한다 (IsTrigger : off)
     * 3. 상대한테 Collider가 있어야 한다 (IsTrigger: off)
     */
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision @ {collision.gameObject.name} !");
    }

    /**
     * OnTriggerEnter 발생 조건
     * 1. 둘 다 Collider가 있어야 한다.
     * 2. 둘 중 하나는 isTrigger : On
     * 3. 둘 중 하나는 RigidBody가 있어야 한다.
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

        //raycast 제일 앞에 한물체만
        /*RaycastHit hit;
        if (Physics.Raycast(transform.position + Vector3.up, look, out hit, 10))
        {
            Debug.Log("Raycast {hit.collider.gameObject.name} !");
        }*/


        //raycast 모든물체
        RaycastHit[] hits;
        hits = Physics.RaycastAll(transform.position + Vector3.up, look, 10);
        foreach(RaycastHit h in hits)
        {
            Debug.Log($"Raycast {h.collider.gameObject.name}");
        }

        
    }
}
