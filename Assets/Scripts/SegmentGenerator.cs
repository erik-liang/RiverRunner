using UnityEngine;
using System.Collections.Generic;

public class SegmentGenerator : MonoBehaviour
{
    public GameObject[] segmentTemplates;
    public Transform player;
    public float spawnDistanceAhead = 500f;
    public float deleteDistanceBehind = 60f;
    public int segmentLength = 50;
    private float nextSpawnZ = 50f;
    private List<GameObject> activeSegments = new List<GameObject>();

    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            SpawnSegment();
        }
    }

    void Update()
    {
        if (player.position.z + spawnDistanceAhead > nextSpawnZ)
        {
            SpawnSegment();
        }

        if (activeSegments.Count > 0)
        {
            GameObject oldest = activeSegments[0];
            if (player.position.z - oldest.transform.position.z > deleteDistanceBehind + segmentLength)
            {
                Destroy(oldest);
                activeSegments.RemoveAt(0);
            }
        }
    }


    void SpawnSegment()
    {
        int index = Random.Range(0, segmentTemplates.Length);
        GameObject newSegment = Instantiate(segmentTemplates[index], new Vector3(0, 0, nextSpawnZ), Quaternion.identity);
        newSegment.SetActive(true); 
        activeSegments.Add(newSegment);
        nextSpawnZ += segmentLength;
        }

    IEnumerator SegmentGen() {
        segmentNum = Random.Range(0, 8);
        Instantiate(segment[segmentNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 50;
        yield return new WaitForSeconds(3);
        creatingSegment = false;

    }
}
