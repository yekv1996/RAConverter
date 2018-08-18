using UnityEngine;
using UnityEngine.UI;


public class btnClick : MonoBehaviour
{
    ARConverter ARC;
    RAConverter RAC;

    public Transform panel;
    public Transform t1;
    public Transform t2;
    public InputField RomanInputField;
    public InputField ArabicInputField;

    bool check_Input;
    bool check_Info;

    public void btn_info_OnClick()
    {
        if (check_Info)
        {
            RectTransform panelRectTransform = panel.GetComponent<RectTransform>();
            panelRectTransform.sizeDelta = new Vector2(0, 0);
            RectTransform t1RectTransform = t1.GetComponent<RectTransform>();
            t1RectTransform.sizeDelta = new Vector2(0, 0);
            RectTransform t2RectTransform = t2.GetComponent<RectTransform>();
            t2RectTransform.sizeDelta = new Vector2(0, 0);
            check_Info = false;
        }
        else
        {
            RectTransform panelRectTransform = panel.GetComponent<RectTransform>();
            panelRectTransform.sizeDelta = new Vector2(150, 100);
            RectTransform t1RectTransform = t1.GetComponent<RectTransform>();
            t1RectTransform.sizeDelta = new Vector2(85, 85);
            RectTransform t2RectTransform = t2.GetComponent<RectTransform>();
            t2RectTransform.sizeDelta = new Vector2(85, 85);
            check_Info = true;
        }
    } 

    public void btn_OnClick()
    {
        ARC = gameObject.GetComponent("ARConverter") as ARConverter;
        RAC = gameObject.GetComponent("RAConverter") as RAConverter;
        if (check_Input == true)
            RomanInputField.text = ARC.ATRConvert(ArabicInputField.text);
        if(check_Input == false)
            ArabicInputField.text = RAC.RTAConvert(RomanInputField.text);
    }


    public void arabicIF_OnEndEdit()
    {        
        check_Input = true;        
    }
    public void romanIF_OnEndEdit()
    {
        check_Input = false;
    }
}

	

