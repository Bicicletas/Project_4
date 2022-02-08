using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody playerRigidbody;
    [SerializeField]private float speed = 10f;
    private GameObject focalPoint;

    private bool hasPowerUp = false;
    private float powerUpForce = 65f;

    public GameObject[] forceArmour;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        playerRigidbody.AddForce(focalPoint.transform.forward * speed * verticalInput);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PowerUp"))
        {
            Destroy(other.gameObject);
            hasPowerUp = true;
            StartCoroutine(PowerUpCountDown());
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (hasPowerUp && collision.gameObject.CompareTag("Enemy"))
        {
            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position).normalized;
            enemyRigidbody.AddForce(awayFromPlayer * powerUpForce, ForceMode.Impulse);
        }
    }
    private IEnumerator PowerUpCountDown()
    {
        for (int i = 0; i < forceArmour.Length; i++)
        {
            forceArmour[i].SetActive(true);
            yield return new WaitForSeconds(2);
            forceArmour[i].SetActive(false);
        }
        yield return new WaitForSeconds(6);
        hasPowerUp = false;
    }
}
