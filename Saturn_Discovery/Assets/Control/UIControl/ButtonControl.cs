using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonControl : MonoBehaviour
{
    readonly string[] intro =
    {
        "ȼ�ϴ���:���ڴ���ȼ��",
        "���˻���������ȼ��:�������ȼ�ϰ�",
        "���������ɺ�:�������Ͳ��õ��ķ�����",
        "Ǧ�����:���������������������ɺ�",
        "����:���²�����һ��",
        "Ǧ��:��˵�������������䣬���ǵüӹ�һ��",
        "ȼ�ϰ� (�ݽ�MOX):�����ݽߵ�ȼ�ϰ���˵�������Դ�������ȡ��һЩԭ�ϣ����ǵ�С�ķ���",
        "ȼ�ϰ�(�ݽ���):�����ݽߵ�ȼ�ϰ���˵�������Դ�������ȡ��һЩԭ�ϣ����ǵ�С�ķ���",
        "��:������ȼ�ϵ�ԭ��֮һ",
        "��-238:������ȼ�ϵ�ԭ��֮һ",
        "ȼ�ϰ�(MOX):ո�³����ĺ�ȼ�ϰ�",
        "ȼ�ϰ�(��):�յ�ȼ�ϰ�",
    };

    [SerializeField]
    TMP_Text text;

    void Start()
    {
    }

    public void OnClick()
    {
        text.text = intro[11];
    }
}
