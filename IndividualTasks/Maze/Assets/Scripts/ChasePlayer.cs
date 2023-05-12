using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.AI;

public class ChasePlayer : MonoBehaviour
{
    public AudioSource audioSource;
    private NavMeshAgent myAgent;
    private Animator myAnimator;
    private float distance;
    public Transform target;

    void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
        myAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        distance = Vector3.Distance(target.position, transform.position);

        if (!Interaction.stopMob)
        {
            if (distance > 30f)
            {
                myAgent.enabled = false;
                myAnimator.Play("Idle");
                audioSource.Stop();
            }
            else if (distance < 7f)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            else
            {
                myAgent.enabled = true;
                myAgent.SetDestination(target.position);
                myAnimator.Play("Run");
                if (!audioSource.isPlaying)
                {
                    audioSource.Play();
                }
            }
        }
        else
        {
            StopPursuit();
        }

    }

    void StopPursuit()
    {
        if (Interaction.stopMob)
        {
            myAgent.enabled = false;
            myAnimator.Play("Idle");
            audioSource.Stop();
        }
    }

}





