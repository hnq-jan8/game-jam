using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosOnMap : MonoBehaviour
{
    [Header("Player boundaries")]
    public float maxX;
    public float minX;

    public float maxY;
    public float minY;

    private float xWorldDistance;
    private float yWorldDistance;

    [Header("MiniMap distances")]
    public float xMapDistance;
    public float yMapDistance;

    [Header("Player position")]
    public Transform thePlayer;


    [Header("Rect Transform Component")]
    public RectTransform playerPosOnMap;

    // Start is called before the first frame update
    void Start()
    {
        xWorldDistance = maxX - minX;
        yWorldDistance = maxY - minY;
    }

    // Update is called once per frame
    void Update()
    {
        float playerPosXOnMap = (thePlayer.position.x * xMapDistance) / xWorldDistance;
        float playerPosYOnMap = (thePlayer.position.y * yMapDistance) / yWorldDistance;
        playerPosOnMap.localPosition = new Vector3(playerPosXOnMap, playerPosYOnMap, 0);
    }
}
