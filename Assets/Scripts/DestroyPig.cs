using Assets.Scripts;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Unity.VisualScripting.Member;

public class DestroyPig : MonoBehaviour
{
    [SerializeField]
    private GameObject explosion;
    private Rigidbody2D rb;
    [SerializeField] private CameraShakes cameraShakes;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnDestroy()
    {
        GameObject[] pigs = GameObject.FindGameObjectsWithTag("Pig");
        if (pigs.Length == 0)
        {
            Debug.Log($"All pigs are dead");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Borb")
        {
            cameraShakes.Shake();   
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(rb.gameObject);

        }

    }
  
}