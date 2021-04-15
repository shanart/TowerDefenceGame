using UnityEngine;

public class Node : MonoBehaviour
{

    public Color hoverColor;
    public Vector3 positionOffset;
    private GameObject turret;    
    private Renderer rend;
    private Color startColor;
    
    void Start ()
    {
		rend = GetComponent<Renderer>();
		startColor = rend.material.color;
    }

    // Press mouse btn while hovering on the object
    void OnMouseDown()
    {
        if (turret != null)
        {
            Debug.Log("Can't build there! - TODO: Display on screen");
            return;
        }

        // Build a turret
        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
    }

    void OnMouseEnter()
    {
        rend.material.color = hoverColor;
        Debug.Log("OnMouseEnter");
    }

    void OnMouseExit ()
    {
        rend.material.color = startColor;
    }

   
}
