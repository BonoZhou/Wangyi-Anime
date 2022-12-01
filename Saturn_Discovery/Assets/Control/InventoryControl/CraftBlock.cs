using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftBlock : MonoBehaviour
{
    private string ID = "";

    [SerializeField]
    CraftBlock nextbutton;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ID != "")
        {
            gameObject.GetComponent<Button>().image.sprite = GameObject.Find(ID).GetComponent<Button>().image.sprite;//����ͼƬ
        }
        else
        {
            gameObject.GetComponent<Button>().image.sprite = null;
        }
    }
    public bool filled()
    {
        if (ID != "") return true;
        else return false;
    }
    public int fill(string IDinput)//1��ɹ����룬0��δ�ɹ�
    {
        if (!filled())
        {
            ID = IDinput;
            return 1;
        }
        else if (nextbutton) return nextbutton.fill(IDinput);
        else return 0;
    }
    public void unfill()//�˻���Ʒ
    {
        if(filled())
        {
            GameObject.Find("InventoryPanel").GetComponent<InventoryManager>().addnum(ID,1);
            ID = "";

        }

    }
    
    public int getID()
    {
        if (ID == "") return 0;
        else return int.Parse(ID);
    }

    public void Craft()//ʹ����Ʒ��������
    {
        if(ID == "4620")//�Ǵ���
        {
            unfill();
        }
        else
        {
            ID = "";
        }
    }


    void OnLeftClick()
    {
        if (filled())
            unfill();
    }
}
