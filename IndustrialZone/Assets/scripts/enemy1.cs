using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1: MonoBehaviour
{
      private float speed=12f;
      public Animator animator;
      

      private bool movingRight = true;

      public Transform groundDetection;

      void Update()
      {
      transform.Translate(Vector2.right*speed*Time.deltaTime);
      
      
      RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position,Vector2.down,1f);
      //if(groundDetection.CompareTag("tilemap"))
      //{
      if(groundInfo.collider== false)
      {
        if(movingRight==true)
        {
          transform.eulerAngles = new Vector3(0,-180,0);
          movingRight=false;
        } else {
          transform.eulerAngles = new Vector3(0,0,0);
          movingRight=true;
        }
      }
      animator.SetFloat("Speed", 4f);
      }
      //}
      


      private void OnCollisionEnter2D(Collision2D collision)
      {
       if(collision.gameObject.GetComponent<Cyborg>()!= null)
       {
        Cyborg cyborg = collision.gameObject.GetComponent<Cyborg>();
        cyborg.KillPlayer();  
        //Destroy(gameObject); 
       }
      }}
