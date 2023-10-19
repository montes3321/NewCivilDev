using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonReaction : MonoBehaviour
{
    public TMP_InputField input;
    public Button butt;
    public string code;
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;
    public GameObject obj6;
    public GameObject obj7;
    public GameObject obj8;
    public GameObject obj9;
    public GameObject obj10;
    public GameObject obj11;
    public GameObject obj12;
    public GameObject obj13;
    public GameObject obj14;
    public GameObject obj15;
    public GameObject obj16;
    public GameObject obj17;
    public GameObject obj18;

    void Start()
    {
        Button btn = butt.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
//moneyCounter.SetText(moneyValue.ToString()
        code = input.text.ToString();
        Debug.Log(code);
        Changer(code);
    }
    void Changer(string code){
        switch (code){
            case "tugi32":
                obj1.SetActive(true);
                break;
            case "fi4293":
                obj2.SetActive(true);
                break;
            case "f239r2":
                obj3.SetActive(true);
                break;
            case "ivsme3":
                obj4.SetActive(true);
                break;
            case "033ff2":
                obj5.SetActive(true);
                break;
            case "39f341":
                obj6.SetActive(true);
                break;
            case "cfl134":
                obj7.SetActive(true);
                break;
            case "130f31":
                obj8.SetActive(true);
                break;
            case "azp123":
                obj9.SetActive(true);
                break;
            case "f0xv1a":
                obj10.SetActive(true);
                break;
            case "1240zz":
                obj11.SetActive(true);
                break;
            case "vapfe1":
                obj12.SetActive(true);
                break;
            case "vdsp13":
                obj13.SetActive(true);
                break;
            case "38cqe3":
                obj14.SetActive(true);
                break;
            case "39f143":
                obj15.SetActive(true);
                break;
            case "31czz3":
                obj16.SetActive(true);
                break;
            case "zpfq31":
                obj17.SetActive(true);
                break;
            case "9r48c1":
                obj18.SetActive(true);
                break;
            default:
                break;
        }
    }
}
