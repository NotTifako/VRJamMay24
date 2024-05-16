using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehave : MonoBehaviour
{
    void Start()
    {
        Invoke("DeleteSelf",10f);
    }

    void DeleteSelf()
    {
        Destroy(this.gameObject);
    }

    void OnCollisionEnter(Collision coll)
    {
        if(coll.gameObject.tag != "Gun")
        {
            Destroy(this.gameObject);
        }
    }

}
