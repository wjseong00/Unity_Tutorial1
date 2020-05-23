using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test16 : MonoBehaviour
{

    //[SerializeField] private LayerMask layerMask;
    [SerializeField] private GameObject go_BulletPrefab;
    //
    private float createTime =1f;
    private float currentCreatTime = 0;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //if(currentCreatTime >=createTime)
        //{
        //    currentCreatTime = 0f;
        //    RaycastHit hitInfo;
        //
        //    if (Physics.Raycast(this.transform.position, this.transform.forward, out hitInfo, 50f,layerMask))
        //    {
        //    
        //        if (hitInfo.transform.tag == "Player")
        //        {
        //            Instantiate(go_BulletPrefab, transform.position, Quaternion.LookRotation(hitInfo.transform.position - transform.position));
        //            Debug.Log(hitInfo.transform.name);
        //        }
        //        
        //    }
        //}

        Collider[] col = Physics.OverlapSphere(transform.position, 20f);
        if(col.Length>0)
        {
            for (int i = 0; i < col.Length; i++)
            {
                Transform tf_TarGet = col[i].transform;

                if(tf_TarGet.tag =="Player")
                {
                    Quaternion rotation = Quaternion.LookRotation(tf_TarGet.position - this.transform.position);
                    transform.rotation = rotation;
                    currentCreatTime += Time.deltaTime;
                    if (currentCreatTime >= createTime)
                    {
                        
                        GameObject _temp = Instantiate(go_BulletPrefab, transform.position, rotation);
                        Physics.IgnoreCollision(_temp.GetComponent<Collider>(), tf_TarGet.GetComponent<Collider>());
                        currentCreatTime = 0;
                    }

                        
                    

                }
            }
        }
    }
}
