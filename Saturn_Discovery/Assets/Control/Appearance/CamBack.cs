using UnityEngine;


public class CamBack : MonoBehaviour
{

    public GameObject zoomCam;
    public GameObject mainCam;

    private void Update() //ͨ�������ͬ�İ���ʵ��������л�
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            zoomCam.SetActive(false);
            mainCam.SetActive(true);
            GameObject.FindGameObjectWithTag("NEAR").SetActive(false);
        }
    }
}

