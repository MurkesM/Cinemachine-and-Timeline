using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class LightbulbChallenge : MonoBehaviour
{
    [SerializeField] PlayableDirector _director;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
            _director.enabled = true;
    }
}
