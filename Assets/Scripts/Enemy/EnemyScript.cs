using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    public string EnemyType;
    public float Damage;

    Transform playerTransform;
    UnityEngine.AI.NavMeshAgent myNavMesh;
    public float Radius;
    public float checkRate;
    float nextcheck;


    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.FindGameObjectWithTag("Player").activeInHierarchy)
        {
            playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        }

        myNavMesh = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextcheck)
        {
            nextcheck = Time.time + checkRate;
            FollowPlayer();
        }
    }

    void FollowPlayer()
    {
        float PlayerDistance = Vector3.Distance(playerTransform.position, transform.position);

        if (PlayerDistance < Radius)
        {
            myNavMesh.transform.LookAt(playerTransform);
            myNavMesh.destination = playerTransform.position;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, Radius);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
         //   other.gameObject.GetComponent<PlayerStats>().TakeDamage(Damage);
        }
    }
}
