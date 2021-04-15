using UnityEngine;

public class BuildManager : MonoBehaviour
{
    
    private GameObject turretToBuild;

    public static BuildManager instance;
    public GameObject standardTurretPrefab;

    void Awake()
    {
        if ( instance != null)
        {
            Debug.LogError("More than one BuildManager in scene!");
        }
        instance = this;
    }

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    void Start() 
    {
        turretToBuild = standardTurretPrefab;
    }

}
