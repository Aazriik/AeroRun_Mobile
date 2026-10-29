using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Variables

    [SerializeField] float moveSpeed = 2.0f;
    

    #endregion

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
    }
}
