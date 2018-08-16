using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotatingSprite : MonoBehaviour {

    public bool enableRotation = false;
    public float rotationsPerSecond = 0.5f;

    private bool isRotationPositive = true;
    private SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start ()
    {
        this.spriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update ()
    {
        if (this.enableRotation)
        {
            var rotationSpeed = this.rotationsPerSecond * 360 * Time.deltaTime;
            rotationSpeed = this.isRotationPositive ? (rotationSpeed) : (-1 * rotationSpeed);

            this.transform.Rotate(0, 0, rotationSpeed);
        }
    }

    //void Update()
    //{
    //    if (this.enableRotation)
    //    {
    //        this.transform.Rotate(0, 0, this.rotationsPerSecond * 360 * Time.deltaTime);
    //    }
    //}

    //void Update()
    //{
    //    if (this.enableRotation)
    //    {
    //        this.transform.Rotate(0, 0, 360 * Time.deltaTime);
    //    }
    //}

    public void ToggleEnableRotation()
    {
        this.enableRotation = !this.enableRotation;
    }

    public void SetRotationDirectionClockwise(bool isOn)
    {
        if (isOn)
        {
            this.isRotationPositive = false;
        }
    }

    public void SetRotationDirectionCounterClockwise(bool isOn)
    {
        if (isOn)
        {
            this.isRotationPositive = true;
        }
    }

    public void SetRotationsPerSecond(float value)
    {
        this.rotationsPerSecond = value;
    }

    public void SetColor(int value)
    {
        switch (value)
        {
            case 0:
                this.spriteRenderer.color = Color.white;
                break;
            case 1:
                this.spriteRenderer.color = Color.red;
                break;
            case 2:
                this.spriteRenderer.color = Color.green;
                break;
            case 3:
                this.spriteRenderer.color = Color.blue;
                break;
            case 4:
                this.spriteRenderer.color = Color.yellow;
                break;

            default:
                this.spriteRenderer.color = Color.white;
                break;
        }
    }
}
