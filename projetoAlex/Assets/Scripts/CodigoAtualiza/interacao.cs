using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interacao : MonoBehaviour
{
    private bool isVerificarToque;
    public int indexMissoes;
    private controleBasico _carroPersonalizado;

    void Start()
    {
        _carroPersonalizado = FindObjectOfType(typeof(controleBasico)) as controleBasico;
    }

    void Update()
    {
        if (isVerificarToque)
        {
            if (Input.GetButton("Fire1"))
            {
                _carroPersonalizado.indexMissoes = indexMissoes;

                this.gameObject.SetActive(false);
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