using UnityEngine;

public class Node : MonoBehaviour
{

    public Color hoverColor;

    private Renderer rend;
    private Color startColor;
    private bool hovered = false;
    
    void Start ()
    {
		rend = GetComponent<Renderer>();
		startColor = rend.material.color;
    }

    void OnMouseEnter()
    {
        rend.material.color = hoverColor;
        hovered = true;
    }

    void OnMouseExit ()
    {
        rend.material.color = startColor;
        hovered = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && hovered == true) 
        {
            Debug.Log("Pressed primary button.");
        }

    }
}
