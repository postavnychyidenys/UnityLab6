﻿using UnityEngine;

public class Move3 : MonoBehaviour {

    public GameObject goal;
    Vector3 direction;
    public float speed;

    void Start() {

    }

    private void LateUpdate()
    {
        direction = goal.transform.position - this.transform.position;
        this.transform.LookAt(goal.transform.position);
        if (direction.magnitude > 1.5)
        {
            Vector3 velocity = direction.normalized * speed * Time.deltaTime;
            this.transform.position = this.transform.position + velocity;
        }
    }
}
