using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenas : MonoBehaviour
{
    public void cena1()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void cena2()
    {
        SceneManager.LoadScene("SampleSceneControle 2");
    }
}
