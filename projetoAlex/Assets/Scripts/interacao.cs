using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interacao : MonoBehaviour
{
    private bool isVerificarToque;




    public int indexMissoes;

    private CarroPersonalizado _carroPersonalizado;
    // Start is called before the first frame update
    void Start()
    {
        _carroPersonalizado = FindObjectOfType(typeof(CarroPersonalizado)) as CarroPersonalizado;
    }

    // Update is called once per frame
    void Update()
    {
        if (isVerificarToque)
        {
            if (Input.GetButton("Fire1"))
            {
                _carroPersonalizado.indexMissoes = indexMissoes;

                Debug.Log(_carroPersonalizado.indexMissoes);

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