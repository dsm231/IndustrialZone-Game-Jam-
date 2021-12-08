using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyborgAttack : MonoBehaviour
{
   public Animator animator;
   public Transform attackPoint;
   public float attackRange = 0.5f;
   public LayerMask enemyLayers;
//    public float attackRate = 100f;
//    float nextAttackTime = 0f;

   void Update(){

    //    if(Time.time >= nextAttackTime){
       if(Input.GetMouseButton(0)){
           Attack();
           //nextAttackTime = Time.time + 1f/attackRate;
       }
       //}
       

   }

   void Attack(){
       //attack animation
       animator.SetBool("attack",true);
       //Detect enemies in range of attack
       Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
       //Damage them
       foreach(Collider2D enemy in hitEnemies){
           enemy.GetComponent<Postion_enemy>().TakeDamage(50);
       }


       
   }

    void OnDrawGizmosSelected(){
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);

    }


}
