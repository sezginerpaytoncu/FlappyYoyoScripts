using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public CatController catStatus;
    public GameObject Pipes;
    public float maxHeight;
    public float minHeight;
    public float time;

    private void Start(){
        StartCoroutine(SpawnObject(time));
    }

    public IEnumerator SpawnObject(float time) //creating pipes
    {
        while (!catStatus.isDead){
            Instantiate(Pipes, new Vector3(1, Random.Range(minHeight, maxHeight), 0), Quaternion.identity); //Quaternion: rotation value // .identity means the same as prefab
            yield return new WaitForSeconds(time);
        }
    }
}