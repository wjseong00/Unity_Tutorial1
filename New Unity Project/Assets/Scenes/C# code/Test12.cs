using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Test12 : MonoBehaviour
{
    [SerializeField] private Text txt_Money;
    [SerializeField] private InputField inputTxt_Money;

    private int currentMondey;
    public void Input()
    {
        currentMondey += int.Parse(inputTxt_Money.text);

        txt_Money.text = currentMondey.ToString();
    }

    public void Output()
    {
        currentMondey -= int.Parse(inputTxt_Money.text);

        txt_Money.text = currentMondey.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
