using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    readonly Vector3 localPosition = new Vector3(0.0f, 3.0f, -30.0f);

    private Camera cam;                     //���
    private Transform player;               //���
    private Transform watchPoint;           //ע��Ŀ���
    private GameObject stdObj;

    private float watchPointHeight = 0.1f;  //ע��Ŀ���߶�

    private float distance = 30f;           //��ǰ �������Ŀ������
    private float distanceMax = 50f;        //��Ŀ���������
    private float distanceMin = 8f;       //��Ŀ�����С����
    private float distanceSpeed = 3f;       //���������ٶ�

    private float rotationY;                //ˮƽ��ת
    private float rotationYSpeed = 1.5f;    //ˮƽ��ת�ٶ�

    private float AngleLerp;                //��ǰ��ֱ�Ƕ� ��ֵϵ��
    private float AngleMax = 80.0f;         //���ֱ�Ƕ�
    private float AngleMin = -40.0f;        //��С��ֱ�Ƕ�
    private float AngleSpeed = 0.02f;       //��ֱ��ת�ٶ�

    private Vector3 finalVec; //����ƫ������

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        stdObj = new GameObject();
        stdObj.transform.Rotate(0.0f, 180.0f, 0.0f);
        watchPoint = stdObj.transform;
        cam = gameObject.GetComponent<Camera>();
    }

    private void LateUpdate()
    {
        if (Input.GetMouseButton(1))
        {
            WheelChange();
            ChangeAngle();
            FinalCameraPos();
        }
        else
        {
            cam.transform.localPosition = localPosition * 40.0f / cam.fieldOfView;
            cam.transform.localRotation = new Quaternion();
            Destroy(stdObj);
            stdObj = new GameObject();
            stdObj.transform.Rotate(0.0f, 180.0f, 0.0f);
            watchPoint = stdObj.transform;
        }
    }

    private void WheelChange()
    {
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            distance += distanceSpeed;
            if (distance > distanceMax) distance = distanceMax;
        }
        else if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            distance -= distanceSpeed;
            if (distance < distanceMin) distance = distanceMin;
        }
    }

    private void ChangeAngle() //��ֱ��ת
    {
        rotationY = Input.GetAxis("Mouse X") * rotationYSpeed;
        watchPoint.Rotate(0, rotationY, 0);

        AngleLerp -= Input.GetAxis("Mouse Y") * AngleSpeed;

        if (AngleLerp > AngleMax / 90.0f) AngleLerp = AngleMax / 90.0f;
        else if (AngleLerp < AngleMin / 90.0f) AngleLerp = AngleMin / 90.0f;

        if (AngleLerp > 0) finalVec = Vector3.Lerp(-watchPoint.forward, watchPoint.up, AngleLerp);
        else finalVec = Vector3.Lerp(-watchPoint.forward, -watchPoint.up, -AngleLerp);
        finalVec.Normalize();
        finalVec *= distance * 40f / cam.fieldOfView;
    }

    private void FinalCameraPos()
    {
        Vector3 PointPos = player.position;
        PointPos.y += watchPointHeight;
        watchPoint.position = Vector3.Lerp(watchPoint.position, PointPos, 1.0f);

        Vector3 cameraPos = watchPoint.position + finalVec;
        transform.position = Vector3.Lerp(transform.position, cameraPos, 1.0f);
        transform.LookAt(watchPoint.position);
    }
}
