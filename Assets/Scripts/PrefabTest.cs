using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabTest : MonoBehaviour
{
    public GameObject prefab;

    GameObject tank;

    void Start()
    {
        //Resource Manager ����� �ڵ�
        //�������� ��ũ�� ����
        //prefab = Resources.Load<GameObject>("Prefabs/Tank");
        //������ ���� (Object ��������)
        //tank = Instantiate(prefab);
        //������ ����
        //Destroy(tank, 3.0f);

        //Resource Manager ����� �ڵ�
        tank = Managers.Resource.Instantiate("Tank");
        //Managers.Resource.Destroy(tank);

    }

}
