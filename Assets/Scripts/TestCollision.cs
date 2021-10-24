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

    }
}
