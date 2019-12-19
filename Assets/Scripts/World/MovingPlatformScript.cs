using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformScript : MonoBehaviour
{
    Transform Platform;

    public Vector3 pos1;
    public Vector3 pos2;
    private Vector3 NewPos;

    public string CurrentState;

    public float smooth;
    public float velocity;
    public float resetTime;

    // Start is called before the first frame update
    void Start()
    {
        Platform = GetComponent<Transform>();
        transform.position = pos1;

        changeTarget();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Platform.position = Vector3.Lerp(Platform.position, NewPos, smooth * Time.deltaTime);
    }

    public void changeTarget()
    {
        if(CurrentState == "1")
        {
            CurrentState = "2";
            NewPos = pos2;
        }else if (CurrentState == "2")
        {
            CurrentState = "1";
            NewPos = pos1;
        }
        else if(CurrentState == "")
        {
            CurrentState = "2";
            NewPos = pos2;
        }
        Invoke("changeTarget",resetTime);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(pos1, 1);
        Gizmos.DrawWireSphere(pos2, 1);
        Gizmos.DrawLine(pos1, pos2);
    }
}
