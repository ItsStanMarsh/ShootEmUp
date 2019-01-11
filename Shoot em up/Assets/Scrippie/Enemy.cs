using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {



    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("TRIGGEREEEEDDDDD");
        // manager
        Manager manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<Manager>();
        manager.EnemyDead();

        // destroy itself
        Destroy(this.gameObject);
    }
}
