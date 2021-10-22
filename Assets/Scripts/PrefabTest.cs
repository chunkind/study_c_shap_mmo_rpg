using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabTest : MonoBehaviour
{
    public GameObject prefab;

    GameObject tank;

    void Start()
    {
        //Resource Manager 사용전 코드
        //프리팹을 탱크로 설정
        //prefab = Resources.Load<GameObject>("Prefabs/Tank");
        //프리팹 생성 (Object 생략가능)
        //tank = Instantiate(prefab);
        //프리팹 삭제
        //Destroy(tank, 3.0f);

        //Resource Manager 사용후 코드
        tank = Managers.Resource.Instantiate("Tank");
        //Managers.Resource.Destroy(tank);

    }

}
