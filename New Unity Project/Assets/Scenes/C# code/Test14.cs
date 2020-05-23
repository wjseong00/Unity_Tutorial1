using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class Dialogue
{
    [TextArea]
    public string dialogue;
    public Sprite cg;
}

public class Test14 : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite_standingCG;
    [SerializeField] private SpriteRenderer sprite_dialogueBox;
    [SerializeField] private Text txt_Dialogue;

    private bool isDialogue = false;

    private int count = 0;

    [SerializeField] private Dialogue[] dialogue;

    public void ShowDialogue()
    {
        OnOff(true);
        count = 0;
        NextDialogue();
    }
   
 
    private void OnOff(bool _flag)
    {
        sprite_dialogueBox.gameObject.SetActive(_flag);
        sprite_standingCG.gameObject.SetActive(_flag);
        txt_Dialogue.gameObject.SetActive(_flag);

        isDialogue = _flag;
    }

   
    private void NextDialogue()
    {
        txt_Dialogue.text = dialogue[count].dialogue;
        sprite_standingCG.sprite = dialogue[count].cg;
        count++;
    }
    // Update is called once per frame
    void Update()
    {
        if(isDialogue)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                if(count < dialogue.Length)
                {
                    NextDialogue();
                }
                else
                {
                    OnOff(false);
                }
            }
        }
    }
}
