using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RpgAdventure
{
    public class BanditBehaviour : MonoBehaviour
    {
        public float detedtionRadius = 10.0f;

        private void Update()
        {
            LookForPlayer();
        }

        private PlayerController LookForPlayer()
        {
            if (PlayerController.Instance == null)
            {
                return null;
            }

            Vector3 enemyPosition = transform.position;
            Vector3 toPlayer = PlayerController.Instance.transform.position - enemyPosition;
            toPlayer.y = 0;

            if (toPlayer.magnitude <= detedtionRadius)
            {
                Debug.Log("Detecting the player!");
            }
            else
            {
                Debug.Log("Where are you?");
            }

            return null;
        }
    }



}


