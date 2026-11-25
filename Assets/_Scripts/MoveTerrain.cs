using UnityEngine;

public class MoveTerrain : MonoBehaviour
{
    [SerializeField] private float speed = -4f;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, speed) * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Destroy"))
            Destroy(gameObject);
    }
}
