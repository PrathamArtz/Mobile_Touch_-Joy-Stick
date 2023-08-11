using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    [SerializeField]
    public float speed = 40.0f;
    public GameObject player;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
     //   transform.Translate( Vector3.forward * Time.deltaTime * speed);
     transform.position = player.transform.position;
    }
}
