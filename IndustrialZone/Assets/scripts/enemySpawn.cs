using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn  : MonoBehaviour {
    // enemy Prefab
    public GameObject enemy1;

    // Borders
    // public Transform borderTop;
    // public Transform borderBottom;
    // public Transform borderLeft;
    // public Transform borderRight;

    // Use this for initialization
    void Start () {
        // Spawn food every 4 seconds, starting in 3
        InvokeRepeating("Spawn", 3, 4);
    }

    // Spawn one piece of food
    void Spawn() {
        // // x position between left & right border
        // int x = (int)Random.Range(borderLeft.position.x,
        //                           borderRight.position.x);

        // // y position between top & bottom border
        // int y = (int)Random.Range(borderBottom.position.y,
        //                           borderTop.position.y);

        // Instantiate the food at (x, y)
        float x= (int)3.26; float y = (int)3.27;
        Instantiate(enemy1,
                    new Vector2(x, y),
                    Quaternion.identity); // default rotation

        float a= (int)-4.79; float b = (int)3.27;
        Instantiate(enemy1,
                    new Vector2(a, b),
                    Quaternion.identity); // default rotation            

                   
    }
}
