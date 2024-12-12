using System;
using System.Collections;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] GameObject pipe;
    [SerializeField] private Character character;
    [SerializeField] private float height;
    [SerializeField] private float Time = 3.0f;
    
    Coroutine _spawnCoroutine;
    readonly WaitForSeconds waitForSeconds = new WaitForSeconds(3f);
    Vector3 spawnPos = new Vector3(14, 0, 0);

    private void Start()
    {
        _spawnCoroutine = StartCoroutine(Spawner());

    }
    
    
    private void Spawn()
    {
        spawnPos.y = UnityEngine.Random.Range(-height, height);
        Instantiate(pipe, spawnPos, Quaternion.identity);
    }
    
    IEnumerator Spawner()
    {
        while (!character.catIsDead)
        {
            Spawn();
            yield return waitForSeconds;
        }
        
    }


    #region On Disable and On Destroy
    
    private void OnDisable()
    {
        
        if (_spawnCoroutine != null)
        {
            StopCoroutine(_spawnCoroutine);
            _spawnCoroutine = null;
        }
    }

    private void OnDestroy()
    {
        if (_spawnCoroutine != null)
        {
            StopCoroutine(_spawnCoroutine);
            _spawnCoroutine = null;
        }
    }

    #endregion

}
