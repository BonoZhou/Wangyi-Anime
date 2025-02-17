using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    Dictionary<string, int> Inv = new Dictionary<string, int>
{
    {"55200" , 1},
    {"4638" , 0},
    {"9337" , 0},
    {"9843" , 0},
    {"4620" , 1},
    {"4672" , 0},
    {"4642" , 0},
    {"4639" , 0},
    {"4637" , 0},
    {"4633" , 0},
    {"4645" , 0},
    {"4618" , 0}
};
    Button btn;

    [SerializeField]
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void changenum(string ID, int num)
    {
        Inv[ID] = num;
        GameObject.Find(ID).GetComponent<InventoryControl>().updatenum(num);
        
    }

    void addnum(string ID, int num)
    {
        Inv[ID] += num;
        GameObject.Find(ID).GetComponent<InventoryControl>().updatenum(num);
    }
    int  minusnum(string ID, int num)
    {
        if (Inv[ID] > num)
        {
            Inv[ID] -= num;
            GameObject.Find(ID).GetComponent<InventoryControl>().updatenum(num);
            return 0;
        }
        else return 1;
    }
}