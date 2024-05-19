using UnityEngine;

namespace Slingshots
{
    [RequireComponent(typeof(LineRenderer))]
    public class Strip : MonoBehaviour
    {
        [SerializeField] private Transform target = null!;
        private LineRenderer lineRenderer = null!;
        private const int PointCount = 2;
        private const int StartPoint = 0;
        private const int EndPoint = 1;
        [SerializeField] private AudioClip audioClip = null;
        private AudioSource audioSource = null;
        private bool isPlaying = false; 

        private void Awake()
        {
            lineRenderer = GetComponent<LineRenderer>()!;
            audioSource = GetComponent<AudioSource>()!;
            lineRenderer.positionCount = PointCount;
            lineRenderer.SetPosition(StartPoint, transform.position);
        }

        private void Update()
        {
            lineRenderer.SetPosition(EndPoint, target.position);

            if (Input.GetMouseButtonDown(0))
            {
                if (!isPlaying)
                {
                    audioSource.clip = audioClip;
                    audioSource.Play();
                    isPlaying = true;
                }
            }
           
            else if (Input.GetMouseButtonUp(0))
            {
                audioSource.Stop();
                isPlaying = false;
            }
        }
    }
}