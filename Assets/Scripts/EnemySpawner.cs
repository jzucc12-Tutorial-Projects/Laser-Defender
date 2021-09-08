using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] List<WaveConfig> waveConfigs;
    [SerializeField] int startingWave = 0;
    [SerializeField] bool looping = false;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        do
        {
            yield return StartCoroutine(SpawnAllWaves());
        } while (looping);
    }

    private IEnumerator SpawnAllWaves()
    {
        for(var ii = startingWave; ii < waveConfigs.Count; ii++)
        {
            var currentWave = waveConfigs[ii];
            yield return StartCoroutine(spawnAllEnemiesInWave(currentWave));
        }
    }

    private IEnumerator spawnAllEnemiesInWave(WaveConfig waveConfig)
    {
        for(int ii = 0; ii < waveConfig.GetnumberOfEnemies(); ii++)
        {
            var newEnemy = Instantiate(waveConfig.GetEnemyPrefab(),
                           waveConfig.GetWaypoints()[0].transform.position,
                           Quaternion.identity);

            newEnemy.GetComponent<EnemyPathing>().SetWaveConfig(waveConfig);
            yield return new WaitForSeconds(waveConfig.GettimeBetweenSpawns());
        }

    }
}
