using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowHero : MonoBehaviour
{
    public float speed;
    private Transform target;
    void start()
    {
       target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
       transform.position = Vector2.MoveTowards(transform.position, target.position, speed*Time.deltaTime); 
    }
}
