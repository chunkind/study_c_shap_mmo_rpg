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
        // Local <-> World <-> Viewport <-> Screen(화면)
        // Debug.Log(Input.mousePosition); //Screen 좌표 (픽셀좌표)
        // Camera.main.ScreenToViewportPoint(Input.mousePosition); //viewport 좌표(픽셀비율 좌표)

    }
}
