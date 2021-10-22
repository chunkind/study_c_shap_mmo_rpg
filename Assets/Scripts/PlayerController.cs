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

        // 1. +,- delta 값 기준으로 특정값 회전
        //transform.Rotate(new Vector3(0.0f, Time.deltaTime * 100, 0.0f));

        //transform.rotation = Quaternion.Euler(new Vector3(0.0f, _yAngle, 0.0f));

        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 0.2f);
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);
        }   
        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 0.2f);
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);
        }   
        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 0.2f);
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 0.2f);
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);
        }
            
    }
}
