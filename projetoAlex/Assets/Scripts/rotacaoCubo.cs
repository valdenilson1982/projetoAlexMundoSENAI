using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacaoCubo : MonoBehaviour
{
    



    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(new Vector3(0,5,0)*Time.deltaTime);
    }
}
