using UnityEngine;

namespace Intro
{
    public class AudioSourceEditor : MonoBehaviour
    {
        [SerializeField]
        private AudioSource audio;

        public AudioSource anotherAudio;

        private AudioSource evenOtherAudio;

        private AudioSource oneMoreAudio;

        private void Awake()
        {
            evenOtherAudio = GetComponent(typeof(AudioSource)) as AudioSource;
            oneMoreAudio = GetComponent<AudioSource>();
        }

        void Update()
        {
            //TODO: Do something
        }
    }
}