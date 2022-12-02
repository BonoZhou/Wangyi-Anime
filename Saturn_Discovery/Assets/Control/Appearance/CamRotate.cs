// An highlighted block
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    public Transform target;//��ȡ��תĿ��
    private int speed = 2;
    private bool dragging = false;//�ж�����Ƿ��ڻ���
    private float MaxAngle = 150;//��ת���Ƕ�
    private float MinAngle = 100;//��ת��С�Ƕ�

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (dragging)
        {
            camerarotate();
        }
        camerazoom();
    }

    private void camerarotate()
    {
        var mouse_x = Input.GetAxis("Mouse X");//��ȡ���X���ƶ�
        var mouse_y = -Input.GetAxis("Mouse Y");//��ȡ���Y���ƶ�
        if (Vector3.Angle(transform.forward, Vector3.up) > MaxAngle && mouse_y > 0)
        {
            return;
        }
        if (Vector3.Angle(transform.forward, Vector3.up) < MinAngle && mouse_y < 0)
        {
            return;
        }
        if (Input.GetKey(KeyCode.Mouse1))
        {
            transform.Translate(Vector3.left * (mouse_x * 15f) * Time.deltaTime);
            transform.Translate(Vector3.up * (mouse_y * 15f) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            transform.RotateAround(target.transform.position, Vector3.up, mouse_x * speed);
            transform.RotateAround(target.transform.position, transform.right, mouse_y * speed);
        }
    }
    private void camerazoom() //�������������
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
            transform.Translate(Vector3.forward * 0.5f);
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
            transform.Translate(Vector3.forward * -0.5f);
    }
    void OnGUI()
    {
        dragging = false;
        if (Event.current.type == EventType.MouseDrag)
        {
            dragging = true;
        }
    }
}
