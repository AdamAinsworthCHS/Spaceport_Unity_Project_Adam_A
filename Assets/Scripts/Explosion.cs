using UnityEngine;

public class Explosion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public ParticleSystem self;
    public AudioClip explosionSoundEffect;
    private AudioSource explosionAudio;

    void Start()
    {
        explosionAudio = GetComponent<AudioSource>();
        explosionAudio.PlayOneShot(explosionSoundEffect, 1.0f);
        self.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
