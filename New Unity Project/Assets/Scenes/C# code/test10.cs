using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class test10 : MonoBehaviour
{
    [SerializeField] private Text txt_name;
    [SerializeField] private Image img_name;\
    [SerializeField] private Sprite sprite;

    private bool isCoolTime = false;

    private float currentTime = 5f;
    private float delayTime = 5f;

    private void Update()
    {

        //img_name.sprite = ;
        Color color = img_name.color;
        color.a = 0f;
        img_name.color = color;

        if(isCoolTime)
        {
            currentTime -= Time.deltaTime;
            img_name.fillAmount = currentTime /delayTime;
            if(currentTime <=0)
            {
                isCoolTime = false;
                currentTime = delayTime;
                img_name.fillAmount = currentTime;
            }
        }
    }

    // Start is called before the first frame update
    public void Change()
    {
        txt_name.text = "변경됨";
        isCoolTime = true;
        //img_name.fillAmount = 0.5f;
    }
}
