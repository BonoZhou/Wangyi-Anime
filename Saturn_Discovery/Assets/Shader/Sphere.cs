using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    private Vector3 centerPos;    //��Χ���Ǹ��� ����˭�ĽǶ�
    private float radius = 3;     //������ centerPos�ľ���
    private float angle = 0;      //ƫ�ƽǶ�  

    void Start()
    {
        CreateSphere();
    }


    public void CreateSphere()
    {
        centerPos = transform.position;
        //20������һ��Բ
        for (int i = 0; i < 1000; i++)
        {
            Vector3 p = Random.insideUnitSphere * radius;
            Vector3 pos = p.normalized * (2 + p.magnitude);

            GameObject obj1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            //���������λ��Vector3���������ֱ����x,y,z��������  
            obj1.transform.position = pos;
        }
    }
}