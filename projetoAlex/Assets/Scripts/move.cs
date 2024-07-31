using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.AI;
public class move : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform[] pontosDestinos;
    public int pontoCorrenteID;
    public float tempoParado;
    public float velocidadeRotacaoRoda;
    public GameObject[] mensagens;

    public bool isPainel;

    public bool isFinal;

    void Start()
    {
        tempoParado = 0;
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(pontosDestinos[0].position);
    }

    private void Update()
    {

        if (agent.remainingDistance < agent.stoppingDistance)
        {

            if (pontoCorrenteID == 2 && isPainel== false)
            {
                // tempoParado += Time.deltaTime;
                mensagens[0].SetActive(true);
                agent.isStopped = true;
                velocidadeRotacaoRoda = 0;
            }
            else if (pontoCorrenteID == 5 && isPainel)
            {
                tempoParado += Time.deltaTime;
                mensagens[1].SetActive(true);
                agent.isStopped = true;
                velocidadeRotacaoRoda = 0;
            }
            else if (pontoCorrenteID == 8 && isPainel==false)
            {
                tempoParado += Time.deltaTime;
                mensagens[2].SetActive(true);
                agent.isStopped = true;
                velocidadeRotacaoRoda = 0;
            }
            else if (pontoCorrenteID == 10  && isPainel)
            {
                tempoParado += Time.deltaTime;
                mensagens[3].SetActive(true);
                agent.isStopped = true;
                velocidadeRotacaoRoda = 0;
            }

            else if (pontoCorrenteID == 12 && isPainel==false)
            {
                tempoParado += Time.deltaTime;
                mensagens[4].SetActive(true);
                agent.isStopped = true;
                velocidadeRotacaoRoda = 0;

            }
            else 
            {
                pontoCorrenteID = (pontoCorrenteID + 1) % pontosDestinos.Length;
                agent.isStopped = false;

                tempoParado = 0;
                velocidadeRotacaoRoda = 1.5f;
            }           
           

        }
        agent.SetDestination(pontosDestinos[pontoCorrenteID].position);
    }
}
