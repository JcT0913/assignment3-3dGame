using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyMovement : MonoBehaviour
{
    public GameObject[] guidePoints;
    public NavMeshAgent enemy;
    // public float dist2Target;
    private int currentGuideIndex = 0;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        enemy.SetDestination(guidePoints[currentGuideIndex].transform.position);
    }

    // Update is called once per frame
    /*
    void Update()
    {
        
    }
    */

    private void FixedUpdate()
    {
        if (enemy.remainingDistance <= 0.5f)
        {
            currentGuideIndex += 1;
            if (currentGuideIndex == guidePoints.Length)
            {
                currentGuideIndex = 0;
            }
            enemy.SetDestination(guidePoints[currentGuideIndex].transform.position);
        }

        /*
        RaycastHit hit;
        Ray ray = new Ray(transform.position, guidePoints[currentGuideIndex].transform.position - transform.position);

        if (Physics.Raycast(ray, out hit) && hit.collider.tag == "GuidePoint")
        {
            enemy.SetDestination(guidePoints[currentGuideIndex].transform.position);
        }
        */
    }
}
