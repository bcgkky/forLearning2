using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class agents : MonoBehaviour
{
    NavMeshAgent agent;
    public GameObject[] hedefler;
    int mevcuthedef;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        mevcuthedef = 0;
    }

    void Update()
    {
        agent.SetDestination(hedefler[mevcuthedef].transform.position);
    }

    void OnTriggerEnter(Collider other)
    {
        if (mevcuthedef == 0)
        {
            mevcuthedef = 1;
            agent.SetDestination(hedefler[mevcuthedef].transform.position);
        }
        else if (mevcuthedef == 1)
        {
            mevcuthedef = 2;
            agent.SetDestination(hedefler[mevcuthedef].transform.position);
        }
        else if (mevcuthedef == 2)
        {
            mevcuthedef = 3;
            agent.SetDestination(hedefler[mevcuthedef].transform.position);
        }

        else if (mevcuthedef == 3)
        {
            mevcuthedef = 4;
            agent.SetDestination(hedefler[mevcuthedef].transform.position);
        }

        else if (mevcuthedef == 4)
        {
            mevcuthedef = 5;
            agent.SetDestination(hedefler[mevcuthedef].transform.position);
        }

        else if (mevcuthedef == 5)
        {
            mevcuthedef = 6;
            agent.SetDestination(hedefler[mevcuthedef].transform.position);
        }

        else if (mevcuthedef == 6)
        {
            mevcuthedef = 7;
            agent.SetDestination(hedefler[mevcuthedef].transform.position);
        }
        else
        {
            mevcuthedef = 0;
            agent.SetDestination(hedefler[mevcuthedef].transform.position);
        }
    }
}
