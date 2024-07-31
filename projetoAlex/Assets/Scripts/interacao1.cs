using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class interacao1 : MonoBehaviour
{
    private bool isVerificarToque;




    public bool isMissao;

    private move _Move;
    // Start is called before the first frame update
    void Start()
    {
        _Move = FindObjectOfType(typeof(move)) as move;
    }

    // Update is called once per frame
    void Update()
    {
        if (isVerificarToque)
        {
            if (Input.GetButton("Fire1"))
            {
                _Move.isPainel = isMissao;

                this.gameObject.SetActive(false);

                Debug.Log(_Move.isPainel);

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