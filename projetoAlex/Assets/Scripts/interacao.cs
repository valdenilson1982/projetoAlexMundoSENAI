using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interacao : MonoBehaviour
{
    private bool isVerificarToque;
    private Animator anim;
    public string nomeAnimacao;

    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isVerificarToque)
        {
            if (Input.GetButton("Fire1"))
            {

                anim.SetTrigger(nomeAnimacao);


            }
        }

    }

    private void OnMouseDown()
    {
        isVerificarToque = true;
    }

    private void OnMouseExit()
    {
        isVerificarToque = false;
    }
}