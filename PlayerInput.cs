using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private Scorer _scorer;

    private ScorerController _scorerController;

    private void Awake()
    {
        _scorerController = new ScorerController();

        _scorerController.ScorerActionMap.Activating.performed += OnClick;
    }

    private void OnEnable()
    {
        _scorerController.Enable();
    }

    private void OnDisable()
    {
        _scorerController.Disable();
    }

    private void OnClick(InputAction.CallbackContext context)
    {
        Debug.Log("Click");
        _scorer.OnClick();
    }
}
