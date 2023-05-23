using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SquirrelMovement : MonoBehaviour
{
    public float jumpForce = 5f;
    public float raycastDistance = 1.5f;

    private NavMeshAgent agent;
    private bool isJumping;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (!isJumping)
                {
                    if (hit.collider.CompareTag("Food"))
                    {
                        JumpToPosition(hit.point);
                    }
                    else if (NavMesh.SamplePosition(hit.point, out NavMeshHit navHit, raycastDistance, NavMesh.AllAreas))
                    {
                        MoveToPosition(navHit.position);
                    }
                }
            }
        }
    }

    private void MoveToPosition(Vector3 position)
    {
        agent.SetDestination(position);
    }

    private void JumpToPosition(Vector3 position)
    {
        Vector3 direction = (position - transform.position).normalized;
        direction.y = jumpForce;

        GetComponent<Rigidbody>().AddForce(direction, ForceMode.Impulse);
        isJumping = true;

        agent.enabled = false;

        Invoke(nameof(EnableAgent), 1f);
    }

    private void EnableAgent()
    {
        agent.enabled = true;
        isJumping = false;
    }
}
