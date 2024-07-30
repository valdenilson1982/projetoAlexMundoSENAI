using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;
using UnityEngine.SceneManagement;

public class interacao2 : MonoBehaviour
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
                SceneManager.LoadScene("SampleScene");

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