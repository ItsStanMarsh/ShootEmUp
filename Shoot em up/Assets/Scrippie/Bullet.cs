using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    float speed = 4f;

	void Update () {

        transform.position += new Vector3(speed, 0, 0) * Time.deltaTime; 

	}
}
