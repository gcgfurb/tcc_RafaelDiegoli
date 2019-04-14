﻿using UnityEngine;
using Vuforia;

public enum VirtualButtonType
{
    Button,
    CheckBox,
}

public class OptionVuforiaPlusBehaviour : OptionVuforiaBehaviour, IVirtualButtonEventHandler
{
    public Sprite PressedSprite;
    public GameObject VirtualButton;
    public VirtualButtonType ButtonType
    {
        get { return VirtualButtonType.Button; }
    }

    protected Sprite standyBySprite;

    protected void InternalStart()
    {
        VirtualButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        standyBySprite = GetComponent<SpriteRenderer>().sprite;
    }

    void Start()
    {
        InternalStart();
    }

    void Update()
    {
    }

    public virtual void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = PressedSprite;
    }

    public virtual void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = standyBySprite;
    }
}