using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabTest : MonoBehaviour
{
    public GameObject prefab;

    GameObject tank;

    void Start()
    {
        //프리팹 생성 (Object 생략가능)
        tank = Object.Instantiate(prefab);

        //프리팹 삭제
        Destroy(tank, 3.0f);
    }

}
