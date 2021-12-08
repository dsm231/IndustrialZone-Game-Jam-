using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cyborg : MonoBehaviour
{
  public float speed; 
  private Rigidbody2D rb2d;
  public float jump;
  public Animator animator;

  private void Awake()
    {
    Debug.Log("Player controller awake");   
    rb2d= gameObject.GetComponent<Rigidbody2D>(); 
    }
    public void KillPlayer()
    {
      animator.SetBool("Death",true);
    }
  private void Update()
    {
        

        float vertical = Input.GetAxisRaw("Jump");
        bool attack = Input.GetMouseButton(0); 
        float horizontal = Input.GetAxisRaw("Horizontal");
        
        PlayMovementAnimation(horizontal,vertical);
        MoveCharacter(horizontal, vertical);    
        if(attack)
        {
        animator.SetBool("attack",true);  
        }
        else
        {
        animator.SetBool("attack",false);  
        }
    }

    private void MoveCharacter(float horizontal, float vertical)
    {
      //move character horizontally 
      
      
      
      Vector3 position = transform.position;
      position.x = position.x + horizontal * speed * Time.deltaTime;
      transform.position = position;
      
      //move character vertically
      
      
       //if(Ground)
       //{
         if(vertical>0)
         {
        rb2d.AddForce(new Vector2(0f,jump),ForceMode2D.Force);
         }
      // }

    
    }

    private void PlayMovementAnimation(float horizontal, float vertical)
    {
        animator.SetFloat("Speed", Mathf.Abs(horizontal));
         Vector3 scale = transform.localScale;
        if (horizontal < 0)
        {
            scale.x = -1f* Mathf.Abs(scale.x);
            //scale.x=-1;
        }
        else if (horizontal > 0)
        {
            scale.x = Mathf.Abs(scale.x);
            //scale.x = 1;
        }
        transform.localScale = scale;

        //Jump
        if (vertical > 0 )
        {
            animator.SetBool("jump", true);
        }
        else
        {
            animator.SetBool("jump", false);
        }

        
          


    }

}
