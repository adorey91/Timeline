using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineTrigger : MonoBehaviour
{
    public PlayableDirector timeline;

    public bool OneTimeTrigger = false; // true = this trigger will self destruct after one use.

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            timeline.Play();

            // only use if you want to have an event that only triggers once
            if (OneTimeTrigger == true)
            {
                Destroy(this.gameObject);
            }

        }
    }
}
