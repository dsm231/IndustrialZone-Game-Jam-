using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Postion_enemy : MonoBehaviour
{
    [SerializeField]
    public float speed;
    public Vector3[] positions; 
    private int index;
    private int maxHealth =100;
    int currentHealth;
    //private float dazedTime;
    //public float startDazedTime;
    public GameObject BloodSplash;

    void Start(){
        currentHealth = maxHealth;
    }
    


    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,positions[index],Time.deltaTime*speed);
        if(transform.position == positions[index])
        {
            if(index== positions.Length-1)
            {
                index =0;
                transform.eulerAngles = new Vector3(0,0,0);
            }
            else
            {
                index++;
                transform.eulerAngles = new Vector3(0,-180,0);
            }
        }

    //     if(dazedTime <=0){
    //     speed = 2;} else {
    //     speed=0;
    //     dazedTime -= Time.deltaTime;
    // }

    }

    

    public void TakeDamage(int damage){
        //dazedTime = startDazedTime;
        currentHealth -= damage;
        if(currentHealth<=0){
        Instantiate(BloodSplash, transform.position, Quaternion.identity );
        Destroy(gameObject);    
        Debug.Log("enemy died");
        }

    }
}
