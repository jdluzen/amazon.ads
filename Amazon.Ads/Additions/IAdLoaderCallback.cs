namespace Com.Amazon.Device.Ads
{
    public interface IAdLoaderCallback
    {
        void HandleResponse();

        void AdFailed(AdError p0);

        void AdShown();

        int Timeout { get; }
    }
}
