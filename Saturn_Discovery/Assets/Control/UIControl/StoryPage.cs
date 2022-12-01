using System.Threading;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoryPage : MonoBehaviour
{
    readonly string[] storyText = {
        "13��ǰ�����������ĸ��������򷴶Ե�������������������λ�ں����ǵ���άҮ������...",
        "������䣬�¼ţ��տ������Ǳ���ÿ�칤��14СʱΪ���ֿ��ɺ������ϱ�Ҫ����׶���븻�ѿ����֧�ŵ���λ�ڵأ����������յ���ǻ����ǵĽ�������...",
        "��������������֮�伸���������κ������ϵĹ�ͨ�������ڶ��������Ѿ����������˵һ�������Ļ�...",
        "������ǰ��һ��żȻ�Ļ��ᣬ�����������Ľ�̸���˽⵽���������������ڷֱ����������������಻���ķ�������ս����...",
        "�����ڸոգ�Ҳ����12Сʱǰ���ҳÿ��ز�ע�⣬������һ�����������Ǽʷɴ������޷��˵������������ź����ǣ�����Ĺ����У�΢�����ʼ������汻���ˣ��˶���ȼ��Ҳ��ʣ�޼����ұ����ҵ�һ���ط��������㹻��ȼ��...",
        "����ʱ�����ǳ�����..."
    };

    private int pageOrder;
    [SerializeField]
    private TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        pageOrder = 0;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = storyText[pageOrder];
        if(Input.GetMouseButtonUp(0)) 
        {
            pageOrder++;
        }
        if (pageOrder == storyText.Length)
        {
            SceneManager.LoadScene("OutdoorsScene");
        }
    }
}
