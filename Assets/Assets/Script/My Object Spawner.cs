using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class MyObjectSpawner : ObjectSpawner
{
    [Header("My Object Spawner")]
    [SerializeField] private GameObject objectSpawn;

    private GameObject _spawned;
    protected override bool CustomSpawmnGameObject(Vector3 spawnPoint, Vector3 spawnNormal)
    {
        if(_spawned != null){
            return true;
        }

        _spawned = Instantiate(objectSpawn);
        _spawned.transform.position = spawnPoint;
        return true;
    }
}
