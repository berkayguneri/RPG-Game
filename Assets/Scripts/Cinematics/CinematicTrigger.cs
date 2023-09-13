using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


namespace RPG.Cinematics
{
    public class CinematicTrigger : MonoBehaviour
    {
        bool alreadryTrigger = false;
        private void OnTriggerEnter(Collider other)
        {
            if (alreadryTrigger == false && other.gameObject.tag=="Player")
            {
                alreadryTrigger = true;
                GetComponent<PlayableDirector>().Play();
                GetComponent<BoxCollider>().enabled = false;
            }
            
        }

    }
}

