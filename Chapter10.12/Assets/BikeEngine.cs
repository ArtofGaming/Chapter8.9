using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeEngine : MonoBehaviour, IBikeElement
{
    public float turboBoost = 25.0f;
    public float maxTurboBoost = 200.0f;
    private bool _isTuboOn;
    private float _defaultSpeed = 300.0f;

    public float CurrentSpeed { get { if (_isTuboOn) { return _defaultSpeed + turboBoost; } return _defaultSpeed; } }

    public void ToggleTurbo()
    {
        _isTuboOn = !_isTuboOn;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    void OnGUI()
    {
        GUI.color = Color.green;
        GUI.Label(new Rect(125, 20, 200, 20), "Turbo Boost: " + turboBoost);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
