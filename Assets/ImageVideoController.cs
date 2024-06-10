using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class ImageVideoController : MonoBehaviour
{
    public Image targetImage; // Reference to the Image component
    public VideoPlayer videoPlayer; // Reference to the VideoPlayer component
    public Sprite imageToShow; // The specific image to check for

    private void Start()
    {
        // Ensure the video is initially stopped
        videoPlayer.Stop();
    }

    private void Update()
    {
        // Check if the targetImage is active and displaying the specific image
        if (targetImage.gameObject.activeSelf && targetImage.sprite == imageToShow)
        {
            // Play the video if not already playing
            if (!videoPlayer.isPlaying)
            {
                videoPlayer.Play();
            }
        }
        else
        {
            // Stop the video if the image is not shown
            if (videoPlayer.isPlaying)
            {
                videoPlayer.Stop();
            }
        }
    }
}
