using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosao : MonoBehaviour
{
   
    public GameObject expl;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(expl, transform.position, Quaternion.identity);
            Destroy(this.gameObject);

        }
    }
}
