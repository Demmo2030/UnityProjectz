using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class AudioPlayerActions : MonoBehaviour
{
    public EventReference Footsteps;
    FMOD.Studio.EventInstance playerFootstep;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AudioPlayerStep()
    {
        playerFootstep = RuntimeManager.CreateInstance(Footsteps);
        playerFootstep.start();
    }
}
