using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    [SerializeField] private AssetReference videoClip;
    [SerializeField] private VideoPlayer videoPlayer;
    [SerializeField] private GameObject loadingText;

    int count = 3;

    public void LoadAndPlayVideo()
    {
        StartCoroutine(loadingPause());
        Addressables.LoadAssetAsync<VideoClip>(videoClip).Completed += OnLoadAssetCompleted;
    }

    private void OnLoadAssetCompleted(AsyncOperationHandle<VideoClip> clip)
    {
        videoPlayer.clip = clip.Result;
        videoPlayer.Play();
    }

    IEnumerator loadingPause()
    {
        loadingText.SetActive(true);

        yield return new WaitForSeconds(count);

        if (count > 1)
        {
            count -= 2;
        }

        loadingText.SetActive(false);
    }
}

