using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arm_flring : MonoBehaviour
{
    [Tooltip("腕が飛んでいく距離")]
    [SerializeField] float flringdistance = 10.0f;
    [Tooltip("腕が飛んでいく速度")]
    [SerializeField] float flringspeed = 10.0f;
    [Tooltip("距離分飛んだあと一瞬止まる時間")]
    [SerializeField] float flringstop = 10.0f;

    private float distance;

    // Start is called before the first frame update
    public void FlringStart()
    {
        Vector3 forward = this.gameObject.transform.forward;
        Debug.Log(forward);
    }


}
