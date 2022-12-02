using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AddItem : MonoBehaviour
{
    Dictionary<string, string> lis = new Dictionary<string, string>
    {
        { "btnEnceladus","4672" },              //����Ǧ��
        { "btnMimas","4642" },                   //�����ݽ�MOX��
        { "btnTethys","4639" },                  //�����ݽ��˰�
        { "btnDione","4618" },                  //�����հ�
        { "btnRhea","4672" },                  //����Ǧ��
    };

    Dictionary<string, int> numlis = new Dictionary<string, int>
    {
        { "btnEnceladus",20 },              //����Ǧ��
        { "btnMimas",5 },                   //�����ݽ�MOX��
        { "btnTethys",10 },                  //�����ݽ��˰�
        { "btnDione",5 },                  //�����հ�
        { "btnRhea",20 },                  //����Ǧ��
    };

    string ID;

    InventoryManager Inv;

    [SerializeField]
    TMP_Text snum;


    int num;

    // Start is called before the first frame update
    void Start()
    {
        ID = gameObject.name;//��ȡ��ǰbutton��ID
        num = numlis[ID];
    }

    // Update is called once per frame
    void Update()//ʵʱ��ʾʣ������
    {
        gameObject.GetComponent<Button>().image.sprite = GameObject.Find(lis[ID]).GetComponent<Button>().image.sprite;//����ͼƬ
        snum.text = num.ToString();
    }

    public void Click()
    {

        Inv = GameObject.Find("InventoryPanel").GetComponent<InventoryManager>();
        if (num > 0)
        {
            num--;
            Inv.addnum(lis[ID], 1);
        }

    }
}
