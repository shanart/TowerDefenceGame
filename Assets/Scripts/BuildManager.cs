using UnityEngine;

public class BuildManager : MonoBehaviour
{

    private TurretBlueprint turretToBuild;

    public static BuildManager instance;
    public GameObject standardTurretPrefab;
    public GameObject missileLauncherPrefab;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one BuildManager in scene!");
        }
        instance = this;
    }

    public TurretBlueprint GetTurretToBuild()
    {
        return turretToBuild;
    }

    public void SelectTurretToBuild(TurretBlueprint turret)
    {
        turretToBuild = turret;
    }

}
