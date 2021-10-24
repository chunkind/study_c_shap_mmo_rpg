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
        // Local <-> World <-> Viewport <-> Screen(ȭ��)
        // Debug.Log(Input.mousePosition); //Screen ��ǥ (�ȼ���ǥ)
        // Camera.main.ScreenToViewportPoint(Input.mousePosition); //viewport ��ǥ(�ȼ����� ��ǥ)

        //Tag�� ���� ������Ʈ ã��
        //GameObject.FindGameObjectWithTag

        if (Input.GetMouseButtonDown(0))
        { //0�� :  ���ʸ��콺

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Debug.DrawRay(Camera.main.transform.position, ray.direction * 100.0f, Color.red, 1.0f);


            //old
            //int mask = (1<<8 | (1<<9));

            //new
            LayerMask mask = LayerMask.GetMask("Monster","Wall");

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100.0f, mask))
            {
                //Debug.Log($"Raycast Camera @ {hit.collider.gameObject.name}");
                Debug.Log($"Raycast Camera @ {hit.collider.gameObject.tag}");
            }
        }

    }
}
