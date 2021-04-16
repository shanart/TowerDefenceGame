﻿using UnityEngine;

public class BuildManager : MonoBehaviour
{

    private GameObject turretToBuild;

    public static BuildManager instance;
    public GameObject standardTurretPrefab;
    public GameObject anotherTurretPrefab;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one BuildManager in scene!");
        }
        instance = this;
    }

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    public void SetTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }

}
