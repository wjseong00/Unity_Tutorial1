﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test16_2 : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float damage;
    // Start is called before the first frame update
    void Start()
    {
       


    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.transform.name + "에게 데미지 " + damage + "을 입혔습니다.");
        Destroy(this.gameObject);
    }



    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
