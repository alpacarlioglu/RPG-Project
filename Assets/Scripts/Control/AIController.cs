using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Control
{
    public class AIController : MonoBehaviour
    {
        [SerializeField] private float chaseDistance = 5.0f;
        private GameObject player;

        private void Start()
        {
            player = GameObject.Find("Player");
        }

        private void Update()
        {
            if (DistanceToPlayer() < chaseDistance)
            {
                print(player.name + " chasig");
            }
        }

        private float DistanceToPlayer()
        {
             // Expensive
            return Vector3.Distance(player.transform.position, transform.position);
        }


    }

}