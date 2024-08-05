using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controleBasico : MonoBehaviour
{
    public GameObject[] mensagens;
    private Animator anim;
    public int indexMissoes;
    public bool[] missoes;
    public bool start;
    public bool fimMissaoRestart;
    void Start()
    {
        anim = GetComponent<Animator>(); 
        
       
    }

    // Update is called once per frame
    void Update()
    {
        if (indexMissoes == 10 && missoes[0] == false)
        {
            mensagens[0].SetActive(true);

            missoes[0] = true;

          
        }else 

        if (indexMissoes == 1 && missoes[1]==false)
        {
            
            trecho1();
            missoes[1] = true;
          
        }
        if (indexMissoes == 2 && missoes[2] == false)
        {

            trecho2();
            missoes[2] = true;
        }
        else
        if (indexMissoes == 3 && missoes[3] == false)
        {

            trecho3();
            missoes[3] = true;
        }else
        if (indexMissoes == 4 && missoes[4] == false)
        {

            trecho4();
            missoes[4] = true;
        }else

        if (indexMissoes == 5 && missoes[5] == false)
        {

            trecho5();
            missoes[5] = true;
        }
        else
        if (indexMissoes == 6 && missoes[6] == false)
        {

            trecho6();
            missoes[6] = true;
        }else
        if (indexMissoes == 7 && missoes[7] == false)
        {
            SceneManager.LoadScene("SampleScene 5");
        }
        
    }

    public void fimMissao1()
    {
        mensagens[1].SetActive(true);       
    }

    public void fimMissao2()
    {
        mensagens[2].SetActive(true);
    }
    public void fimMissao3()
    {
        mensagens[3].SetActive(true);
    }

    public void fimMissao4()
    {
        mensagens[4].SetActive(true);
    }

    public void fimMissao5()
    {
        mensagens[5].SetActive(true);
    }

    public void fimMissao6()
    {
        mensagens[6].SetActive(true);

    }



    public void trecho1()
    {
        anim.SetTrigger("trecho1");
    }
    public void trecho2()
    {
        anim.SetTrigger("trecho2");
        missoes[7] = false;
    }

    public void trecho3()
    {
        anim.SetTrigger("trecho3");
    }

    public void trecho4()
    {
        anim.SetTrigger("trecho4");
    }

    public void trecho5()
    {
        anim.SetTrigger("trecho5");
    }

    public void trecho6()
    {
        anim.SetTrigger("trecho6");
        
    }

    public void retorno()
    {
        anim.SetTrigger("retorna");
    }
}
