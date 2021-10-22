using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float _speed = 10.0f;
    void Start()
    {
        
    }

    float _yAngle = 0;

    void Update()
    {
        _yAngle += Time.deltaTime * 100;

        //주의 : 아래와 같이는 사용하면 안된다 360가 넘어갈수 있기 때문
        //transform.eulerAngles += new Vector3(0.0f, Time.deltaTime * 100.0f, 0.0f);

        // 1.절대 회전값 지정
        //transform.eulerAngles = new Vector3(0.0f, _yAngle, 0.0f);

        // 1. +,- delta 값 기준으로 특정값 회전
        //transform.Rotate(new Vector3(0.0f, Time.deltaTime * 100, 0.0f));

        //transform.rotation = Quaternion.Euler(new Vector3(0.0f, _yAngle, 0.0f));

        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 0.2f);
            //transform.Translate(Vector3.forward * Time.deltaTime * _speed);
        }   
        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 0.2f);
            //transform.Translate(Vector3.back * Time.deltaTime * _speed);
        }   
        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 0.2f);
            //transform.Translate(Vector3.left * Time.deltaTime * _speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 0.2f);
            //transform.Translate(Vector3.right * Time.deltaTime * _speed);
        }
            
    }
}
