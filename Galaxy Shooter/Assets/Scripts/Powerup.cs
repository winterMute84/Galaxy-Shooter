﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    [SerializeField] private float _speed = 3.0f;

    [SerializeField] private int powerupId;

    void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Enable triple Shot
        if (other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();

            if (player != null)
            {
                if (powerupId == 0)
                    player.TriplePowerShotOn();
                else if (powerupId == 1)
                    player.HyperSpeedOn();

            }

            //Destroy powerup
            Destroy(this.gameObject);
        }

    }
}