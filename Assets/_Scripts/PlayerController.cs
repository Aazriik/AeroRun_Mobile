
using UnityEngine;
using DG.Tweening;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour, PlayerControls.IPlayerActions
{
    #region Variables

    [Header("References")]
    private Rigidbody rb;

    PlayerControls input;

    [Header("Movement")]
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    [SerializeField] float playerSpeed = 2.0f;
    [SerializeField] float gravityValue = -9.81f;
    private bool isGrounded = true;
    // Movement and Tilt.
    private Vector2 movement = Vector2.zero;
    private Vector2 tilting = Vector2.zero;
    // Tilting.
    public float forwardTiltForce;
    public float turnTiltForce;
    // Hover and Tilt Counters.
    public float tiltCounter = 22f;
    public float hoverCounter = 13f;

    // Menu References.
    // public GameObject pauseMenu;
    // bool isPaused = false;

    #endregion

    #region Enable/Disable Action Maps
    private void OnEnable()
    {
        input.Enable();
        input.Player.AddCallbacks(this);
    }

    private void OnDisable()
    {
        input.Player.RemoveCallbacks(this);
        input.Disable();
    }

    #endregion

    private void Awake()
    {
        //playerInput = new Player();
        rb = GetComponent<Rigidbody>();
        // bool isPaused = pauseMenu.activeInHierarchy;
    }

    #region Start & Updates
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    protected void FixedUpdate()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed, Space.World);
    }

    #endregion


    #region InputAction Callbacks

    public void OnMove(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnPrevious(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnNext(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }
    #endregion
}
