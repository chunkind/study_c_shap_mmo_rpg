using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabTest : MonoBehaviour
{
    public GameObject prefab;

    GameObject tank;

    void Start()
    {
        //�������� ��ũ�� ����
        prefab = Resources.Load<GameObject>("Prefabs/Tank");

        //������ ���� (Object ��������)
        tank = Instantiate(prefab);

        //������ ����
        Destroy(tank, 3.0f);
    }

}
