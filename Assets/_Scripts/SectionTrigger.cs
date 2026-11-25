using UnityEngine;

public class SectionTrigger : MonoBehaviour
{
    public WeightedRandomList<Transform> lootTable;
    public GameObject prefabsToSpawn;
    public float spawnLocationZ = 13.5f;

    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trigger"))
            Instantiate(prefabsToSpawn, new Vector3(0, 0, spawnLocationZ), Quaternion.identity);
    }
}
