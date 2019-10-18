using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    Vector3 setPos;
    // Start is called before the first frame update
    void Start()
    {
        setPos = transform.position;
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Respawn")
        {
            transform.position = setPos;
        }
    }
}
