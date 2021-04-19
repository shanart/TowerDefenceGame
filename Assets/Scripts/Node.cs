using UnityEngine;
using UnityEngine.EventSystems;


public class Node : MonoBehaviour
{

    public Color hoverColor;
    public Vector3 positionOffset;

    [Header("Optional")]
    public GameObject turret;    
    
    private Renderer rend;
    private Color startColor;
    BuildManager buildManager;
    
    void Start ()
    {
		rend = GetComponent<Renderer>();
		startColor = rend.material.color;
        buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffset;
    }

    // Press mouse btn while hovering on the object
    void OnMouseDown()
    {
        // Check if we realy hovering on the Node element
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (!buildManager.CanBuild)
            return;

        if (turret != null)
        {
            Debug.Log("Can't build there! - TODO: Display on screen");
            return;
        }

        // Build a turret
        buildManager.BuildTurretOn(this);
    }

    void OnMouseEnter()
    {
        // Check if we realy hovering on the Node element
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (!buildManager.CanBuild)
            return;

        rend.material.color = hoverColor;
    }

    void OnMouseExit ()
    {
        rend.material.color = startColor;
    }

   
}
