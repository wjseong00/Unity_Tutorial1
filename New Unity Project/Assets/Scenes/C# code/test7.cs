using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test7 : MonoBehaviour
{
    private Animation anim;

    private Animation clip;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            //anim.Play("cube1");
            //anim.PlayQueued("cube2");
            anim.Blend("cube2");
            //anim.CrossFade("cube2");
            //if(!anim.IsPlaying("cube2"))
            //{
            //    anim.Play("cube2");
            //}
            //anim.Stop();
            //
            //anim.clip = clip;
        }
    }
}
