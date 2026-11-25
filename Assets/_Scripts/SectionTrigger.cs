using UnityEngine;

public class SectionTrigger : MonoBehaviour
{
    public GameObject roadSection;
    public float spawnLocationZ = 13.5f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trigger"))
            Instantiate(roadSection, new Vector3(0, 0, spawnLocationZ), Quaternion.identity);
    }
}
