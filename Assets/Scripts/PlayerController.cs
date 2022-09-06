using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Vector3 direction;

    public ParticleSystem confettiParticle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Food")
        {
            confettiParticle.transform.position = other.transform.position;
            confettiParticle.Play();

            Destroy(other.gameObject);
            ScoreController.instance.Score += 2;

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            direction = new Vector3(direction.x == 0 ? 1 : 0, 0, direction.z == 0 ? 1 : 0);

            ScoreController.instance.Score++;
        }

        transform.position += direction * Time.deltaTime * speed;

        if (transform.position.y < 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
