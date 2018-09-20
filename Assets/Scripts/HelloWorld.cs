using System.Collections;
using System.Collections.Generic;
using UnityEngine;  // You need this for every monobehavior

/// <summary>
/// A Hello World script with some basic execution order stuff
/// 
/// Check out the docs here: 
/// https://docs.unity3d.com/Manual/ExecutionOrder.html
/// </summary>
public class HelloWorld : MonoBehaviour
{

    #region Fields

    // Private fields don't show up in the editor!
    private float TestFoat = 0.0f;

    // Public floats do! 
    public float TestPublicFloat = 10.0f;

    // If you want to FORCE a private var to show up in the editor, you can use ...
    [SerializeField]
    private float PrivateSerializedFloat = 15.0f;

    #endregion

    #region Methods

    private void Awake()
    {
        // Awake happens first
        TestFoat += 2.0f;
    }

    private void OnEnable()
    {
        // Enable happens next
        // here you can hook into some events or delegates, stuff like that
        PrivateSerializedFloat += 10.0f;
    }

    
    private void Start ()
    {
        // Use this for initialization
        Debug.Log("Hello world!");
        TestPublicFloat -= 2.0f;

        // Example of getting a component
        // Animator anim = GetComponent<Animator>();
    }

    private void Update ()
    {
		// Update game logic here! Called once per frame
	}

    private void FixedUpdate()
    {
        // Put physics things in this update loop!
    }

    private void LateUpdate()
    {
        // This happens after update, you can edit things like camera movement here 
        // if it is dependant on where other objects are
    }

    private void OnDisable()
    {
        // On disable is where you can remove any event / delegate hooks
    }

    private void OnDestroy()
    {
        // last thing to happen to this game obejct
    }

    #endregion

}
