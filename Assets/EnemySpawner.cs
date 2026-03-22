using System.Collections;
using UnityEngine;

[System.Serializable]
public class EnemyWave
{
    public Transform enemyPrefab;
    public int numberOfEnemy;
    public float spawnDelay = 0.5f; // Khoảng thời gian giữa mỗi con quái bay ra
    public FlyPath flyPath;
    public float speed;
    public float nextWaveDelay;
}

public class EnemySpawner : MonoBehaviour
{
    public EnemyWave[] enemyWaves;
    private int currentWave;
    public static bool isAllWavesSpawned = false; // Biến báo hiệu đẻ xong

    void Start()
    {
        isAllWavesSpawned = false;
        StartCoroutine(SpawnWaveRoutine());
    }

    private IEnumerator SpawnWaveRoutine()
    {
        while (currentWave < enemyWaves.Length)
        {
            var waveInfo = enemyWaves[currentWave];
            var startPosition = waveInfo.flyPath[0]; // Điểm đẻ luôn luôn là Waypoint 0

            // Sinh từng con quái một, chờ spawnDelay giây rồi mới sinh con tiếp theo
            for (int i = 0; i < waveInfo.numberOfEnemy; i++)
            {
                var enemy = Instantiate(waveInfo.enemyPrefab, startPosition, Quaternion.identity);
                var agent = enemy.GetComponent<FlyPathAgent>();

                agent.flyPath = waveInfo.flyPath;
                agent.flySpeed = waveInfo.speed;

                yield return new WaitForSeconds(waveInfo.spawnDelay); // Tạm dừng code để chờ
            }

            currentWave++;

            // Chờ thời gian nghỉ giữa các Wave
            if (currentWave < enemyWaves.Length)
            {
                yield return new WaitForSeconds(waveInfo.nextWaveDelay);
            }
        }

        // Đã sinh xong đợt quái cuối cùng!
        isAllWavesSpawned = true;
    }
}