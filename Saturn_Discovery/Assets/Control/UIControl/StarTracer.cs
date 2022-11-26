using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarTracer : MonoBehaviour
{
    [SerializeField]
    GameObject worldPos;//3D���壨���
    [SerializeField]
    RectTransform rectTrans;//UIԪ�أ��磺Ѫ���ȣ�
    public Vector2 offset;//ƫ����

    // Update is called once per frame
    void Update()
    {
        Vector2 screenPos = Camera.main.WorldToScreenPoint(worldPos.transform.position);
        rectTrans.position = screenPos + offset;
    }
}
