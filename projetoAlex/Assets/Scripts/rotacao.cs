using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacao : MonoBehaviour
{
    private move _move;// Start is called before the first frame update
    void Start()
    {
        _move = FindObjectOfType(typeof(move))as move;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(_move.velocidadeRotacaoRoda, 0, 0);
    }
}
