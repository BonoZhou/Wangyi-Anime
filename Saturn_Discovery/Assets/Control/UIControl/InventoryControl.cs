using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class InventoryControl : MonoBehaviour
{
    readonly Dictionary<string, string> intro = new Dictionary<string, string>
    {
      {"55200" , "ȼ�ϴ���:���ڴ���ȼ��"                                                             },
      {"4638" , "���˻���������ȼ��:�������ȼ�ϰ�"                                               },
      {"9337" , "���������ɺ�:�������Ͳ��õ��ķ�����"                                               },
      {"9843" , "Ǧ�����:���������������������ɺ�"                                                },
      {"4620" , "����:���²�����һ��"                                                            },
      {"4672" , "Ǧ��:��˵�������������䣬���ǵüӹ�һ��"                                           },
      {"4642" , "ȼ�ϰ� (�ݽ�MOX):�����ݽߵ�ȼ�ϰ���˵�������Դ�������ȡ��һЩԭ�ϣ����ǵ�С�ķ���" },
      {"4639" , "ȼ�ϰ�(�ݽ���):�����ݽߵ�ȼ�ϰ���˵�������Դ�������ȡ��һЩԭ�ϣ����ǵ�С�ķ���"   },
      {"4637" , "��:������ȼ�ϵ�ԭ��֮һ"                                                           },
      {"4633" , "��-238:������ȼ�ϵ�ԭ��֮һ"                                                       },
      {"4645" , "ȼ�ϰ�(MOX):ո�³����ĺ�ȼ�ϰ�"                                                    },
      {"4618" , "ȼ�ϰ�(��):�յ�ȼ�ϰ�" }
    };
    private Button btn;

    [SerializeField]
    TMP_Text text;


    // Start is called before the first frame update
    void Start()
    {

    }

    public void onLeftClick()
    {
        text.text = intro[gameObject.name];
    }


}



