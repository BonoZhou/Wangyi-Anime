using TMPro;
using UnityEngine;
using UnityEngine.UI;

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

    private Button btn55200;
    private Button btn4638;
    private Button btn9337;
    private Button btn9843;
    private Button btn4620;
    private Button btn4672;
    private Button btn4642;
    private Button btn4639;
    private Button btn4637;
    private Button btn4633;
    private Button btn4645;
    private Button btn4618;

    [SerializeField]
    TMP_Text text;

    /*
        private void Start()
        {
            text.text = "";
            btn55200 = GameObject.Find("55200").GetComponent<Button>();
            btn4638 = GameObject.Find("4638").GetComponent<Button>();
            btn9337 = GameObject.Find("9337").GetComponent<Button>();
            btn9843 = GameObject.Find("9843").GetComponent<Button>();
            btn4620 = GameObject.Find("4620").GetComponent<Button>();
            btn4672 = GameObject.Find("4672").GetComponent<Button>();
            btn4642 = GameObject.Find("4642").GetComponent<Button>();
            btn4639 = GameObject.Find("4639").GetComponent<Button>();
            btn4637 = GameObject.Find("4637").GetComponent<Button>();
            btn4633 = GameObject.Find("4633").GetComponent<Button>();
            btn4645 = GameObject.Find("4645").GetComponent<Button>();
            btn4618 = GameObject.Find("4618").GetComponent<Button>();

            btn55200.onClick.AddListener(on55200Click);
            btn4638.onClick.AddListener(on4638Click);
            btn9337.onClick.AddListener(on9337Click);
            btn9843.onClick.AddListener(on9843Click);
            btn4620.onClick.AddListener(on4620Click);
            btn4672.onClick.AddListener(on4672Click);
            btn4642.onClick.AddListener(on4642Click);
            btn4639.onClick.AddListener(on4639Click);
            btn4637.onClick.AddListener(on4637Click);
            btn4633.onClick.AddListener(on4633Click);
            btn4645.onClick.AddListener(on4645Click);
            btn4618.onClick.AddListener(on4618Click);

        }

        void on55200Click(){ text.text = intro[0]; }
        void on4638Click(){ text.text = intro[1]; }
        void on9337Click(){ text.text = intro[2]; }
        void on9843Click(){ text.text = intro[3]; }
        void on4620Click(){ text.text = intro[4]; }
        void on4672Click(){ text.text = intro[5]; }
        void on4642Click(){ text.text = intro[6]; }
        void on4639Click(){ text.text = intro[7]; }
        void on4637Click(){ text.text = intro[8]; }
        void on4633Click(){ text.text = intro[9]; }
        void on4645Click(){ text.text = intro[10]; }
        void on4618Click(){ text.text = intro[11]; }
    }
    */

    
        void Start()
        {
        }

        public void OnClick()
        {
        text.text = intro[11];
    }
    }
