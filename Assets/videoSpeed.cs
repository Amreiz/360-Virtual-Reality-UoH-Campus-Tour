using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.Video;

public class videoSpeed : MonoBehaviour
{
    [SerializeField] private VideoPlayer videoPlayer;

    public void SetOneDotTwoPlaybackSpeed()
    {
        if (videoPlayer.canSetPlaybackSpeed)
        {
            videoPlayer.playbackSpeed = 1.2f;
        }
    }

    public void SetOneDotZeroPlaybackSpeed()
    {
        if (videoPlayer.canSetPlaybackSpeed)
        {
            videoPlayer.playbackSpeed = 1.0f;
        }
    }
}
