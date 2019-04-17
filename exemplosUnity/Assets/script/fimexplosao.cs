using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fimexplosao : MonoBehaviour
{
    private Animator anim;
    public float TempoAnimacao;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        TempoAnimacao = anim.GetCurrentAnimatorStateInfo(0).length;
        Destroy(gameObject, TempoAnimacao);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
