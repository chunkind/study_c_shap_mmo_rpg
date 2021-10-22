using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 1.위치 백터
// 2.방향 백터
struct MyVector
{
    public float x;
    public float y;
    public float z;

    /**
     *          +
     *     +    +
     * +--------+
     * 
     * 빗변제곱 = 밑변제곱 + 높이제곱
     */
    public float magnitude { get { return Mathf.Sqrt(x*x + y*y + z*z); } }
    public MyVector normalized { get { return new MyVector(x / magnitude, y / magnitude, z / magnitude); } }

    public MyVector(float x, float y, float z) { this.x = x; this.y = y; this.z = z; }

    public static MyVector operator + (MyVector a, MyVector b)
    {
        return new MyVector(a.x + b.x, a.y + b.y, a.z + b.z);
    }

    public static MyVector operator -(MyVector a, MyVector b)
    {
        return new MyVector(a.x - b.x, a.y - b.y, a.z - b.z);
    }

}

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float _speed = 10.0f;

    // GameObject (Player)
        // Transform
        // PlayerController (*)

    void Start()
    {
        MyVector to = new MyVector(10.0f, 0.0f, 0.0f);
        MyVector from = new MyVector(5.0f, 0.0f, 0.0f);
        MyVector dir = to - from; //-5.0f, 0.0f, 0.0f

        // 방향 백터
        // 1. 거리(크기)  5
        // 2. 실제 방향   ->

    }

    void Update()
    {
        // Local -> World
        // TransformDirection

        //World -> Local
        //InverseTransformDirection
        //transform.position.magnitude; => 백터의 크기 반환
        //transform.position.normalized; => 백터의 

        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);
            //transform.position += transform.TransformDirection(Vector3.forward * Time.deltaTime * _speed);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * Time.deltaTime * _speed);
            //transform.position += transform.TransformDirection(Vector3.back * Time.deltaTime * _speed);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * Time.deltaTime * _speed);
            //transform.position += transform.TransformDirection(Vector3.left * Time.deltaTime * _speed);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * Time.deltaTime * _speed);
            //transform.position += transform.TransformDirection(Vector3.right * Time.deltaTime * _speed);

    }
}
