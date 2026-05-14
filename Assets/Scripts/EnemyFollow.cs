using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    [SerializeField] private List<GameObject> allTargets;
    private Transform target;
    private NavMeshAgent agent;

    private void Awake()
    {
        agent= GetComponent<NavMeshAgent>();
        StartCoroutine(CheckTarget());
    }

    IEnumerator CheckTarget()
    {
        while (true)
        {

            target = allTargets[Random.Range(0, allTargets.Count)].transform;

            agent.SetDestination(target.position);
            while (Vector3.Distance(transform.position, target.position) > 1.5f)
            {
                yield return null;
            }
            yield return new WaitForSeconds(Random.Range(2f, 5f));

        }

    }

}
