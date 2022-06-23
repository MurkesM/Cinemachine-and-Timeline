using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class SpaceshipTakeOff : MonoBehaviour
{
    [SerializeField] PlayableDirector _director;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            _director.Play();
    }
}