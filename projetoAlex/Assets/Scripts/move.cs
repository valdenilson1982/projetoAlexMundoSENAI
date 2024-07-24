using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class move : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform[] pontosDestinos;
    private int pontoCorrenteID;
    public float tempoParado;
    public float velocidadeRotacaoRoda;

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

            if (pontoCorrenteID == 2 && tempoParado < 5)
            {
                tempoParado += Time.deltaTime;
                agent.isStopped = true;
                velocidadeRotacaoRoda = 0;
            }
            else if (pontoCorrenteID == 5 && tempoParado < 5)
            {
                tempoParado += Time.deltaTime;
                agent.isStopped = true;
                velocidadeRotacaoRoda = 0;
            }
            else if (pontoCorrenteID == 8 && tempoParado < 5)
            {
                tempoParado += Time.deltaTime;
                agent.isStopped = true;
                velocidadeRotacaoRoda = 0;
            }

            else if (pontoCorrenteID == 12 && tempoParado < 5)
            {
                tempoParado += Time.deltaTime;
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

            agent.SetDestination(pontosDestinos[pontoCorrenteID].position);

        }
    }
}
