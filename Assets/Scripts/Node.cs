﻿using UnityEngine;
using UnityEngine.EventSystems;


public class Node : MonoBehaviour
{

    public Color hoverColor;
    public Vector3 positionOffset;
    private GameObject turret;    
    private Renderer rend;
    private Color startColor;
    BuildManager buildManager;
    
    void Start ()
    {
		rend = GetComponent<Renderer>();
		startColor = rend.material.color;
        buildManager = BuildManager.instance;
    }

    // Press mouse btn while hovering on the object
    void OnMouseDown()
    {
        // Check if we realy hovering on the Node element
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (buildManager.GetTurretToBuild() == null)
            return;

        if (turret != null)
        {
            Debug.Log("Can't build there! - TODO: Display on screen");
            return;
        }

        // Build a turret
        GameObject turretToBuild = buildManager.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
    }

    void OnMouseEnter()
    {
        // Check if we realy hovering on the Node element
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (buildManager.GetTurretToBuild() == null)
            return;

        rend.material.color = hoverColor;
    }

    void OnMouseExit ()
    {
        rend.material.color = startColor;
    }

   
}
