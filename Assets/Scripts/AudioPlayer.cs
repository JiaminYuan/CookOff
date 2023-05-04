using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    bool m_Play;
    bool m_ToggleChange;
    AudioSource m_AudioSource;
    // Start is called before the first frame update
    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
        m_Play = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (m_Play == true && m_ToggleChange == true)
        {
            m_AudioSource.Play();
            m_ToggleChange = false; 
        }

        if (m_Play == false && m_ToggleChange == false)
        {
            m_AudioSource.Stop();
            m_ToggleChange = false;
        }
    }
}